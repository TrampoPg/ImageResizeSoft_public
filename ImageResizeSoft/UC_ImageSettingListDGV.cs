using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ImageCompressionSoft.FormMain;

namespace ImageResizeSoft
{
    public partial class UC_ImageSettingListDGV : UserControl
    {
        private bool allSelect = false;

        public UC_ImageSettingListDGV()
        {
            InitializeComponent();
        }


        internal bool IsEmptyDataGridView()
        {
            int count = this.dgvImageSettingView.Rows.Count;

            return count <= 0;
        }


        internal void ApplyRaitoSetting(bool isAll, decimal ratioWidth, decimal ratioHeight)
        {
            // 設定されている%数を取得
            decimal resizeWidthPer = ratioWidth;
            decimal resizeHeightPer = ratioHeight;

            foreach (DataGridViewRow row in this.dgvImageSettingView.Rows)
            {
                // チェック判定
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells[0];
                bool isChecked = (bool)checkBox.Value;
                if (!isAll && !isChecked)
                {
                    continue;
                }

                // 元画像のサイズを取得
                DataGridViewTextBoxCell widthCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.ORG_WIDTH];
                decimal orgWidth = decimal.Parse(widthCell.Value.ToString()!);
                DataGridViewTextBoxCell heightCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.ORG_HEIGHT];
                decimal orgHeight = decimal.Parse(heightCell.Value.ToString()!);

                // 新しいサイズを計算
                decimal resizeWidth = orgWidth * (resizeHeightPer / 100);
                decimal resizeHeight = orgHeight * (resizeWidthPer / 100);

