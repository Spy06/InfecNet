using System.Runtime.InteropServices;
namespace InfecNet
{
    public static class Extension
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);
    
        /// <summary>
        ///<param name="path">The full path to the image file, example: "D:/InfecNet/UI/pngfind.com-red-skull-png-616733.png"</param>
        ///</summary>
        public static void SetDesktopWallpaper (string path){
            SystemParametersInfo(20, 0, path,
                    0x01 | 0x02);
        }
    }
}