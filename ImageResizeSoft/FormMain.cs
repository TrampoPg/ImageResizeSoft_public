using ImageResizeSoft;
using ImageResizeSoft.Properties;
using System.Diagnostics;
using System.Reflection;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace ImageCompressionSoft
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public enum DGV_COLUMN
        {
            CHECKBOX = 0,
            IMAGEICON,
            ORG_SIZE,
            RESIZE_SIZE,
            IMAGE_PATH,
            ORG_WIDTH,
            ORG_HEIGHT,
            RESIZE_WIDTH,
            RESIZE_HEIGHT,
        }
        private bool isValidationError = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ////フォームの最大化ボタンの表示、非表示を切り替える
            this.outputRbImageFolder.Checked = true;
            this.versionLabel.Text = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;


            // 前回の画面の状態を復元（設定部）
            this.tabSetting.SelectedIndex = FormStateConfig.Setting.TabIndex;
            this.ratio_Width.Text = FormStateConfig.Setting.Ratio.Width.ToString();
            this.ratio_Height.Text = FormStateConfig.Setting.Ratio.Height.ToString();
            this.ratio_ApplyTypeSelector.Init(FormStateConfig.Setting.Ratio.IsAll);
            this.pixel_lWidth.Text = FormStateConfig.Setting.Pixel.Width.ToString();
            this.pixel_lHeight.Text = FormStateConfig.Setting.Pixel.Height.ToString();
            this.pixel_ApplyTypeSelector.Init(FormStateConfig.Setting.Pixel.IsAll);

            // 前回の画面の状態を復元（出力先部）
            List<string> items = new List<string>();
            items.Add(".元画像と同じ形式");
            items.AddRange(Consts.FileFilter.IMAGE_EXTENSIONS);
            this.outputCbExtention.Items.AddRange(items.ToArray());
            int index = items.IndexOf(FormStateConfig.Output.Extention);
            this.outputCbExtention.SelectedIndex = index < 0 ? 0 : index;
            this.outputLbFolderPath.Text = FormStateConfig.Output.SelectedFolderPath;
            this.outputRbSelectedFolder.Checked = FormStateConfig.Output.IsSelectedFolder;
            this.outputRbImageFolder.Checked = FormStateConfig.Output.IsImageFolder;
            this.outputTbFolderName.Text = FormStateConfig.Output.MakeFolderName;

            // 出力先設定の活性非活性状態を設定
            SwitchControllsEnabledOutputSettingArea();
        }

        /// <summary>
        /// 画面の状態を次回表示用にプロパティへ保存
        /// </summary>
        private void FormStateSave()
        {
            // 設定の項目
            FormStateConfig.Setting.TabIndex = this.tabSetting.SelectedIndex;
            FormStateConfig.Setting.Ratio.Width = int.Parse(this.ratio_Width.Text);
            FormStateConfig.Setting.Ratio.Height = int.Parse(this.ratio_Height.Text);
            FormStateConfig.Setting.Ratio.IsAll = this.ratio_ApplyTypeSelector.IsAll();
            FormStateConfig.Setting.Pixel.Width = int.Parse(this.pixel_lWidth.Text);
            FormStateConfig.Setting.Pixel.Height = int.Parse(this.pixel_lHeight.Text);
            FormStateConfig.Setting.Pixel.IsAll = this.pixel_ApplyTypeSelector.IsAll();

            // 出力の項目
            FormStateConfig.Output.Extention = this.outputCbExtention.SelectedItem!.ToString()!;
            FormStateConfig.Output.SelectedFolderPath = this.outputLbFolderPath.Text;
            FormStateConfig.Output.IsSelectedFolder = this.outputRbSelectedFolder.Checked;
            FormStateConfig.Output.IsImageFolder = this.outputRbImageFolder.Checked;
            FormStateConfig.Output.MakeFolderName = this.outputTbFolderName.Text;

            FormStateConfig.Save();
        }

        private void ApplySizeSettingForOpenTab()
        {
            // 現在開いているタブによって設定の種類を変化
            switch ((Consts.FormConfig.SettingTab)this.tabSetting.SelectedIndex)
            {
                case Consts.FormConfig.SettingTab.RATIO_TAB: // 割合
                    // 設定情報をDataGridViewの変更後サイズ保持用セルに保存
                    ApplyRaitoSetting(true);
                    break;
                case Consts.FormConfig.SettingTab.PIXEL_TAB: // ピクセル数
                    // 設定情報をDataGridViewの変更後サイズ保持用セルに保存
                    ApplyPixelSetting(true);
                    break;
                default:
                    break;
            }
        }

        private void ApplyRaitoSetting(bool isAll)
        {
            if (this.ucImageSettingListdgv.IsEmptyDataGridView())
            {
                return;
            }

            // 設定されている%数を取得
            decimal resizeWidthPer = decimal.Parse(this.ratio_Width.Text);
            decimal resizeHeightPer = decimal.Parse(this.ratio_Height.Text);

            // 設定をGridViewに記録
            this.ucImageSettingListdgv.ApplyRaitoSetting(isAll, resizeWidthPer, resizeHeightPer);
            this.SetApplyInfomation(isAll, true, decimal.ToInt32(resizeWidthPer), decimal.ToInt32(resizeHeightPer));
        }

        private void ApplyPixelSetting(bool isAll)
        {
            if (this.ucImageSettingListdgv.IsEmptyDataGridView())
            {
                return;
            }

            // 設定されているピクセルを取得
            int resizeWidthPx = Int32.Parse(this.pixel_lWidth.Text);
            int resizeHeightPx = Int32.Parse(this.pixel_lHeight.Text);


            // ここに挿入
            this.ucImageSettingListdgv.ApplyPixelSetting(isAll,resizeWidthPx,resizeHeightPx);
            this.SetApplyInfomation(isAll, false, resizeWidthPx, resizeHeightPx);

        }

        /// <summary>
        /// 現在設定中の内容を更新
        /// </summary>
        /// <param name="isAll"></param>
        /// <param name="isRatio"></param>
        /// <param name="width"></param>
        /// <param name="Height"></param>
        private void SetApplyInfomation(bool isAll, bool isRatio, int width, int Height)
        {
            string applyType = isAll ? "すべての" : "チェックした";
            string type = isRatio ? "%" : "px";
            string format = $"{applyType}画像に よこ幅 {width}{type} たて幅 {Height}{type}  の設定を適用しました。";

            this.ApplySettingLabel.Text = format;
        }


        /// <summary>
        /// 拡張子の選択コンボボックスから指定されている文字列を取得
        /// </summary>
        /// <param name="oldExtention"></param>
        /// <returns></returns>
        private string GetResizedExtention(string oldExtention)
        {
            // 最初のアイテム指定時は「元の拡張子」
            if (this.outputCbExtention.SelectedIndex == 0)
            {
                return oldExtention;
            }

            string selectedExt = this.outputCbExtention.SelectedItem!.ToString()!;
            return selectedExt;
        }

        /// <summary>
        /// 出力先設定のラジオボタンでコントロールの活性、非活性を切り替え
        /// </summary>
        private void SwitchControllsEnabledOutputSettingArea()
        {
            // 画像と"同じフォルダ
            if (this.outputRbImageFolder.Checked)
            {
                this.outputTbFolderName.Enabled = false;
                this.btnOutFolderSelect.Enabled = false;
                this.outputLbFolderPath.Enabled = false;
                this.lblFolderPath.Enabled = false;
            }
            // 任意のフォルダ
            else if (this.outputRbSelectedFolder.Checked)
            {
                this.outputTbFolderName.Enabled = true;
                this.btnOutFolderSelect.Enabled = true;
                this.outputLbFolderPath.Enabled = true;
                this.lblFolderPath.Enabled = true;
            }
        }

        //////////////////////////////////////////
        ///ここからイベントハンドラ
        //////////////////////////////////////////

        /// <summary>
        /// 「フォルダから選択」ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            // ファイル選択ウィンドウを設定
            OpenFileDialog dialogWindow = new OpenFileDialog();
            dialogWindow.Filter = Consts.FileFilter.IMAGE_FILTER_TEXT;
            dialogWindow.Title = Consts.FormText.FILE_INPUT_DIALOG_TITLE;
            dialogWindow.RestoreDirectory = true;
            dialogWindow.Multiselect = true;

            // ファイル選択ウィンドウで「OK」が押されたら
            if (dialogWindow.ShowDialog() == DialogResult.OK)
            {
                string[] imgPathes = dialogWindow.FileNames;
                this.ucImageSettingListdgv.RefleshView(imgPathes);

                // 現在開いている設定タブの設定内容を適用
                ApplySizeSettingForOpenTab();

            }
        }

        /// <summary>
        /// 「ここに画像をドラッグ＆ドロップ」のスペースにファイルがドラッグ＆ドロップされた時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDragAndDrop_DragDrop(object sender, DragEventArgs e)
        {
            // ドロップされたファイル名を配列で取得
            string[] filePaths = (string[])e.Data!.GetData(DataFormats.FileDrop, false)!;

            if (filePaths.Count() <= 0)
            {
                // パスのリストが取得できない場合は処理しない
                return;
            }


            // 画像かそれ以外かをチェック
            List<string> targetPaths   = new List<string>(); // 画像のパス用
            List<string> notImagePaths = new List<string>(); // 画像ではないファイルパス用

            // 拡張子チェック
            foreach (string path in filePaths)
            {
                // 拡張子を取得
                string extention = Path.GetExtension(path).ToLower();
                if (Consts.FileFilter.IMAGE_EXTENSIONS.Contains(extention))
                {
                    // 画像の拡張子ならばリストに追加
                    targetPaths.Add(path);
                    continue;
                }

                // 画像ではない拡張子のパスも警告メッセージ用に保存
                notImagePaths.Add(path);
            }

            // データグリッドビューを更新
            this.ucImageSettingListdgv.RefleshView(targetPaths.ToArray());

            // 現在開いている設定タブの設定内容を適用
            ApplySizeSettingForOpenTab();

        }

        /// <summary>
        /// 「ここに画像をドラッグ＆ドロップ」のスペース内のカーソルの形を変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDragAndDrop_DragEnter(object sender, DragEventArgs e)
        {
            // コントロール内にドラッグされたときに実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        /// <summary>
        /// 「出力開始」ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutput_Click(object sender, EventArgs e)
        {
            // DataGridViewにデータがなければ処理をここで中断
            if (this.ucImageSettingListdgv.IsEmptyDataGridView())
            {
                return;
            }

            // すべての画像を出力する？
            bool isAll = this.output_ApplyTypeSelector.IsAll();

            // エラーファイル名通知用
            List<string> errImgNameList = new List<string>();

            string outPutDirectoryPath = "";

            // 「任意のフォルダに出力」を選択されている場合
            if (this.outputRbSelectedFolder.Checked)
            {
                // 指定されたフォルダのパスを作成して保持
                outPutDirectoryPath = this.outputLbFolderPath.Text + @"\" + this.outputTbFolderName.Text;
            }
            // 「元の画像と同じフォルダに出力」を選択されている場合
            else
            {
                // 選択した画像と同じフォルダに出力する場合（1行目の画像と同じフォルダに出力）
                DataGridViewRow row = this.ucImageSettingListdgv.GetGgvFirstRow();
                DataGridViewTextBoxCell pathCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.IMAGE_PATH];
                string directoryPath = Path.GetDirectoryName(pathCell.Value.ToString()); // ファイルパスからフォルダパスを取得

                // 出力先のフォルダを作成して保持
                outPutDirectoryPath = directoryPath + @"\" + this.outputTbFolderName.Text;
            }

            // 出力先フォルダ内にファイルがある場合はアラートを表示
            bool isNotEmptyDirectory = Directory.Exists(outPutDirectoryPath) && Directory.EnumerateFiles(outPutDirectoryPath).Any();
            if (isNotEmptyDirectory)
            {
                DialogResult dialogResult = MessageBox.Show(Consts.Message.IS_EXIST_FILE, "お知らせ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult != DialogResult.OK)
                {
                    // 「いいえ」選択時は処理をここで中断
                    return;
                }
            }

            // フォルダがなければ作成し、あれば何もしない
            Directory.CreateDirectory(outPutDirectoryPath);


            // 進捗報告用ダイアログを準備
            ProgressDialogForm progressDialog = new ProgressDialogForm(Consts.FormText.GAZOU_RESIZE);
            progressDialog.Show();
            progressDialog.SetProgressMax(this.ucImageSettingListdgv.GetDgvRowCount());

            // 出力処理
            foreach (DataGridViewRow row in this.ucImageSettingListdgv.GetGgvRow())
            {
                // チェックボックス列の情報を取得
                DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells[(int)DGV_COLUMN.CHECKBOX];
                bool isChecked = (bool)checkBox.Value;
                if (!isAll && !isChecked)
                {
                    // チェックした画像のみ出力時 かつ チェックされてない画像は飛ばす
                    continue;
                }

                // パス情報列を取得
                DataGridViewTextBoxCell pathCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.IMAGE_PATH];
                string path = pathCell.Value.ToString()!;

                // 出力後の画像名に利用する情報を取得
                string extention = GetResizedExtention(Path.GetExtension(path)); // 拡張子
                string filename = Path.GetFileNameWithoutExtension(path); // ファイル名

                // サイズ変換
                DataGridViewTextBoxCell resizeWidthCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.RESIZE_WIDTH];
                DataGridViewTextBoxCell resizeHeightCell = (DataGridViewTextBoxCell)row.Cells[(int)DGV_COLUMN.RESIZE_HEIGHT];
                int width = (int)resizeWidthCell.Value;
                int height = (int)resizeHeightCell.Value;

                // 出力するファイルパスを作成
                string outFullPath = outPutDirectoryPath + @"\" + this.outputTbPattern.Text + filename + extention;

                // 処理中のファイル名を進捗表示ダイアログに表示
                string orgFileName = Path.GetFileName(path);
                progressDialog.SetItemName(orgFileName);

                try
                {
                    // リサイズ処理
                    ImageResizer imageResizer = new ImageResizer(path, outFullPath);
                    imageResizer.resize(width, height, this.outputCbExtention.Text);
                }
                catch (Exception err)
                {
                    // 例外発生時はファイル名を覚えておいて次に行く
                    errImgNameList.Add(orgFileName);
                    continue;
                }
                finally
                {
                    // 正常時も例外時もプログレスバーを進める
                    progressDialog.IncrementProgressValue();
                }
            }

            // 進捗報告用ダイアログを閉じる
            progressDialog.Dispose();

            // エラー時の処理
            if (errImgNameList.Count() > 0)
            {
                // 処理できなかったファイルをメッセージボックスで表示
                string msg = "予期せぬエラーにより、以下のファイルは処理できませんでした。\r\n　" + string.Join("\r\n　", errImgNameList);
                MessageBox.Show(msg, "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 正常終了時
            MessageBox.Show("処理が終了しました", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("explorer.exe", outPutDirectoryPath); // 出力先フォルダを開く
        }

        /// <summary>
        /// ピクセル数で設定タブの「設定する」ボタンが押されたら
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPixelSetting_Click(object sender, EventArgs e)
        {
            // すべての画像に適用するか
            bool isAll = this.pixel_ApplyTypeSelector.IsAll();

            // 設定情報をDataGridViewの変更後サイズ保持用セルに保存
            ApplyPixelSetting(isAll);
        }

        /// <summary>
        /// 割合で設定タブの「設定する」ボタンが押されたら
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRaitoSetting_Click(object sender, EventArgs e)
        {
            // すべての画像に適用するか
            bool isAll = this.ratio_ApplyTypeSelector.IsAll();

            // 設定情報をDataGridViewの変更後サイズ保持用セルに保存
            ApplyRaitoSetting(isAll);
        }

        /// <summary>
        /// 出力設定エリアのラジオボタンが変更されたら
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioOutput_CheckedChanged(object sender, EventArgs e)
        {
            SwitchControllsEnabledOutputSettingArea();
        }

        /// <summary>
        /// 任意のフォルダに出力時の「フォルダを選択」ボタンがクリックされたら
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOutFolderSelect_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            folderDialog.Description = "出力するフォルダを指定してください。";

            //最初に選択するフォルダを指定する
            folderDialog.SelectedPath = this.outputLbFolderPath.Text;

            //ユーザーが新しいフォルダを作成できるようにする
            folderDialog.ShowNewFolderButton = true;

            //ダイアログを表示する
            if (folderDialog.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダを表示する
                this.outputLbFolderPath.Text = folderDialog.SelectedPath;
            }
        }



        /////////////////////////////
        //バリデーション処理　ここから
        /////////////////////////////

        /// <summary>
        /// テキストボックスに入力されたフォルダ名・ファイル名のバリデーションを行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validationFolderFileNameTextBox(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // バリデーション
            // 正しく入力しないと次に行けない
            Regex regex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9_-]+$");
            if (!regex.IsMatch(((TextBox)sender).Text))
            {
                // バリデーションエラー発生フラグを立てる
                isValidationError = true;

                string msg = Consts.Validation.Message.FOLDER_fILE_NAME_MSG;
                MessageBox.Show(msg, Consts.Validation.MsgBoxTitle.NOTICE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                // true で、正しく入力しないと他のコントロールを操作できなくする。
                e.Cancel = true;
            }
            else
            {
                // バリデーションエラー発生フラグを下ろす
                isValidationError = false;
            }
        }

        /// <summary>
        /// テキストボックスに入力された整数のバリデーションを行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void varidationIntTextBox(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // バリデーション
            // 正しく入力しないと次に行けない
            Regex regex = new System.Text.RegularExpressions.Regex("^[1-9][0-9]*$");
            if (!regex.IsMatch(((TextBox)sender).Text))
            {
                // バリデーションエラー発生フラグを立てる
                isValidationError = true;

                string msg = Consts.Validation.Message.INT_MSG;
                MessageBox.Show(msg, Consts.Validation.MsgBoxTitle.NOTICE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                // true で、正しく入力しないと他のコントロールを操作できなくする。
                e.Cancel = true;
            }
            else
            {
                // バリデーションエラー発生フラグを下ろす
                isValidationError = false;
            }
        }

        /// <summary>
        /// 出力先のフォルダ名を入力されたら発生するバリデーションチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputTbFolderName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validationFolderFileNameTextBox(sender, e);
        }

        /// <summary>
        /// 出力後のファイル名のパターンが入力されたら発生するバリデーションチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputTbPattern_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validationFolderFileNameTextBox(sender, e);
        }

        /// <summary>
        /// 設定エリア　割合の横幅が入力されたら発生するバリデーションチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ratio_Width_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            varidationIntTextBox(sender, e);
        }

        /// <summary>
        /// 設定エリア　割合の立幅が入力されたら発生するバリデーションチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ratio_Height_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            varidationIntTextBox(sender, e);
        }

        /// <summary>
        /// 設定エリア　ピクセル数の横幅が入力されたら発生するバリデーションチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pixel_Width_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            varidationIntTextBox(sender, e);
        }

        /// <summary>
        /// 設定エリア　ピクセル数の横幅が入力されたら発生するバリデーションチェック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pixel_Height_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            varidationIntTextBox(sender, e);
        }

        /// <summary>
        /// メインのフォームが閉じられたら
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isValidationError)
            {
                // 現在の設定情報をプロパティに保存
                FormStateSave();
            }

            // バリデーションによりアプリが閉じないため、強引に終了処理を呼び出す
            Application.Exit();
        }

        /// <summary>
        /// アイコンをクリックしたらブログをブラウザで表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webSiteIcon_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = "https://torampo.com",
                UseShellExecute = true,
            };
            //ブラウザで開く
            System.Diagnostics.Process.Start(pi);
        }
    }
}
