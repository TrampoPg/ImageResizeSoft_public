using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageResizeSoft.Properties;

namespace ImageResizeSoft
{
    class FormStateConfig
    {
        class Input
        {
            internal static string InputFolderPath
            {
                get
                {
                    string path = Properties.Settings.Default.Input_FolderPath;
                    bool isExistFolder = !string.IsNullOrEmpty(path) && Path.Exists(path);
                    // パスのフォルダが存在しなければデスクトップへのパスを返す
                    path = isExistFolder ? path : System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    return path;
                }
                set { Properties.Settings.Default.Input_FolderPath = value; }
            }
        }

        internal static class Setting
        {
            internal static int TabIndex
            {
                get { return Properties.Settings.Default.Setting_TabIndex; }
                set { Properties.Settings.Default.Setting_TabIndex = value; }
            }
            internal static class Ratio
            {
                internal static int Width
                {
                    get { return Properties.Settings.Default.Setting_RatioWidth; }
                    set { Properties.Settings.Default.Setting_RatioWidth = value; }
                }

                internal static int Height
                {
                    get { return Properties.Settings.Default.Setting_RatioHeight; }
                    set { Properties.Settings.Default.Setting_RatioHeight = value; }
                }

                internal static bool IsAll
                {
                    get { return Properties.Settings.Default.Setting_RatioIsAll; }
                    set { Properties.Settings.Default.Setting_RatioIsAll = value; }
                }
            }

            internal static class Pixel
            {
                internal static int Width
                {
                    get { return Properties.Settings.Default.Setting_PixelWidth; }
                    set { Properties.Settings.Default.Setting_PixelWidth = value; }
                }

                internal static int Height
                {
                    get { return Properties.Settings.Default.Setting_PixelHeight; }
                    set { Properties.Settings.Default.Setting_PixelHeight = value; }
                }

                internal static bool IsAll
                {
                    get { return Properties.Settings.Default.Setting_PixelIsAll; }
                    set { Properties.Settings.Default.Setting_PixelIsAll = value; }
                }
            }
        }

        internal static class Output
        {

            internal static string Extention
            {
                get { return Properties.Settings.Default.Output_Extention; }
                set { Properties.Settings.Default.Output_Extention = value; }
            }

            internal static string FilePattern
            {
                get
                {
                    string pattern = Properties.Settings.Default.Output_FilePattern;
                    pattern = string.IsNullOrEmpty(pattern) ? "sml_" : pattern;
                    return pattern;
                }
                set { Properties.Settings.Default.Output_FilePattern = value; }
            }

            internal static bool IsAll
            {
                get { return Properties.Settings.Default.Output_IsAll; }
                set { Properties.Settings.Default.Output_IsAll = value; }
            }

            internal static bool IsImageFolder
            {
                get { return Properties.Settings.Default.Output_IsImageFolder; }
                set { Properties.Settings.Default.Output_IsImageFolder = value; }
            }

            internal static bool IsSelectedFolder
            {
                get { return Properties.Settings.Default.Output_IsSelectedFolder; }
                set { Properties.Settings.Default.Output_IsSelectedFolder = value; }
            }

            internal static string MakeFolderName
            {
                get
                {
                    string name = Properties.Settings.Default.Output_MakeFolderName;
                    name = string.IsNullOrEmpty(name) ? "resized" : name;
                    return name;
                }
                set { Properties.Settings.Default.Output_MakeFolderName = value; }
            }

            internal static string SelectedFolderPath
            {
                get {
                    string path = Properties.Settings.Default.Output_SelectedFolderPath;
                    bool isExistFolder = !string.IsNullOrEmpty(path) && Path.Exists(path);
                    // パスのフォルダが存在しなければデスクトップへのパスを返す
                    path = isExistFolder ? path : System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    return path;
                }
                set { Properties.Settings.Default.Output_SelectedFolderPath = value; }
            }
        }

        internal static void Save()
        {
            Properties.Settings.Default.Save();
        }
    }
}