                // リストにセット
                DataGridViewTextBoxCell resizeWidthCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.RESIZE_WIDTH];
                DataGridViewTextBoxCell resizeHeightCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.RESIZE_HEIGHT];
                resizeWidthCell.Value = (int)Math.Round(resizeWidth);
                resizeHeightCell.Value = (int)Math.Round(resizeHeight);


                DataGridViewTextBoxCell resizeSizeCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.RESIZE_SIZE];
                resizeSizeCell.Value = $"{resizeWidthCell.Value} x {resizeHeightCell.Value}";
            }
        }

        private void InitDataGridView()
        {
            // デザイン画面からでは設定できる項目が少なすぎるのでこちらでカラム定義する
            this.dgvImageSettingView.Columns.Clear();


            this.dgvImageSettingView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgvImageSettingView.CurrentCell = null;
            this.dgvImageSettingView.ClearSelection();
            this.dgvImageSettingView.DefaultCellStyle.Font = new Font("メイリオ", 20);
            this.dgvImageSettingView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvImageSettingView.RowTemplate.Height = 40;

            // フォント設定
            Padding chkBoxPadding = new Padding();
            chkBoxPadding.Left = 5;

            // チェックボックス列
            DataGridViewCheckBoxColumn checkBoxCol = new DataGridViewCheckBoxColumn();
            checkBoxCol.Name = "checkBoxColumn";
            checkBoxCol.HeaderText = "✅";
            checkBoxCol.Width = 30;
            checkBoxCol.ReadOnly = false;
            checkBoxCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            checkBoxCol.DefaultCellStyle.Padding = chkBoxPadding;
            checkBoxCol.DefaultCellStyle.BackColor = Color.White;
            checkBoxCol.DefaultCellStyle.SelectionBackColor = Color.White;
            checkBoxCol.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 画像アイコン表示列
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.MinimumWidth = 200;
            imageCol.ReadOnly = true;
            imageCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            imageCol.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            imageCol.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            imageCol.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 元画像サイズ表示列
            DataGridViewTextBoxColumn orgSizeTextCol = new DataGridViewTextBoxColumn();
            orgSizeTextCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orgSizeTextCol.HeaderText = "元のサイズ(縦px x 縦px)";
            orgSizeTextCol.ReadOnly = true;
            orgSizeTextCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            orgSizeTextCol.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            orgSizeTextCol.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            orgSizeTextCol.DefaultCellStyle.SelectionForeColor = Color.Black;

            // リサイズサイズ表示列
            DataGridViewTextBoxColumn resizeTextCol = new DataGridViewTextBoxColumn();
            resizeTextCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resizeTextCol.MinimumWidth = 150;
            resizeTextCol.HeaderText = "変更後サイズ(縦px x 縦px)";
            resizeTextCol.ReadOnly = true;
            resizeTextCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            resizeTextCol.DefaultCellStyle.BackColor = Color.AliceBlue;
            resizeTextCol.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            resizeTextCol.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 画像path（非表示）
            DataGridViewTextBoxColumn imagePathCol = new DataGridViewTextBoxColumn();
            imagePathCol.Visible = false;

            // 元の横px（非表示）
            DataGridViewTextBoxColumn orgWidthCol = new DataGridViewTextBoxColumn();
            orgWidthCol.Visible = false;

            // 元の縦px（非表示）
            DataGridViewTextBoxColumn orgHeightCol = new DataGridViewTextBoxColumn();
            orgHeightCol.Visible = false;

            // リサイズ後よこ幅列（非表示）
            DataGridViewTextBoxColumn resizeWidthCol = new DataGridViewTextBoxColumn();
            resizeWidthCol.Visible = false;


            // リサイズ後たて幅列（非表示）
            DataGridViewTextBoxColumn resizeHeightCol = new DataGridViewTextBoxColumn();
            resizeHeightCol.Visible = false;

            // 列を追加
            this.dgvImageSettingView.Columns.AddRange(new DataGridViewColumn[]{
                checkBoxCol
                ,imageCol
                ,orgSizeTextCol
                ,resizeTextCol
                ,imagePathCol
                ,orgWidthCol
                ,orgHeightCol
                ,resizeWidthCol
                ,resizeHeightCol
            });
        }

        internal void ApplyPixelSetting(bool isAll, int pixelWidth, int pixelHeight)
        {
            if (IsEmptyDataGridView())
            {
                return;
            }

            // 設定されているピクセルを取得
            int resizeWidthPx = pixelWidth;
            int resizeHeightPx = pixelHeight;

            foreach (DataGridViewRow row in this.dgvImageSettingView.Rows)
            {
                // チェック判定
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells[0];
                bool isChecked = (bool)checkBox.Value;
                if (!isAll && !isChecked)
                {
                    continue;
                }

                // 画像の元サイズを取得
                DataGridViewTextBoxCell widthCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.ORG_WIDTH];
                int orgWidth = (int)widthCell.Value;
                DataGridViewTextBoxCell heightCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.ORG_HEIGHT];
                int orgHeight = (int)heightCell.Value;

                // リストに新しいサイズをセット
                DataGridViewTextBoxCell resizeWidthCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.RESIZE_WIDTH];
                DataGridViewTextBoxCell resizeHeightCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.RESIZE_HEIGHT];
                resizeWidthCell.Value = resizeWidthPx;
                resizeHeightCell.Value = resizeHeightPx;


                DataGridViewTextBoxCell resizeSizeCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.RESIZE_SIZE];
                resizeSizeCell.Value = $"{resizeWidthCell.Value} x {resizeHeightCell.Value}";
            }
        }


        /// <summary>
        /// データグリッドViewを再作成
        /// </summary>
        /// <param name="imagePaths"></param>
        internal void RefleshView(string[] imagePaths)
        {
            // クリア
            this.dgvImageSettingView.Rows.Clear();

            // 読み込み用ウィンドウ
            ProgressDialogForm pdForm = new ProgressDialogForm(Consts.FormText.GAZOU_YOMIKOMI); ;
            pdForm.SetProgressMax(imagePaths.Count());
            pdForm.Show();
            pdForm.SetProcessName(Consts.FormText.GAZOU_YOMIKOMI);

            List<string> errImgNameList = new List<string>();

            foreach (var imagePath in imagePaths)
            {
                // 画像ファイルを扱うため例外対策をとる
                try
                {
                    // ダイアログに表示する
                    pdForm.SetItemName(Path.GetFileName(imagePath));

                    // チェックボックス
                    DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                    checkBoxCell.Value = true;

                    // 画像アイコン
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read); // 画像ファイルを開く(読み取り専用)
                    Bitmap bmp = new Bitmap(fs);
                    imageCell.Value = bmp;
                    fs.Close();

                    // 元サイズ表示
                    string sizeText = $"{bmp.Width} x {bmp.Height}";
                    DataGridViewTextBoxCell originalSizeTextCell = new DataGridViewTextBoxCell();
                    originalSizeTextCell.Value = sizeText;
                    originalSizeTextCell.Style.BackColor = Color.WhiteSmoke;

                    // リサイズ後の横サイズ
                    DataGridViewTextBoxCell resizedSIzeTextCell = new DataGridViewTextBoxCell();
                    resizedSIzeTextCell.Value = sizeText;

                    // 画像Path（非表示）
                    DataGridViewTextBoxCell imagePathCell = new DataGridViewTextBoxCell();
                    imagePathCell.Value = imagePath;

                    // 元画像横幅（非表示）
                    DataGridViewTextBoxCell originalWidthCell = new DataGridViewTextBoxCell();
                    originalWidthCell.Value = bmp.Width;

                    // 元画縦幅（非表示）
                    DataGridViewTextBoxCell originalHeightCell = new DataGridViewTextBoxCell();
                    originalHeightCell.Value = bmp.Height;

                    // リサイズ後の横サイズ（非表示）
                    DataGridViewTextBoxCell resizedWidthCell = new DataGridViewTextBoxCell();
                    resizedWidthCell.Value = bmp.Width;

                    // リサイズ後の横サイズ（非表示）
                    DataGridViewTextBoxCell resizedHeightCell = new DataGridViewTextBoxCell();
                    resizedHeightCell.Value = bmp.Height;

                    DataGridViewRow row = new DataGridViewRow();
                    row.Height = 40;
                    row.Cells.AddRange(new DataGridViewCell[] {
                        checkBoxCell
                        , imageCell
                        , originalSizeTextCell
                        , resizedSIzeTextCell
                        , imagePathCell
                        , originalWidthCell
                        , originalHeightCell
                        , resizedWidthCell
                        , resizedHeightCell
                    });

                    this.dgvImageSettingView.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    // エラーが発生したファイル名を保持しておく
                    string fileName = Path.GetFileName(imagePath);
                    errImgNameList.Add(fileName);
                    continue;
                }
                finally
                {
                    pdForm.IncrementProgressValue();
                }
            }

            pdForm.Dispose();

            // 画像ファイルの扱いで例外発生時はウィンドウで知らせる
            if (errImgNameList.Count() > 0)
            {
                string msg = "以下のファイルは対応していないため、取り込めませんでした。\r\n　" + string.Join("\r\n　", errImgNameList);
                MessageBox.Show(msg, "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        internal int GetDgvRowCount()
        {
            return this.dgvImageSettingView.Rows.Count;
        }

        internal DataGridViewRowCollection GetGgvRow()
        {
            return this.dgvImageSettingView.Rows;
        }

        internal DataGridViewRow GetGgvFirstRow()
        {
            return this.dgvImageSettingView.Rows[0];
        }

        private void dgvImageSettingView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ヘッダーの✅カラムが押されたら
            if (e.ColumnIndex == 0)
            {
                this.dgvImageSettingView.CurrentCell = null;
                foreach (DataGridViewRow row in this.dgvImageSettingView.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells[0];
                    checkBox.Value = allSelect;
                }
                this.allSelect = !allSelect;
            }
        }

        private void UC_ImageSettingListDGV_Load(object sender, EventArgs e)
        {
            this.InitDataGridView();
        }
    }

}
