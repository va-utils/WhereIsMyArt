using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetadataExtractor.Formats.Exif;
using System.Diagnostics;
namespace PhotoFinder
{

    struct Photo
    {
        public string DateTimeOriginal { get; set; } //дата фотосъемки
        public string Path { get; set; } //путь
        public string Software { get; set; } //название фоторедактора
    }
   
    class PhotoFinder
    {
        public event EventHandler FileFounded;

        public async Task<List<Photo>> StartFind(string path, CancellationToken token)
        {
            return await Task.Run(()=>Find(path,token),token);
        }
        
        private string GetDateTimeOriginal(IReadOnlyList<MetadataExtractor.Directory>  dirsPhoto)
        {
            var subIfdDirectory = dirsPhoto.OfType<ExifSubIfdDirectory>().FirstOrDefault();
            var dateTime = subIfdDirectory?.GetDescription(ExifDirectoryBase.TagDateTimeOriginal);
            return dateTime;
        }

        private string GetPhotoSoftware(IReadOnlyList<MetadataExtractor.Directory> dirsPhoto)
        {
            var IfdDirectory = dirsPhoto.OfType<ExifIfd0Directory>().FirstOrDefault();
            var softWare = IfdDirectory?.GetDescription(ExifDirectoryBase.TagSoftware);
            if(softWare!=null)
            {
                string[] popEditors = new string[] { "gimp","photoshop","lightroom","luminar","affinity","paint"};
                for(int i=0; i<popEditors.Length; i++)
                {
                    if (softWare.ToLower().Contains(popEditors[i]))
                        return softWare;
                }
            }
            return null;
        }

        private List<Photo> Find(string path, CancellationToken token)
        {
            
            List<Photo> result = new List<Photo>();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path, "*.*").Where((s) => s.ToLower().EndsWith(".jpg") || s.ToLower().EndsWith(".jpeg")).ToArray(); ;
            string sw = string.Empty;
            foreach(var f in files)
            {
                if (token.IsCancellationRequested)
                {
                    return result;
                }
                try
                {
                    var dirsPhoto = MetadataExtractor.ImageMetadataReader.ReadMetadata(Path.GetFullPath(f));
                    if ((sw = GetPhotoSoftware(dirsPhoto)) != null)
                    {
                        FileFounded?.Invoke(this, new EventArgs());
                        Photo photo = new Photo();

                        string datetime = GetDateTimeOriginal(dirsPhoto);
                        if (datetime == null)
                        {
                            photo.DateTimeOriginal = "Неизвестно";
                        }
                        else
                        {
                            photo.DateTimeOriginal = DateTime.ParseExact(datetime, "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture).ToString("f");
                        }

                        photo.Software = sw;
                        photo.Path = f;

                        result.Add(photo);
                    }
                }
                catch(MetadataExtractor.ImageProcessingException ipe)
                {
                    Trace.WriteLine(DateTime.Now.ToString("f") + " : " + ipe.Message);
                }
                catch(IOException ioe)
                {
                    Trace.WriteLine(DateTime.Now.ToString("f") + " : " + ioe.Message);
                }
            }

            foreach (var p in dirs)
            {
                if (token.IsCancellationRequested)
                {
                    return result;
                }
                try
                {
                    result.AddRange(Find(p,token));
                }
                catch(UnauthorizedAccessException uae)
                {
                    Trace.WriteLine(DateTime.Now.ToString("f") + " : " + uae.Message);   
                }               
            }
            return result;
        }

        

           
    }
}
