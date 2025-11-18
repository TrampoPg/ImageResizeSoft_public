namespace ImageResizeSoft
{
    partial class ProgressDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar = new ProgressBar();
            processNameLabel = new Label();
            itemLabel = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 51);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(310, 23);
            progressBar.TabIndex = 0;
            // 
            // processNameLabel
            // 
            processNameLabel.Location = new Point(12, 135);
            processNameLabel.Name = "processNameLabel";
            processNameLabel.Size = new Size(310, 24);
            processNameLabel.TabIndex = 1;
            processNameLabel.Text = "処理名";
            processNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // itemLabel
            // 
            itemLabel.Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            itemLabel.Location = new Point(12, 159);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(310, 29);
            itemLabel.TabIndex = 2;
            itemLabel.Text = "アイテム名";
            itemLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProgressDialogForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(334, 211);
            ControlBox = false;
            Controls.Add(itemLabel);
            Controls.Add(processNameLabel);
            Controls.Add(progressBar);
            Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProgressDialogForm";
            Text = "処理名";
            Load += ProgressDialogForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar;
        private Label processNameLabel;
        private Label itemLabel;
    }
}