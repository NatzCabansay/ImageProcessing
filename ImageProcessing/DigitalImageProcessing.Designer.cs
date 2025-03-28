namespace ImageProcessing
{
    partial class DigitalImageProcessing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveResultToolStripMenuItem = new ToolStripMenuItem();
            tbcImageProcessing = new TabControl();
            tabBasicDigitalImageProcessing = new TabPage();
            tlpPictures = new TableLayoutPanel();
            picLoaded = new PictureBox();
            picProcessed = new PictureBox();
            gbxBrightness = new GroupBox();
            nspBrightness = new NumericUpDown();
            lblBrightness = new Label();
            gbxContrast = new GroupBox();
            cbxEnable = new CheckBox();
            nspContrast = new NumericUpDown();
            btnContrastAdjust = new Button();
            lblContrast = new Label();
            gbxRotation = new GroupBox();
            btnReset = new Button();
            nspRotate = new NumericUpDown();
            lblRotate = new Label();
            gbxReflection = new GroupBox();
            btnReflectV = new Button();
            btnReflectH = new Button();
            pnlBefore = new Panel();
            lblLoaded = new Label();
            btnLoad = new Button();
            pnlAfter = new Panel();
            drpOptions = new ComboBox();
            btnApply = new Button();
            tabImageSub = new TabPage();
            tlpImageSub = new TableLayoutPanel();
            pnlResult = new Panel();
            btnGenerateResult = new Button();
            pnlFGImage = new Panel();
            label1 = new Label();
            btnForeground = new Button();
            picResult = new PictureBox();
            picForeground = new PictureBox();
            picBackground = new PictureBox();
            pnlBGImage = new Panel();
            lblForeground = new Label();
            btnBackground = new Button();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            tbcImageProcessing.SuspendLayout();
            tabBasicDigitalImageProcessing.SuspendLayout();
            tlpPictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoaded).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProcessed).BeginInit();
            gbxBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nspBrightness).BeginInit();
            gbxContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nspContrast).BeginInit();
            gbxRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nspRotate).BeginInit();
            gbxReflection.SuspendLayout();
            pnlBefore.SuspendLayout();
            pnlAfter.SuspendLayout();
            tabImageSub.SuspendLayout();
            tlpImageSub.SuspendLayout();
            pnlResult.SuspendLayout();
            pnlFGImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picForeground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            pnlBGImage.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1335, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveResultToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveResultToolStripMenuItem
            // 
            saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            saveResultToolStripMenuItem.Size = new Size(133, 22);
            saveResultToolStripMenuItem.Text = "Save Result";
            saveResultToolStripMenuItem.Click += saveResultToolStripMenuItem_Click;
            // 
            // tbcImageProcessing
            // 
            tbcImageProcessing.Controls.Add(tabBasicDigitalImageProcessing);
            tbcImageProcessing.Controls.Add(tabImageSub);
            tbcImageProcessing.Dock = DockStyle.Fill;
            tbcImageProcessing.Location = new Point(0, 24);
            tbcImageProcessing.Name = "tbcImageProcessing";
            tbcImageProcessing.SelectedIndex = 0;
            tbcImageProcessing.Size = new Size(1335, 459);
            tbcImageProcessing.TabIndex = 1;
            // 
            // tabBasicDigitalImageProcessing
            // 
            tabBasicDigitalImageProcessing.Controls.Add(tlpPictures);
            tabBasicDigitalImageProcessing.Location = new Point(4, 24);
            tabBasicDigitalImageProcessing.Name = "tabBasicDigitalImageProcessing";
            tabBasicDigitalImageProcessing.Padding = new Padding(3);
            tabBasicDigitalImageProcessing.Size = new Size(1327, 431);
            tabBasicDigitalImageProcessing.TabIndex = 0;
            tabBasicDigitalImageProcessing.Text = "Basic Digital Image Processing";
            tabBasicDigitalImageProcessing.UseVisualStyleBackColor = true;
            // 
            // tlpPictures
            // 
            tlpPictures.ColumnCount = 2;
            tlpPictures.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPictures.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPictures.Controls.Add(picLoaded, 0, 2);
            tlpPictures.Controls.Add(picProcessed, 1, 2);
            tlpPictures.Controls.Add(gbxBrightness, 1, 0);
            tlpPictures.Controls.Add(gbxContrast, 0, 0);
            tlpPictures.Controls.Add(gbxRotation, 0, 1);
            tlpPictures.Controls.Add(gbxReflection, 1, 1);
            tlpPictures.Controls.Add(pnlBefore, 0, 3);
            tlpPictures.Controls.Add(pnlAfter, 1, 3);
            tlpPictures.Dock = DockStyle.Fill;
            tlpPictures.Location = new Point(3, 3);
            tlpPictures.Name = "tlpPictures";
            tlpPictures.RowCount = 4;
            tlpPictures.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpPictures.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpPictures.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpPictures.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPictures.Size = new Size(1321, 425);
            tlpPictures.TabIndex = 3;
            // 
            // picLoaded
            // 
            picLoaded.Dock = DockStyle.Fill;
            picLoaded.Location = new Point(170, 110);
            picLoaded.Margin = new Padding(170, 10, 170, 10);
            picLoaded.Name = "picLoaded";
            picLoaded.Size = new Size(320, 240);
            picLoaded.SizeMode = PictureBoxSizeMode.Zoom;
            picLoaded.TabIndex = 0;
            picLoaded.TabStop = false;
            // 
            // picProcessed
            // 
            picProcessed.Dock = DockStyle.Fill;
            picProcessed.Location = new Point(830, 110);
            picProcessed.Margin = new Padding(170, 10, 170, 10);
            picProcessed.Name = "picProcessed";
            picProcessed.Size = new Size(321, 240);
            picProcessed.SizeMode = PictureBoxSizeMode.Zoom;
            picProcessed.TabIndex = 2;
            picProcessed.TabStop = false;
            // 
            // gbxBrightness
            // 
            gbxBrightness.Controls.Add(nspBrightness);
            gbxBrightness.Controls.Add(lblBrightness);
            gbxBrightness.Dock = DockStyle.Fill;
            gbxBrightness.Location = new Point(670, 3);
            gbxBrightness.Margin = new Padding(10, 3, 10, 3);
            gbxBrightness.Name = "gbxBrightness";
            gbxBrightness.Size = new Size(641, 44);
            gbxBrightness.TabIndex = 4;
            gbxBrightness.TabStop = false;
            gbxBrightness.Text = "Brightness";
            // 
            // nspBrightness
            // 
            nspBrightness.Dock = DockStyle.Right;
            nspBrightness.Location = new Point(583, 19);
            nspBrightness.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nspBrightness.Name = "nspBrightness";
            nspBrightness.Size = new Size(55, 23);
            nspBrightness.TabIndex = 1;
            // 
            // lblBrightness
            // 
            lblBrightness.AutoSize = true;
            lblBrightness.Dock = DockStyle.Left;
            lblBrightness.Font = new Font("Segoe UI", 12F);
            lblBrightness.Location = new Point(3, 19);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(179, 21);
            lblBrightness.TabIndex = 0;
            lblBrightness.Text = "Brightness (-100 to 100)";
            // 
            // gbxContrast
            // 
            gbxContrast.Controls.Add(cbxEnable);
            gbxContrast.Controls.Add(nspContrast);
            gbxContrast.Controls.Add(btnContrastAdjust);
            gbxContrast.Controls.Add(lblContrast);
            gbxContrast.Dock = DockStyle.Fill;
            gbxContrast.Location = new Point(10, 3);
            gbxContrast.Margin = new Padding(10, 3, 10, 3);
            gbxContrast.Name = "gbxContrast";
            gbxContrast.Size = new Size(640, 44);
            gbxContrast.TabIndex = 5;
            gbxContrast.TabStop = false;
            gbxContrast.Text = "Contrast";
            // 
            // cbxEnable
            // 
            cbxEnable.AutoSize = true;
            cbxEnable.Dock = DockStyle.Fill;
            cbxEnable.Location = new Point(144, 19);
            cbxEnable.Name = "cbxEnable";
            cbxEnable.Size = new Size(355, 22);
            cbxEnable.TabIndex = 3;
            cbxEnable.Text = "Enable";
            cbxEnable.UseVisualStyleBackColor = true;
            // 
            // nspContrast
            // 
            nspContrast.Dock = DockStyle.Right;
            nspContrast.Location = new Point(499, 19);
            nspContrast.Name = "nspContrast";
            nspContrast.Size = new Size(63, 23);
            nspContrast.TabIndex = 2;
            nspContrast.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // btnContrastAdjust
            // 
            btnContrastAdjust.Dock = DockStyle.Right;
            btnContrastAdjust.Location = new Point(562, 19);
            btnContrastAdjust.Name = "btnContrastAdjust";
            btnContrastAdjust.Size = new Size(75, 22);
            btnContrastAdjust.TabIndex = 1;
            btnContrastAdjust.Text = "Adjust";
            btnContrastAdjust.UseVisualStyleBackColor = true;
            // 
            // lblContrast
            // 
            lblContrast.AutoSize = true;
            lblContrast.Dock = DockStyle.Left;
            lblContrast.Font = new Font("Segoe UI", 12F);
            lblContrast.Location = new Point(3, 19);
            lblContrast.Name = "lblContrast";
            lblContrast.Size = new Size(141, 21);
            lblContrast.TabIndex = 0;
            lblContrast.Text = "Contrast (0 to 100)";
            // 
            // gbxRotation
            // 
            gbxRotation.Controls.Add(btnReset);
            gbxRotation.Controls.Add(nspRotate);
            gbxRotation.Controls.Add(lblRotate);
            gbxRotation.Dock = DockStyle.Fill;
            gbxRotation.Location = new Point(10, 53);
            gbxRotation.Margin = new Padding(10, 3, 10, 3);
            gbxRotation.Name = "gbxRotation";
            gbxRotation.Size = new Size(640, 44);
            gbxRotation.TabIndex = 6;
            gbxRotation.TabStop = false;
            gbxRotation.Text = "Rotation";
            // 
            // btnReset
            // 
            btnReset.Dock = DockStyle.Right;
            btnReset.Location = new Point(562, 19);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 22);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // nspRotate
            // 
            nspRotate.Dock = DockStyle.Left;
            nspRotate.Location = new Point(240, 19);
            nspRotate.Margin = new Padding(15, 3, 3, 3);
            nspRotate.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nspRotate.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nspRotate.Name = "nspRotate";
            nspRotate.Size = new Size(75, 23);
            nspRotate.TabIndex = 1;
            // 
            // lblRotate
            // 
            lblRotate.AutoSize = true;
            lblRotate.Dock = DockStyle.Left;
            lblRotate.Font = new Font("Segoe UI", 10F);
            lblRotate.Location = new Point(3, 19);
            lblRotate.Name = "lblRotate";
            lblRotate.Size = new Size(237, 19);
            lblRotate.TabIndex = 0;
            lblRotate.Text = "Rotate (-180° to 180°, + = clockwise)";
            // 
            // gbxReflection
            // 
            gbxReflection.Controls.Add(btnReflectV);
            gbxReflection.Controls.Add(btnReflectH);
            gbxReflection.Dock = DockStyle.Fill;
            gbxReflection.Location = new Point(670, 53);
            gbxReflection.Margin = new Padding(10, 3, 10, 3);
            gbxReflection.Name = "gbxReflection";
            gbxReflection.Padding = new Padding(20, 3, 3, 3);
            gbxReflection.Size = new Size(641, 44);
            gbxReflection.TabIndex = 7;
            gbxReflection.TabStop = false;
            gbxReflection.Text = "Reflection";
            // 
            // btnReflectV
            // 
            btnReflectV.Location = new Point(105, 19);
            btnReflectV.Margin = new Padding(10, 3, 10, 3);
            btnReflectV.Name = "btnReflectV";
            btnReflectV.Size = new Size(75, 22);
            btnReflectV.TabIndex = 1;
            btnReflectV.Text = "Vertical";
            btnReflectV.UseVisualStyleBackColor = true;
            // 
            // btnReflectH
            // 
            btnReflectH.Dock = DockStyle.Left;
            btnReflectH.Location = new Point(20, 19);
            btnReflectH.Margin = new Padding(10, 3, 10, 3);
            btnReflectH.Name = "btnReflectH";
            btnReflectH.Size = new Size(75, 22);
            btnReflectH.TabIndex = 0;
            btnReflectH.Text = "Horizontal";
            btnReflectH.UseVisualStyleBackColor = true;
            // 
            // pnlBefore
            // 
            pnlBefore.Controls.Add(lblLoaded);
            pnlBefore.Controls.Add(btnLoad);
            pnlBefore.Dock = DockStyle.Fill;
            pnlBefore.Location = new Point(10, 370);
            pnlBefore.Margin = new Padding(10);
            pnlBefore.Name = "pnlBefore";
            pnlBefore.Size = new Size(640, 45);
            pnlBefore.TabIndex = 8;
            // 
            // lblLoaded
            // 
            lblLoaded.Dock = DockStyle.Fill;
            lblLoaded.Font = new Font("Segoe UI", 12F);
            lblLoaded.Location = new Point(0, 0);
            lblLoaded.Margin = new Padding(10);
            lblLoaded.Name = "lblLoaded";
            lblLoaded.Size = new Size(499, 45);
            lblLoaded.TabIndex = 4;
            lblLoaded.Text = "Original Image";
            lblLoaded.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            btnLoad.Dock = DockStyle.Right;
            btnLoad.Font = new Font("Segoe UI", 12F);
            btnLoad.Location = new Point(499, 0);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(141, 45);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load Image";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // pnlAfter
            // 
            pnlAfter.Controls.Add(drpOptions);
            pnlAfter.Controls.Add(btnApply);
            pnlAfter.Dock = DockStyle.Fill;
            pnlAfter.Location = new Point(670, 370);
            pnlAfter.Margin = new Padding(10);
            pnlAfter.Name = "pnlAfter";
            pnlAfter.Size = new Size(641, 45);
            pnlAfter.TabIndex = 9;
            // 
            // drpOptions
            // 
            drpOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            drpOptions.Font = new Font("Segoe UI", 12F);
            drpOptions.FormattingEnabled = true;
            drpOptions.Items.AddRange(new object[] { "Pixel Copy", "Simple Grayscale", "Enhanced Grayscale", "Invert", "Histogram", "Sepia" });
            drpOptions.Location = new Point(10, 8);
            drpOptions.Name = "drpOptions";
            drpOptions.Size = new Size(502, 29);
            drpOptions.TabIndex = 1;
            // 
            // btnApply
            // 
            btnApply.Dock = DockStyle.Right;
            btnApply.Font = new Font("Segoe UI", 12F);
            btnApply.Location = new Point(518, 0);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(123, 45);
            btnApply.TabIndex = 0;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // tabImageSub
            // 
            tabImageSub.Controls.Add(tlpImageSub);
            tabImageSub.Location = new Point(4, 24);
            tabImageSub.Name = "tabImageSub";
            tabImageSub.Padding = new Padding(3);
            tabImageSub.Size = new Size(1327, 431);
            tabImageSub.TabIndex = 1;
            tabImageSub.Text = "Image Subtraction";
            tabImageSub.UseVisualStyleBackColor = true;
            // 
            // tlpImageSub
            // 
            tlpImageSub.ColumnCount = 3;
            tlpImageSub.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpImageSub.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpImageSub.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpImageSub.Controls.Add(pnlResult, 2, 1);
            tlpImageSub.Controls.Add(pnlFGImage, 1, 1);
            tlpImageSub.Controls.Add(picResult, 2, 0);
            tlpImageSub.Controls.Add(picForeground, 1, 0);
            tlpImageSub.Controls.Add(picBackground, 0, 0);
            tlpImageSub.Controls.Add(pnlBGImage, 0, 1);
            tlpImageSub.Dock = DockStyle.Fill;
            tlpImageSub.Location = new Point(3, 3);
            tlpImageSub.Margin = new Padding(0);
            tlpImageSub.Name = "tlpImageSub";
            tlpImageSub.RowCount = 2;
            tlpImageSub.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpImageSub.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpImageSub.Size = new Size(1321, 425);
            tlpImageSub.TabIndex = 0;
            // 
            // pnlResult
            // 
            pnlResult.Controls.Add(btnGenerateResult);
            pnlResult.Dock = DockStyle.Fill;
            pnlResult.Location = new Point(890, 350);
            pnlResult.Margin = new Padding(10);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(421, 65);
            pnlResult.TabIndex = 5;
            // 
            // btnGenerateResult
            // 
            btnGenerateResult.Dock = DockStyle.Top;
            btnGenerateResult.Font = new Font("Segoe UI", 16F);
            btnGenerateResult.Location = new Point(0, 0);
            btnGenerateResult.Name = "btnGenerateResult";
            btnGenerateResult.Size = new Size(421, 65);
            btnGenerateResult.TabIndex = 0;
            btnGenerateResult.Text = "Generate Subtracted Image";
            btnGenerateResult.UseVisualStyleBackColor = true;
            btnGenerateResult.Click += btnGenerateResult_Click;
            // 
            // pnlFGImage
            // 
            pnlFGImage.Controls.Add(label1);
            pnlFGImage.Controls.Add(btnForeground);
            pnlFGImage.Dock = DockStyle.Fill;
            pnlFGImage.Location = new Point(450, 350);
            pnlFGImage.Margin = new Padding(10);
            pnlFGImage.Name = "pnlFGImage";
            pnlFGImage.Size = new Size(420, 65);
            pnlFGImage.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(318, 65);
            label1.TabIndex = 2;
            label1.Text = "Foreground Image";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnForeground
            // 
            btnForeground.Dock = DockStyle.Right;
            btnForeground.Location = new Point(318, 0);
            btnForeground.Name = "btnForeground";
            btnForeground.Size = new Size(102, 65);
            btnForeground.TabIndex = 1;
            btnForeground.Text = "Load Foreground Image";
            btnForeground.UseVisualStyleBackColor = true;
            btnForeground.Click += btnForeground_Click;
            // 
            // picResult
            // 
            picResult.Dock = DockStyle.Fill;
            picResult.Location = new Point(900, 20);
            picResult.Margin = new Padding(20);
            picResult.Name = "picResult";
            picResult.Size = new Size(401, 300);
            picResult.SizeMode = PictureBoxSizeMode.Zoom;
            picResult.TabIndex = 2;
            picResult.TabStop = false;
            // 
            // picForeground
            // 
            picForeground.Dock = DockStyle.Fill;
            picForeground.Location = new Point(460, 20);
            picForeground.Margin = new Padding(20);
            picForeground.Name = "picForeground";
            picForeground.Size = new Size(400, 300);
            picForeground.SizeMode = PictureBoxSizeMode.Zoom;
            picForeground.TabIndex = 1;
            picForeground.TabStop = false;
            // 
            // picBackground
            // 
            picBackground.Dock = DockStyle.Fill;
            picBackground.Location = new Point(20, 20);
            picBackground.Margin = new Padding(20);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(400, 300);
            picBackground.SizeMode = PictureBoxSizeMode.Zoom;
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            // 
            // pnlBGImage
            // 
            pnlBGImage.Controls.Add(lblForeground);
            pnlBGImage.Controls.Add(btnBackground);
            pnlBGImage.Dock = DockStyle.Fill;
            pnlBGImage.Location = new Point(10, 350);
            pnlBGImage.Margin = new Padding(10);
            pnlBGImage.Name = "pnlBGImage";
            pnlBGImage.Size = new Size(420, 65);
            pnlBGImage.TabIndex = 3;
            // 
            // lblForeground
            // 
            lblForeground.Dock = DockStyle.Fill;
            lblForeground.Font = new Font("Segoe UI", 16F);
            lblForeground.Location = new Point(0, 0);
            lblForeground.Name = "lblForeground";
            lblForeground.Size = new Size(318, 65);
            lblForeground.TabIndex = 1;
            lblForeground.Text = "Background Image";
            lblForeground.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBackground
            // 
            btnBackground.Dock = DockStyle.Right;
            btnBackground.Location = new Point(318, 0);
            btnBackground.Name = "btnBackground";
            btnBackground.Size = new Size(102, 65);
            btnBackground.TabIndex = 0;
            btnBackground.Text = "Load Background Image";
            btnBackground.UseVisualStyleBackColor = true;
            btnBackground.Click += btnBackground_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.FileOk += openFileDialog3_FileOk;
            // 
            // DigitalImageProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 483);
            Controls.Add(tbcImageProcessing);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "DigitalImageProcessing";
            Text = "Digital Image Processing";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tbcImageProcessing.ResumeLayout(false);
            tabBasicDigitalImageProcessing.ResumeLayout(false);
            tlpPictures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLoaded).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProcessed).EndInit();
            gbxBrightness.ResumeLayout(false);
            gbxBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nspBrightness).EndInit();
            gbxContrast.ResumeLayout(false);
            gbxContrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nspContrast).EndInit();
            gbxRotation.ResumeLayout(false);
            gbxRotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nspRotate).EndInit();
            gbxReflection.ResumeLayout(false);
            pnlBefore.ResumeLayout(false);
            pnlAfter.ResumeLayout(false);
            tabImageSub.ResumeLayout(false);
            tlpImageSub.ResumeLayout(false);
            pnlResult.ResumeLayout(false);
            pnlFGImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)picForeground).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            pnlBGImage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveResultToolStripMenuItem;
        private TabControl tbcImageProcessing;
        private TabPage tabBasicDigitalImageProcessing;
        private TableLayoutPanel tlpPictures;
        private PictureBox picLoaded;
        private PictureBox picProcessed;
        private GroupBox gbxBrightness;
        private NumericUpDown nspBrightness;
        private Label lblBrightness;
        private GroupBox gbxContrast;
        private CheckBox cbxEnable;
        private NumericUpDown nspContrast;
        private Button btnContrastAdjust;
        private Label lblContrast;
        private GroupBox gbxRotation;
        private Button btnReset;
        private NumericUpDown nspRotate;
        private Label lblRotate;
        private GroupBox gbxReflection;
        private Button btnReflectV;
        private Button btnReflectH;
        private Panel pnlBefore;
        private Label lblLoaded;
        private Button btnLoad;
        private Panel pnlAfter;
        private Button btnApply;
        private TabPage tabImageSub;
        private ComboBox drpOptions;
        private TableLayoutPanel tlpImageSub;
        private PictureBox picBackground;
        private PictureBox picResult;
        private PictureBox picForeground;
        private Panel pnlResult;
        private Panel pnlFGImage;
        private Panel pnlBGImage;
        private Button btnGenerateResult;
        private Label label1;
        private Button btnForeground;
        private Label lblForeground;
        private Button btnBackground;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
    }
}
