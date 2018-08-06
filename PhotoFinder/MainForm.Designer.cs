namespace PhotoFinder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.path = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.infoImage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.viewImage = new System.Windows.Forms.PictureBox();
            this.infoImg = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changedFiles = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressAnimation = new System.Windows.Forms.ToolStripProgressBar();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.infoImage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.27605F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.72395F));
            this.tableLayoutPanel1.Controls.Add(this.path, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.browse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.start, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.infoImage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // path
            // 
            this.path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.path.Location = new System.Drawing.Point(5, 5);
            this.path.Margin = new System.Windows.Forms.Padding(5);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(464, 20);
            this.path.TabIndex = 0;
            // 
            // browse
            // 
            this.browse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browse.Location = new System.Drawing.Point(479, 5);
            this.browse.Margin = new System.Windows.Forms.Padding(5);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(255, 22);
            this.browse.TabIndex = 1;
            this.browse.Text = "Обзор...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Здесь будут выводиться файлы изображений, которые предположительно были обработан" +
    "ы в графическом редакторе. Для начала нажмите кнопку \"Старт\"";
            // 
            // start
            // 
            this.start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start.Location = new System.Drawing.Point(479, 37);
            this.start.Margin = new System.Windows.Forms.Padding(5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(255, 22);
            this.start.TabIndex = 2;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // infoImage
            // 
            this.infoImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoImage.Controls.Add(this.tableLayoutPanel2);
            this.infoImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoImage.Location = new System.Drawing.Point(477, 67);
            this.infoImage.Name = "infoImage";
            this.infoImage.Size = new System.Drawing.Size(259, 252);
            this.infoImage.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.viewImage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.infoImg, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.about, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(257, 250);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // viewImage
            // 
            this.viewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewImage.Location = new System.Drawing.Point(5, 5);
            this.viewImage.Margin = new System.Windows.Forms.Padding(5);
            this.viewImage.Name = "viewImage";
            this.viewImage.Size = new System.Drawing.Size(247, 112);
            this.viewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewImage.TabIndex = 2;
            this.viewImage.TabStop = false;
            // 
            // infoImg
            // 
            this.infoImg.AutoSize = true;
            this.infoImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoImg.Location = new System.Drawing.Point(3, 122);
            this.infoImg.Name = "infoImg";
            this.infoImg.Size = new System.Drawing.Size(251, 97);
            this.infoImg.TabIndex = 3;
            this.infoImg.Text = "Информация о фото...";
            this.infoImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // about
            // 
            this.about.Dock = System.Windows.Forms.DockStyle.Fill;
            this.about.Location = new System.Drawing.Point(5, 224);
            this.about.Margin = new System.Windows.Forms.Padding(5);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(247, 21);
            this.about.TabIndex = 4;
            this.about.Text = "О программе";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.changedFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 252);
            this.panel1.TabIndex = 6;
            // 
            // changedFiles
            // 
            this.changedFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changedFiles.FormattingEnabled = true;
            this.changedFiles.Location = new System.Drawing.Point(0, 0);
            this.changedFiles.Margin = new System.Windows.Forms.Padding(5);
            this.changedFiles.Name = "changedFiles";
            this.changedFiles.Size = new System.Drawing.Size(466, 250);
            this.changedFiles.TabIndex = 3;
            this.changedFiles.SelectedIndexChanged += new System.EventHandler(this.changedFiles_SelectedIndexChanged);
            this.changedFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changedFiles_MouseDown);
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.progressAnimation});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(739, 20);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(89, 15);
            this.toolStripStatusLabel.Text = "Готов к поиску";
            // 
            // progressAnimation
            // 
            this.progressAnimation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressAnimation.MarqueeAnimationSpeed = 10;
            this.progressAnimation.Name = "progressAnimation";
            this.progressAnimation.Size = new System.Drawing.Size(100, 14);
            this.progressAnimation.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressAnimation.Visible = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.openDirectory});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(212, 48);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(211, 22);
            this.openFile.Text = "Открыть файл";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // openDirectory
            // 
            this.openDirectory.Name = "openDirectory";
            this.openDirectory.Size = new System.Drawing.Size(211, 22);
            this.openDirectory.Text = "Открыть место хранения";
            this.openDirectory.Click += new System.EventHandler(this.openDirectory_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WhereIsMyArt?";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.infoImage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel infoImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox viewImage;
        private System.Windows.Forms.Label infoImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox changedFiles;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressAnimation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem openDirectory;
       // private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button about;
    }
}

