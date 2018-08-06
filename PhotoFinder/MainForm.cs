using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoFinder
{
    public partial class MainForm : Form
    {
        CancellationTokenSource cancellationTokenSource;
        CancellationToken token;
        int selectedIndexForContextMenu;
        FormWindowState LastWindowState = FormWindowState.Minimized;
        Size formSize;
        List<Photo> list = new List<Photo>();
        public MainForm()
        {
            Trace.Listeners.Clear(); //настройка ведения логов
            Trace.Listeners.Add(new TextWriterTraceListener("trace.txt"));
            Trace.AutoFlush = true;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            contextMenuStrip.Items.Insert(0, new ToolStripLabel("...")); //создание заголовка для меню
            contextMenuStrip.Items[0].ForeColor = Color.SteelBlue;
            formSize = Size;
            LastWindowState = WindowState;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {   
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    path.Text = dialog.SelectedPath;
                }
            }
        }

        private void stopFind(object sender, EventArgs e) //остановка поиска
        {
            cancellationTokenSource?.Cancel();           
        }

        private async void start_Click(object sender, EventArgs e) //старт поиска
        {
            if (System.IO.Directory.Exists(path.Text))
            {
                int filesCount = 0;

                cancellationTokenSource = new CancellationTokenSource();
                token = cancellationTokenSource.Token;

                progressAnimation.Visible = true;
                toolStripStatusLabel.Text = "Выполняется поиск...";

                //----смена функционала кнопки на "стоп"
                start.Text = "Стоп";
                start.Click -= start_Click;
                start.Click += stopFind;
                //--------------------------------------

                PhotoFinder pf = new PhotoFinder();
                
                pf.FileFounded += ((s,ea) => //подпишемся на событие о том, что найден подходящий файл
                {
                    if (this.InvokeRequired)
                        Invoke(new Action<int>((count) => toolStripStatusLabel.Text = "Найдено: " + count), ++filesCount);
                    else
                        toolStripStatusLabel.Text = "Найдено: " + ++filesCount;
                });

                list = await pf.StartFind(path.Text,token);

                if (list!=null)
                {
                    changedFiles.DataSource = list;
                    changedFiles.DisplayMember = "Path";
                }
                              
                toolStripStatusLabel.Text = "Готов к поиску";
                progressAnimation.Visible = false;

                //---поиск закончен, меняем функционал кнопки обратно на "старт"
                start.Text = "Старт";
                start.Click -= stopFind;
                start.Click += start_Click;        
                //---------------------------------------------------------------

            }
            else
            {
                MessageBox.Show("Возможно, Вы ошиблись при выборе начальной папки поиска. Нажмите \"Обзор\" и выберите папку еще раз.");
            }
            
        }

        private void changedFiles_SelectedIndexChanged(object sender, EventArgs e) //покажем изображение и сведения о нем
        {
           infoImg.Text = string.Format("Снимок сделан: {0}\nПоследнее изменение файла: {1}\nРедактирован: {2}", list[changedFiles.SelectedIndex].DateTimeOriginal,
         
               System.IO.File.GetLastWriteTime(list[changedFiles.SelectedIndex].Path).ToLocalTime().ToString("f"),
                   list[changedFiles.SelectedIndex].Software);

            viewImage.Image = ScaleImage(Image.FromFile(list[changedFiles.SelectedIndex].Path), viewImage.Size.Width, viewImage.Size.Height);
        }

        Image ScaleImage(Image source, int width, int height) //сохраним пропорции изображения
        {
            Image dest = new Bitmap(width, height);
            
            using (Graphics gr = Graphics.FromImage(dest))
            {
                
                gr.FillRectangle(new SolidBrush(BackColor), 0, 0, width, height);  // Очищаем экран
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;

                float srcwidth = source.Width;
                float srcheight = source.Height;
                float dstwidth = width;
                float dstheight = height;

                if (srcwidth <= dstwidth && srcheight <= dstheight)  // Исходное изображение меньше целевого
                {
                    int left = (width - source.Width) / 2;
                    int top = (height - source.Height) / 2;
                    gr.DrawImage(source, left, top, source.Width, source.Height);
                }
                else if (srcwidth / srcheight > dstwidth / dstheight)  // Пропорции исходного изображения более широкие
                {
                    float cy = srcheight / srcwidth * dstwidth;
                    float top = ((float)dstheight - cy) / 2.0f;
                    if (top < 1.0f) top = 0;
                    gr.DrawImage(source, 0, top, dstwidth, cy);
                }
                else  // Пропорции исходного изображения более узкие
                {
                    float cx = srcwidth / srcheight * dstheight;
                    float left = ((float)dstwidth - cx) / 2.0f;
                    if (left < 1.0f) left = 0;
                    gr.DrawImage(source, left, 0, cx, dstheight);
                }

                return dest;
            }
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            if (Size != formSize)
            {
                if (viewImage.Image != null)
                    viewImage.Image = ScaleImage(Image.FromFile(list[changedFiles.SelectedIndex].Path), viewImage.Size.Width, viewImage.Size.Height);
            }
        }

        
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                if (viewImage.Image != null)
                    viewImage.Image = ScaleImage(Image.FromFile(list[changedFiles.SelectedIndex].Path), viewImage.Size.Width, viewImage.Size.Height);
            }
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            formSize = Size;
        }

        private void changedFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int i = changedFiles.IndexFromPoint(e.X,e.Y);
                if (i != -1)
                {
                    selectedIndexForContextMenu = i;
                    contextMenuStrip.Items[0].Text = list[i].Path;
                    contextMenuStrip.Show(MousePosition);
                }
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(list[selectedIndexForContextMenu].Path);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Trace.WriteLine(DateTime.Now.ToString("f") + " : " + ex.Message);
            }
        }

        private void openDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(System.IO.Path.GetDirectoryName(list[selectedIndexForContextMenu].Path));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Trace.WriteLine(DateTime.Now.ToString("f") + " : " + ex.Message);
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0} вер. {1}\nЕсли Вы нашли проблему, сообщите пожалуйста мне на email: viktor70@protonmail.com\nСпасибо за использование! Автор программы: Вяличкин В.А. \n\nИспользуется библиотека MetadataExtractor 2.0.0.0",Application.ProductName,Application.ProductVersion));
        }
    }
}
