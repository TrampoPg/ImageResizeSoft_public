namespace ImageResizeSoft
{
    partial class UC_ApplyTypeSelector
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            radioIsAll = new RadioButton();
            radioIsChecked = new RadioButton();
            SuspendLayout();
            // 
            // radioIsAll
            // 
            radioIsAll.AutoSize = true;
            radioIsAll.Checked = true;
            radioIsAll.Font = new Font("メイリオ", 11.25F);
            radioIsAll.Location = new Point(157, 3);
            radioIsAll.Name = "radioIsAll";
            radioIsAll.Size = new Size(118, 27);
            radioIsAll.TabIndex = 26;
            radioIsAll.TabStop = true;
            radioIsAll.Text = "すべての画像";
            radioIsAll.UseVisualStyleBackColor = true;
            // 
            // radioIsChecked
            // 
            radioIsChecked.AutoSize = true;
            radioIsChecked.Font = new Font("メイリオ", 11.25F);
            radioIsChecked.Location = new Point(3, 3);
            radioIsChecked.Name = "radioIsChecked";
            radioIsChecked.Size = new Size(148, 27);
            radioIsChecked.TabIndex = 25;
            radioIsChecked.Text = "チェックした画像";
            radioIsChecked.UseVisualStyleBackColor = true;
            // 
            // UC_ApplyTypeSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radioIsAll);
            Controls.Add(radioIsChecked);
            Name = "UC_ApplyTypeSelector";
            Size = new Size(281, 34);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioIsAll;
        private RadioButton radioIsChecked;
    }
}
