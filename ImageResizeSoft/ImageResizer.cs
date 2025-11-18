using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizeSoft
{
    class ImageResizer
    {
        string InputPath { get; set; }
        string OutputPath { get; set; }

        public ImageResizer(string inputImagePath, string outputImagePath)
        {
            this.InputPath = inputImagePath;
            this.OutputPath = outputImagePath;
        }

        public void resize(int newWidth, int newHeight, string extention)
        {
            if (File.Exists(this.OutputPath))
            {
                File.Delete(this.OutputPath);
            }

            // 画像ファイルを開く（読み取り専用）
            FileStream fs = new FileStream(this.InputPath, FileMode.Open, FileAccess.Read);


            // 画像をサイズ変更する処理
            using (Image image = Image.FromStream(fs)) // サイズ変更する画像を開く
            using (Bitmap bitmap = new Bitmap(newWidth, newHeight)) // サイズ変更先の画像を作成する
            using (Graphics graphics = Graphics.FromImage(bitmap)) // bitmap上で画像加工できるツール
            {
                // サイズ変更時の保管方法を設定する
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;

                // 取り込んだ画像を指定の大きさで描画する
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

                // 画像フォーマットを取得する
                var format = image.RawFormat;

                switch (extention)
                {
                    case ".jpg":
                    case ".jpeg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".png":
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    case ".gif":
                        format = System.Drawing.Imaging.ImageFormat.Gif;
                        break;
                    case ".tiff":
                    case ".tif":
                        format = System.Drawing.Imaging.ImageFormat.Tiff;
                        break;
                }

                // 加工された画像を出力する
                bitmap.Save(this.OutputPath, format);
            }

            fs.Close();
        }
    }
}
