using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizeSoft
{
    public class Consts
    {
        public class FileFilter
        {
            public static string [] IMAGE_EXTENSIONS
            {
                get { return _IMAGE_EXTENSIONS; }
            }
            private static string[] _IMAGE_EXTENSIONS = new string[]
            {
                ".bmp",
                ".gif",
                ".jpg",
                ".jpeg",
                ".png",
                ".tiff",
                ".tif",
            };


            public static string IMAGE_FILTER_TEXT
            {
                get { return "画像ファイル(*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tiff;*.tif;)|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tiff;*.tif;"; }
            }


        }

        public class FormText
        {
            public static string GAZOU_YOMIKOMI
            {
                get { return "画像を読み込み中..."; }
            }

            public static string GAZOU_RESIZE
            {
                get { return "リサイズ中..."; }
            }

            public static string FILE_INPUT_DIALOG_TITLE
            {
                get { return "サイズ変更する画像を選択してください（複数選択可）"; }
            }
        }

        public class FormConfig
        {
            public enum SettingTab
            {
                RATIO_TAB,
                PIXEL_TAB,
            }
        }

        public class ViewConfig
        {

        }

        public class Message
        {
            public static string IS_EXIST_FILE { get { return "画像の出力先には既にファイルがあります。\r\n同じ名前のファイルは上書きされますが、よろしいですか？"; } }
        }

        public class Validation
        {
            public class Message
            {
                public static string FOLDER_fILE_NAME_MSG { get { return "入力できる文字は「半角英数字、アンダーバー、ハイフン」です。\r\nまた、空白は設定できません。"; } }
                public static string INT_MSG { get { return "0より大きい整数を入力してください。"; } }
            }

            public class MsgBoxTitle
            {
                public static string NOTICE { get { return "お知らせ"; } }
            }
        }
    }
    /// <summary>
    /// フォームデザイン側のDataGridViewと順列を合わせること
    /// </summary>
    public enum ViewColumn
    {
        CHECKBOX,
        IMAGE_ICON,
        ORIGINAL_IMAGE_SIZE,
        RESIZE_IMAGE_WIDTH,
        RESIZE_IMAGE_HEIGHT,
        IMAGE_PATH,
    }
}
