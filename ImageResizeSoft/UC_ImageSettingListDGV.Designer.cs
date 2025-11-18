namespace ImageResizeSoft
{
    partial class UC_ImageSettingListDGV
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvImageSettingView = new DataGridView();
            colCheck = new DataGridViewCheckBoxColumn();
            colImgIcon = new DataGridViewImageColumn();
            colOrgSize = new DataGridViewTextBoxColumn();
            colResizeWidth = new DataGridViewTextBoxColumn();
            colResizeHeight = new DataGridViewTextBoxColumn();
            ColEditBtn = new DataGridViewButtonColumn();
            colImgPath = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvImageSettingView).BeginInit();
            SuspendLayout();
            // 
            // dgvImageSettingView
            // 
            dgvImageSettingView.AllowUserToAddRows = false;
            dgvImageSettingView.AllowUserToDeleteRows = false;
            dgvImageSettingView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvImageSettingView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvImageSettingView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImageSettingView.Columns.AddRange(new DataGridViewColumn[] { colCheck, colImgIcon, colOrgSize, colResizeWidth, colResizeHeight, ColEditBtn, colImgPath });
            dgvImageSettingView.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvImageSettingView.Location = new Point(0, 0);
            dgvImageSettingView.MultiSelect = false;
            dgvImageSettingView.Name = "dgvImageSettingView";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvImageSettingView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvImageSettingView.RowHeadersVisible = false;
            dgvImageSettingView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvImageSettingView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvImageSettingView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImageSettingView.Size = new Size(747, 279);
            dgvImageSettingView.TabIndex = 6;
            // 
            // colCheck
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.Padding = new Padding(5, 0, 0, 0);
            colCheck.DefaultCellStyle = dataGridViewCellStyle2;
            colCheck.FillWeight = 30F;
            colCheck.HeaderText = "✅";
            colCheck.MinimumWidth = 8;
            colCheck.Name = "colCheck";
            colCheck.Width = 30;
            // 
            // colImgIcon
            // 
            colImgIcon.FillWeight = 150F;
            colImgIcon.HeaderText = "";
            colImgIcon.MinimumWidth = 8;
            colImgIcon.Name = "colImgIcon";
            colImgIcon.Width = 150;
            // 
            // colOrgSize
            // 
            colOrgSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colOrgSize.FillWeight = 200F;
            colOrgSize.HeaderText = "元のサイズ";
            colOrgSize.MinimumWidth = 8;
            colOrgSize.Name = "colOrgSize";
            // 
            // colResizeWidth
            // 
            colResizeWidth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colResizeWidth.FillWeight = 150F;
            colResizeWidth.HeaderText = "変更後の横幅";
            colResizeWidth.MinimumWidth = 8;
            colResizeWidth.Name = "colResizeWidth";
            colResizeWidth.ReadOnly = true;
            // 
            // colResizeHeight
            // 
            colResizeHeight.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colResizeHeight.FillWeight = 150F;
            colResizeHeight.HeaderText = "変更後の立幅";
            colResizeHeight.MinimumWidth = 8;
            colResizeHeight.Name = "colResizeHeight";
            colResizeHeight.ReadOnly = true;
            // 
            // ColEditBtn
            // 
            ColEditBtn.HeaderText = "";
            ColEditBtn.MinimumWidth = 8;
            ColEditBtn.Name = "ColEditBtn";
            ColEditBtn.Width = 150;
            // 
            // colImgPath
            // 
            colImgPath.HeaderText = "";
            colImgPath.MinimumWidth = 8;
            colImgPath.Name = "colImgPath";
            colImgPath.Visible = false;
            colImgPath.Width = 150;
            // 
            // UC_ImageSettingListDGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvImageSettingView);
            Name = "UC_ImageSettingListDGV";
            Size = new Size(747, 279);
            Load += UC_ImageSettingListDGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImageSettingView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvImageSettingView;
        private DataGridViewCheckBoxColumn colCheck;
        private DataGridViewImageColumn colImgIcon;
        private DataGridViewTextBoxColumn colOrgSize;
        private DataGridViewTextBoxColumn colResizeWidth;
        private DataGridViewTextBoxColumn colResizeHeight;
        private DataGridViewButtonColumn ColEditBtn;
        private DataGridViewTextBoxColumn colImgPath;
    }
}
