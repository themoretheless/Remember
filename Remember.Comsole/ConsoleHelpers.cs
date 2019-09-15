using System;
using System.Runtime.InteropServices;

namespace Remember.Console
{
    public static class ConsoleHelpers
    {
        //[DllImport("kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //public static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();


        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        //private const int STD_OUTPUT_HANDLE = -11;
        //private const int MY_CODE_PAGE = 437;
        //private static bool showConsole = true; //Or false if you don't want to see the console


        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        // System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        // AllocConsole();
        // IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
        // Microsoft.Win32.SafeHandles.SafeFileHandle safeFileHandle = new Microsoft.Win32.SafeHandles.SafeFileHandle(stdHandle, true);
        // FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
        // System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
        // StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
        // standardOutput.AutoFlush = true;
        // Console.SetOut(standardOutput);


        public static void ShowWindow()
        {
            var handle = GetConsoleWindow();
          
            if (handle == IntPtr.Zero)
            {
                AllocConsole();
            }
            else
            {
                ShowWindow(handle, SW_SHOW);
            }

            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        public static void HideWindow()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }
    }
}
