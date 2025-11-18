namespace ImageCompressionSoft
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            pnlDragAndDrop = new Panel();
            label1 = new Label();
            btnOpenFolder = new Button();
            outputCbExtention = new ComboBox();
            label4 = new Label();
            outputTbPattern = new TextBox();
            label2 = new Label();
            outputRbSelectedFolder = new RadioButton();
            outputRbImageFolder = new RadioButton();
            btnOutFolderSelect = new Button();
            label3 = new Label();
            outputTbFolderName = new TextBox();
            tabSetting = new TabControl();
            tpPerSetting = new TabPage();
            ratio_ApplyTypeSelector = new ImageResizeSoft.UC_ApplyTypeSelector();
            label6 = new Label();
            label11 = new Label();
            label12 = new Label();
            ratio_SettingBtn = new Button();
            label13 = new Label();
            ratio_Height = new TextBox();
            ratio_Width = new TextBox();
            tabPage1 = new TabPage();
            pixel_ApplyTypeSelector = new ImageResizeSoft.UC_ApplyTypeSelector();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pixel_lHeight = new TextBox();
            pixel_lWidth = new TextBox();
            pixel_SettingBtn = new Button();
            btnOutput = new Button();
            plFileSetting = new Panel();
            output_ApplyTypeSelector = new ImageResizeSoft.UC_ApplyTypeSelector();
            versionLabel = new Label();
            webSiteIcon = new PictureBox();
            lblFolderPath = new Label();
            outputLbFolderPath = new Label();
            ApplySettingLabel = new Label();
            ucImageSettingListdgv = new ImageResizeSoft.UC_ImageSettingListDGV();
            groupBox1.SuspendLayout();
            pnlDragAndDrop.SuspendLayout();
            tabSetting.SuspendLayout();
            tpPerSetting.SuspendLayout();
            tabPage1.SuspendLayout();
            plFileSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webSiteIcon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pnlDragAndDrop);
            groupBox1.Controls.Add(btnOpenFolder);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(747, 121);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // pnlDragAndDrop
            // 
            pnlDragAndDrop.AllowDrop = true;
            pnlDragAndDrop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDragAndDrop.BackColor = Color.WhiteSmoke;
            pnlDragAndDrop.Controls.Add(label1);
            pnlDragAndDrop.Location = new Point(6, 14);
            pnlDragAndDrop.Name = "pnlDragAndDrop";
            pnlDragAndDrop.Size = new Size(538, 102);
            pnlDragAndDrop.TabIndex = 1;
            pnlDragAndDrop.DragDrop += pnlDragAndDrop_DragDrop;
            pnlDragAndDrop.DragEnter += pnlDragAndDrop_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(99, 40);
            label1.Name = "label1";
            label1.Size = new Size(335, 28);
            label1.TabIndex = 0;
            label1.Text = "画像をドラッグ&ドロップしてください";
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenFolder.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnOpenFolder.Location = new Point(551, 14);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new Size(192, 68);
            btnOpenFolder.TabIndex = 0;
            btnOpenFolder.Text = "フォルダから選択";
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // outputCbExtention
            // 
            outputCbExtention.DropDownStyle = ComboBoxStyle.DropDownList;
            outputCbExtention.Font = new Font("メイリオ", 11.25F);
            outputCbExtention.FormattingEnabled = true;
            outputCbExtention.Location = new Point(243, 147);
            outputCbExtention.Name = "outputCbExtention";
            outputCbExtention.Size = new Size(189, 31);
            outputCbExtention.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("メイリオ", 11.25F);
            label4.Location = new Point(122, 153);
            label4.Name = "label4";
            label4.Size = new Size(115, 23);
            label4.TabIndex = 13;
            label4.Text = "元のファイル名";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // outputTbPattern
            // 
            outputTbPattern.Font = new Font("メイリオ", 11.25F);
            outputTbPattern.Location = new Point(16, 148);
            outputTbPattern.Name = "outputTbPattern";
            outputTbPattern.Size = new Size(100, 30);
            outputTbPattern.TabIndex = 10;
            outputTbPattern.Text = "sml_";
            outputTbPattern.TextAlign = HorizontalAlignment.Center;
            outputTbPattern.Validating += outputTbPattern_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("メイリオ", 11.25F);
            label2.Location = new Point(6, 111);
            label2.Name = "label2";
            label2.Size = new Size(235, 23);
            label2.TabIndex = 9;
            label2.Text = "縮小後の画像ファイル名パターン";
            // 
            // outputRbSelectedFolder
            // 
            outputRbSelectedFolder.AutoSize = true;
            outputRbSelectedFolder.Font = new Font("メイリオ", 11.25F);
            outputRbSelectedFolder.Location = new Point(211, 31);
            outputRbSelectedFolder.Name = "outputRbSelectedFolder";
            outputRbSelectedFolder.Size = new Size(133, 27);
            outputRbSelectedFolder.TabIndex = 8;
            outputRbSelectedFolder.Tag = "任意フォルダ";
            outputRbSelectedFolder.Text = "任意のフォルダ";
            outputRbSelectedFolder.UseVisualStyleBackColor = true;
            outputRbSelectedFolder.CheckedChanged += radioOutput_CheckedChanged;
            // 
            // outputRbImageFolder
            // 
            outputRbImageFolder.AutoSize = true;
            outputRbImageFolder.Checked = true;
            outputRbImageFolder.Font = new Font("メイリオ", 11.25F);
            outputRbImageFolder.Location = new Point(12, 31);
            outputRbImageFolder.Name = "outputRbImageFolder";
            outputRbImageFolder.Size = new Size(193, 27);
            outputRbImageFolder.TabIndex = 7;
            outputRbImageFolder.TabStop = true;
            outputRbImageFolder.Tag = "同じフォルダ";
            outputRbImageFolder.Text = "元の画像と同じフォルダ";
            outputRbImageFolder.UseVisualStyleBackColor = true;
            outputRbImageFolder.CheckedChanged += radioOutput_CheckedChanged;
            // 
            // btnOutFolderSelect
            // 
            btnOutFolderSelect.Enabled = false;
            btnOutFolderSelect.Font = new Font("メイリオ", 11.25F);
            btnOutFolderSelect.Location = new Point(640, 61);
            btnOutFolderSelect.Name = "btnOutFolderSelect";
            btnOutFolderSelect.Size = new Size(99, 31);
            btnOutFolderSelect.TabIndex = 6;
            btnOutFolderSelect.Text = "選択";
            btnOutFolderSelect.UseVisualStyleBackColor = true;
            btnOutFolderSelect.Click += btnOutFolderSelect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("メイリオ", 11.25F);
            label3.Location = new Point(5, 5);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 5;
            label3.Text = "出力先";
            // 
            // outputTbFolderName
            // 
            outputTbFolderName.Enabled = false;
            outputTbFolderName.Font = new Font("メイリオ", 11.25F);
            outputTbFolderName.Location = new Point(512, 62);
            outputTbFolderName.Name = "outputTbFolderName";
            outputTbFolderName.Size = new Size(122, 30);
            outputTbFolderName.TabIndex = 3;
            outputTbFolderName.Validating += outputTbFolderName_Validating;
            // 
            // tabSetting
            // 
            tabSetting.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabSetting.Controls.Add(tpPerSetting);
            tabSetting.Controls.Add(tabPage1);
            tabSetting.Location = new Point(10, 135);
            tabSetting.Name = "tabSetting";
            tabSetting.SelectedIndex = 0;
            tabSetting.Size = new Size(747, 135);
            tabSetting.TabIndex = 4;
            // 
            // tpPerSetting
            // 
            tpPerSetting.Controls.Add(ratio_ApplyTypeSelector);
            tpPerSetting.Controls.Add(label6);
            tpPerSetting.Controls.Add(label11);
            tpPerSetting.Controls.Add(label12);
            tpPerSetting.Controls.Add(ratio_SettingBtn);
            tpPerSetting.Controls.Add(label13);
            tpPerSetting.Controls.Add(ratio_Height);
            tpPerSetting.Controls.Add(ratio_Width);
            tpPerSetting.Font = new Font("メイリオ", 11.25F);
            tpPerSetting.Location = new Point(4, 24);
            tpPerSetting.Name = "tpPerSetting";
            tpPerSetting.Padding = new Padding(3);
            tpPerSetting.Size = new Size(739, 107);
            tpPerSetting.TabIndex = 1;
            tpPerSetting.Text = "割合で指定";
            tpPerSetting.UseVisualStyleBackColor = true;
            // 
            // ratio_ApplyTypeSelector
            // 
            ratio_ApplyTypeSelector.Location = new Point(452, 23);
            ratio_ApplyTypeSelector.Name = "ratio_ApplyTypeSelector";
            ratio_ApplyTypeSelector.Size = new Size(281, 34);
            ratio_ApplyTypeSelector.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(409, 29);
            label6.Name = "label6";
            label6.Size = new Size(32, 28);
            label6.TabIndex = 37;
            label6.Text = "%";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label11.Location = new Point(187, 29);
            label11.Name = "label11";
            label11.Size = new Size(32, 28);
            label11.TabIndex = 36;
            label11.Text = "%";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label12.Location = new Point(228, 29);
            label12.Name = "label12";
            label12.Size = new Size(69, 28);
            label12.TabIndex = 35;
            label12.Text = "たて幅";
            // 
            // ratio_SettingBtn
            // 
            ratio_SettingBtn.BackColor = Color.CornflowerBlue;
            ratio_SettingBtn.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ratio_SettingBtn.ForeColor = SystemColors.ButtonHighlight;
            ratio_SettingBtn.Location = new Point(558, 63);
            ratio_SettingBtn.Name = "ratio_SettingBtn";
            ratio_SettingBtn.Size = new Size(175, 41);
            ratio_SettingBtn.TabIndex = 4;
            ratio_SettingBtn.Text = "設定する";
            ratio_SettingBtn.UseVisualStyleBackColor = false;
            ratio_SettingBtn.Click += btnRaitoSetting_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label13.Location = new Point(6, 29);
            label13.Name = "label13";
            label13.Size = new Size(69, 28);
            label13.TabIndex = 34;
            label13.Text = "よこ幅";
            // 
            // ratio_Height
            // 
            ratio_Height.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ratio_Height.Location = new Point(303, 21);
            ratio_Height.Name = "ratio_Height";
            ratio_Height.Size = new Size(100, 36);
            ratio_Height.TabIndex = 33;
            ratio_Height.Text = "70";
            ratio_Height.TextAlign = HorizontalAlignment.Center;
            ratio_Height.Validating += ratio_Height_Validating;
            // 
            // ratio_Width
            // 
            ratio_Width.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ratio_Width.Location = new Point(81, 21);
            ratio_Width.Name = "ratio_Width";
            ratio_Width.Size = new Size(100, 36);
            ratio_Width.TabIndex = 32;
            ratio_Width.Text = "70";
            ratio_Width.TextAlign = HorizontalAlignment.Center;
            ratio_Width.Validating += ratio_Width_Validating;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pixel_ApplyTypeSelector);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(pixel_lHeight);
            tabPage1.Controls.Add(pixel_lWidth);
            tabPage1.Controls.Add(pixel_SettingBtn);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(739, 107);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "ピクセルで指定";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pixel_ApplyTypeSelector
            // 
            pixel_ApplyTypeSelector.Location = new Point(452, 23);
            pixel_ApplyTypeSelector.Name = "pixel_ApplyTypeSelector";
            pixel_ApplyTypeSelector.Size = new Size(281, 34);
            pixel_ApplyTypeSelector.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.Location = new Point(409, 29);
            label10.Name = "label10";
            label10.Size = new Size(35, 28);
            label10.TabIndex = 29;
            label10.Text = "px";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label9.Location = new Point(187, 29);
            label9.Name = "label9";
            label9.Size = new Size(35, 28);
            label9.TabIndex = 28;
            label9.Text = "px";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label8.Location = new Point(228, 29);
            label8.Name = "label8";
            label8.Size = new Size(69, 28);
            label8.TabIndex = 27;
            label8.Text = "たて幅";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(6, 29);
            label7.Name = "label7";
            label7.Size = new Size(69, 28);
            label7.TabIndex = 26;
            label7.Text = "よこ幅";
            // 
            // pixel_lHeight
            // 
            pixel_lHeight.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            pixel_lHeight.Location = new Point(303, 21);
            pixel_lHeight.Name = "pixel_lHeight";
            pixel_lHeight.Size = new Size(100, 36);
            pixel_lHeight.TabIndex = 25;
            pixel_lHeight.Text = "100";
            pixel_lHeight.TextAlign = HorizontalAlignment.Center;
            pixel_lHeight.Validating += pixel_Height_Validating;
            // 
            // pixel_lWidth
            // 
            pixel_lWidth.Font = new Font("メイリオ", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            pixel_lWidth.Location = new Point(81, 21);
            pixel_lWidth.Name = "pixel_lWidth";
            pixel_lWidth.Size = new Size(100, 36);
            pixel_lWidth.TabIndex = 24;
            pixel_lWidth.Text = "100";
            pixel_lWidth.TextAlign = HorizontalAlignment.Center;
            pixel_lWidth.Validating += pixel_Width_Validating;
            // 
            // pixel_SettingBtn
            // 
            pixel_SettingBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pixel_SettingBtn.BackColor = Color.CornflowerBlue;
            pixel_SettingBtn.Font = new Font("メイリオ", 14.25F);
            pixel_SettingBtn.ForeColor = SystemColors.ButtonHighlight;
            pixel_SettingBtn.Location = new Point(558, 63);
            pixel_SettingBtn.Name = "pixel_SettingBtn";
            pixel_SettingBtn.Size = new Size(175, 41);
            pixel_SettingBtn.TabIndex = 23;
            pixel_SettingBtn.Text = "設定する";
            pixel_SettingBtn.UseVisualStyleBackColor = false;
            pixel_SettingBtn.Click += btnPixelSetting_Click;
            // 
            // btnOutput
            // 
            btnOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOutput.BackColor = Color.LimeGreen;
            btnOutput.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnOutput.ForeColor = SystemColors.ButtonHighlight;
            btnOutput.Location = new Point(568, 183);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(175, 41);
            btnOutput.TabIndex = 28;
            btnOutput.Text = "出力開始";
            btnOutput.UseVisualStyleBackColor = false;
            btnOutput.Click += btnOutput_Click;
            // 
            // plFileSetting
            // 
            plFileSetting.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plFileSetting.BackColor = Color.White;
            plFileSetting.Controls.Add(output_ApplyTypeSelector);
            plFileSetting.Controls.Add(versionLabel);
            plFileSetting.Controls.Add(webSiteIcon);
            plFileSetting.Controls.Add(lblFolderPath);
            plFileSetting.Controls.Add(btnOutput);
            plFileSetting.Controls.Add(outputLbFolderPath);
            plFileSetting.Controls.Add(outputCbExtention);
            plFileSetting.Controls.Add(label4);
            plFileSetting.Controls.Add(btnOutFolderSelect);
            plFileSetting.Controls.Add(label3);
            plFileSetting.Controls.Add(outputRbImageFolder);
            plFileSetting.Controls.Add(outputTbFolderName);
            plFileSetting.Controls.Add(label2);
            plFileSetting.Controls.Add(outputTbPattern);
            plFileSetting.Controls.Add(outputRbSelectedFolder);
            plFileSetting.Location = new Point(10, 585);
            plFileSetting.Name = "plFileSetting";
            plFileSetting.Size = new Size(747, 229);
            plFileSetting.TabIndex = 15;
            // 
            // output_ApplyTypeSelector
            // 
            output_ApplyTypeSelector.Location = new Point(462, 144);
            output_ApplyTypeSelector.Name = "output_ApplyTypeSelector";
            output_ApplyTypeSelector.Size = new Size(281, 34);
            output_ApplyTypeSelector.TabIndex = 37;
            // 
            // versionLabel
            // 
            versionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            versionLabel.Location = new Point(187, 209);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(71, 15);
            versionLabel.TabIndex = 32;
            versionLabel.Text = "99.99.99.99";
            versionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // webSiteIcon
            // 
            webSiteIcon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            webSiteIcon.Cursor = Cursors.Hand;
            webSiteIcon.Image = ImageResizeSoft.Properties.Resources.blogimage;
            webSiteIcon.Location = new Point(6, 202);
            webSiteIcon.Name = "webSiteIcon";
            webSiteIcon.Size = new Size(175, 24);
            webSiteIcon.SizeMode = PictureBoxSizeMode.Zoom;
            webSiteIcon.TabIndex = 31;
            webSiteIcon.TabStop = false;
            webSiteIcon.Click += webSiteIcon_Click;
            // 
            // lblFolderPath
            // 
            lblFolderPath.BackColor = Color.WhiteSmoke;
            lblFolderPath.Font = new Font("メイリオ", 11.25F);
            lblFolderPath.Location = new Point(491, 61);
            lblFolderPath.Name = "lblFolderPath";
            lblFolderPath.Size = new Size(15, 31);
            lblFolderPath.TabIndex = 30;
            lblFolderPath.Text = "\\";
            lblFolderPath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputLbFolderPath
            // 
            outputLbFolderPath.BackColor = Color.WhiteSmoke;
            outputLbFolderPath.Font = new Font("メイリオ", 11.25F);
            outputLbFolderPath.Location = new Point(12, 61);
            outputLbFolderPath.Name = "outputLbFolderPath";
            outputLbFolderPath.Size = new Size(473, 31);
            outputLbFolderPath.TabIndex = 17;
            outputLbFolderPath.Text = "縮小後の画像ファイル名パターン";
            outputLbFolderPath.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ApplySettingLabel
            // 
            ApplySettingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ApplySettingLabel.Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ApplySettingLabel.ForeColor = Color.CornflowerBlue;
            ApplySettingLabel.ImageAlign = ContentAlignment.BottomCenter;
            ApplySettingLabel.Location = new Point(10, 271);
            ApplySettingLabel.Name = "ApplySettingLabel";
            ApplySettingLabel.Size = new Size(743, 26);
            ApplySettingLabel.TabIndex = 36;
            ApplySettingLabel.Text = "縮小する画像を選択してください。";
            ApplySettingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucImageSettingListdgv
            // 
            ucImageSettingListdgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucImageSettingListdgv.Location = new Point(10, 300);
            ucImageSettingListdgv.Name = "ucImageSettingListdgv";
            ucImageSettingListdgv.Size = new Size(747, 279);
            ucImageSettingListdgv.TabIndex = 37;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(766, 818);
            Controls.Add(ucImageSettingListdgv);
            Controls.Add(plFileSetting);
            Controls.Add(ApplySettingLabel);
            Controls.Add(tabSetting);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(782, 2994);
            MinimumSize = new Size(782, 708);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "シンプルに縮小";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            pnlDragAndDrop.ResumeLayout(false);
            pnlDragAndDrop.PerformLayout();
            tabSetting.ResumeLayout(false);
            tpPerSetting.ResumeLayout(false);
            tpPerSetting.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            plFileSetting.ResumeLayout(false);
            plFileSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webSiteIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabSetting;
        private TabPage tpPerSetting;
        private Panel pnlDragAndDrop;
        private Button btnOpenFolder;
        private Button btnOutFolderSelect;
        private Label label3;
        private TextBox outputTbFolderName;
        private TextBox outputTbPattern;
        private Label label2;
        private RadioButton outputRbSelectedFolder;
        private RadioButton outputRbImageFolder;
        private Label label4;
        private ComboBox outputCbExtention;
        private Button ratio_SettingBtn;
        private Button btnOutput;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox ratio_Height;
        private TextBox ratio_Width;
        private Panel plFileSetting;
        private Label label1;
        private TabPage tabPage1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox pixel_lHeight;
        private TextBox pixel_lWidth;
        private Button pixel_SettingBtn;
        private Label ApplySettingLabel;
        private Label outputLbFolderPath;
        private Label lblFolderPath;
        private PictureBox webSiteIcon;
        private Label versionLabel;
        private ImageResizeSoft.UC_ApplyTypeSelector ratio_ApplyTypeSelector;
        private ImageResizeSoft.UC_ApplyTypeSelector pixel_ApplyTypeSelector;
        private ImageResizeSoft.UC_ApplyTypeSelector output_ApplyTypeSelector;
        private ImageResizeSoft.UC_ImageSettingListDGV ucImageSettingListdgv;
    }
}
