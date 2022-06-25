using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace spoofer
{
    internal static class Program
    {
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_SIZE = 0xF000;//resize

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        private static void WriteColoredLines(string[] lines, Point start, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            for (int row = 0; row < lines.Length; row++)
            {
                Console.SetCursorPosition(start.X, start.Y + row);
                Console.Write(lines[row]);
            }
        }

        static void Main()
        {
            //custom size
            //-----------//
            //Console.SetWindowSize(120, 13);

            IntPtr handle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(handle, false);

            if (handle != IntPtr.Zero)
            {
                DeleteMenu(sysMenu, SC_MAXIMIZE, MF_BYCOMMAND);
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);//resize]
            }

            Console.Title = "Release - v1.00";

            Console.ForegroundColor = ConsoleColor.White;

            //run as admin to work
            //-----------//

            /* bool admintest = false;
             admintest = (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
             if (admintest == false)
             {
                 string[] topOfT3 =
 {
         " ",
         " ",
         "   [",
     };

                 string[] bottomOfT3 =
                 {
         " ",
     };

                 string[] letterE3 =
                 {
                "X",
     };
                 string[] letterST3 =
     {
                 "] : Failed connecting to server. ",
     };

                 WriteColoredLines(topOfT3, new Point(0, 0), ConsoleColor.White);
                 WriteColoredLines(bottomOfT3, new Point(0, 5), ConsoleColor.White);
                 WriteColoredLines(letterE3, new Point(4, 2), ConsoleColor.DarkRed);
                 WriteColoredLines(letterST3, new Point(5, 2), ConsoleColor.White);
                 MessageBox.Show("Please run with administrator privilegies", "Moon", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 Application.Exit();
             }
             else if (admintest == true)
             {

                 string[] topOfT3 =
 {
         " ",
         " ",
         "   [",
     };

                 string[] bottomOfT3 =
                 {
         " ",
     };

                 string[] letterE3 =
                 {
                "-",
     };
                 string[] letterST3 =
     {
                 "] : Wellcome to NAME. ",
     };

                 WriteColoredLines(topOfT3, new Point(0, 0), ConsoleColor.White);
                 WriteColoredLines(bottomOfT3, new Point(0, 5), ConsoleColor.White);
                 WriteColoredLines(letterE3, new Point(4, 2), ConsoleColor.DarkRed);
                 WriteColoredLines(letterST3, new Point(5, 2), ConsoleColor.White);

                 string[] topOfT3s =
     {
         " ",
         " ",
         "   [",
     };

                 string[] bottomOfT3s =
                 {
         " ",
     };

                 string[] letterE3s =
                 {
                "-",
     };
                 string[] letterST3s =
     {
                 "] : github.com/1Agent002/Spoofer ",
     };

                 WriteColoredLines(topOfT3s, new Point(0, 2), ConsoleColor.White);
                 WriteColoredLines(bottomOfT3s, new Point(0, 9), ConsoleColor.White);
                 WriteColoredLines(letterE3s, new Point(4, 4), ConsoleColor.DarkRed);
                 WriteColoredLines(letterST3s, new Point(5, 4), ConsoleColor.White);


                 string[] topOfT3s1 =
     {
         " ",
         " ",
         "   [",
     };

                 string[] bottomOfT3s1 =
                 {
         " ",
     };

                 string[] letterE3s1 =
                 {
                "!",
     };
                 string[] letterST3s1 =
     {
                 "] Press any key to continue! ",
     };

                 WriteColoredLines(topOfT3s1, new Point(0, 5), ConsoleColor.White);
                 WriteColoredLines(bottomOfT3s1, new Point(0, 12), ConsoleColor.White);
                 WriteColoredLines(letterE3s1, new Point(4, 7), ConsoleColor.DarkRed);
                 WriteColoredLines(letterST3s1, new Point(5, 7), ConsoleColor.White);

                 Console.ReadKey(true);
                 main();

             }*/

            string[] topOfT3 =
{
         " ",
         " ",
         "   [",
     };

            string[] bottomOfT3 =
            {
         " ",
     };

            string[] letterE3 =
            {
                "-",
     };
            string[] letterST3 =
{
                 "] : Wellcome to NAME. ",
     };

            WriteColoredLines(topOfT3, new Point(0, 0), ConsoleColor.White);
            WriteColoredLines(bottomOfT3, new Point(0, 5), ConsoleColor.White);
            WriteColoredLines(letterE3, new Point(4, 2), ConsoleColor.DarkRed);
            WriteColoredLines(letterST3, new Point(5, 2), ConsoleColor.White);

            string[] topOfT3s =
{
         " ",
         " ",
         "   [",
     };

            string[] bottomOfT3s =
            {
         " ",
     };

            string[] letterE3s =
            {
                "-",
     };
            string[] letterST3s =
{
                 "] : https://github.com/1Agent002/Spoofer ",
     };

            WriteColoredLines(topOfT3s, new Point(0, 2), ConsoleColor.White);
            WriteColoredLines(bottomOfT3s, new Point(0, 9), ConsoleColor.White);
            WriteColoredLines(letterE3s, new Point(4, 4), ConsoleColor.DarkRed);
            WriteColoredLines(letterST3s, new Point(5, 4), ConsoleColor.White);


            string[] topOfT3s1 =
{
         " ",
         " ",
         "   [",
     };

            string[] bottomOfT3s1 =
            {
         " ",
     };

            string[] letterE3s1 =
            {
                "!",
     };
            string[] letterST3s1 =
{
                 "] Press any key to continue! ",
     };

            WriteColoredLines(topOfT3s1, new Point(0, 5), ConsoleColor.White);
            WriteColoredLines(bottomOfT3s1, new Point(0, 12), ConsoleColor.White);
            WriteColoredLines(letterE3s1, new Point(4, 7), ConsoleColor.DarkRed);
            WriteColoredLines(letterST3s1, new Point(5, 7), ConsoleColor.White);

            Console.ReadKey(true);
            main();

        }


        public static void main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n  [1] Spoofer\n  [2] UnSpoof\n  [3] Miscellaneous");

            string[] topOfTs =
{
        " ",
        " ",
        "  [",
    };

            string[] bottomOfTs =
            {
        " ",
    };

            string[] letterEs =
            {
               "!",
    };
            string[] letterSTs =
{
                "] : Option - ",
    };

            WriteColoredLines(topOfTs, new Point(0, 3), ConsoleColor.White);
            WriteColoredLines(bottomOfTs, new Point(0, 10), ConsoleColor.White);
            WriteColoredLines(letterEs, new Point(3, 5), ConsoleColor.DarkRed);
            WriteColoredLines(letterSTs, new Point(4, 5), ConsoleColor.White);

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    spoof();
                    break;
                case 2:
                    break;
                case 3:
                    Console.Clear();
                    misc();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\n  [!] Invalid Selection");
                    Thread.Sleep(1500);
                    main();
                    break; // no point in this other than to not get error from IDE
            }
        }

        public static void misc()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n  [1] Serial Checker\n  [0] Back");

            string[] topOfTs =
{
        " ",
        " ",
        "  [",
    };

            string[] bottomOfTs =
            {
        " ",
    };

            string[] letterEs =
            {
               "!",
    };
            string[] letterSTs =
{
                "] : Option - ",
    };

            WriteColoredLines(topOfTs, new Point(0, 2), ConsoleColor.White);
            WriteColoredLines(bottomOfTs, new Point(0, 10), ConsoleColor.White);
            WriteColoredLines(letterEs, new Point(3, 4), ConsoleColor.DarkRed);
            WriteColoredLines(letterSTs, new Point(4, 4), ConsoleColor.White);


            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    hwid();
                    break;
                case 0:
                    Console.Clear();
                    main();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\n  [!] Invalid Selection");
                    Thread.Sleep(1500);
                    misc();
                    break; // no point in this other than to not get error from IDE
            }
        }

        public static void hwid()
        {
            string hwid;

            Console.Clear();
            string[] topOfTs1 =
{
        " ",
        " ",
        "   [",
    };

            string[] bottomOfTs1 =
            {
        " ",
    };

            string[] letterEs1 =
            {
               "+",
    };
            string[] letterSTs1 =
{
                "] : HWID - ",
    };

            WriteColoredLines(topOfTs1, new Point(0, 1), ConsoleColor.White);
            WriteColoredLines(bottomOfTs1, new Point(0, 9), ConsoleColor.White);
            WriteColoredLines(letterEs1, new Point(4, 3), ConsoleColor.DarkRed);
            WriteColoredLines(letterSTs1, new Point(5, 3), ConsoleColor.White);
            hwid = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            Console.WriteLine(hostName);
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            string[] topOfTs12 =
{
        " ",
        " ",
        "   [",
    };

            string[] bottomOfTs12 =
            {
        " ",
    };

            string[] letterEs12 =
            {
               "+",
    };
            string[] letterSTs12 =
{
                "] : IP - ",
    };

            WriteColoredLines(topOfTs12, new Point(0, 2), ConsoleColor.White);
            WriteColoredLines(bottomOfTs12, new Point(0, 10), ConsoleColor.White);
            WriteColoredLines(letterEs12, new Point(4, 4), ConsoleColor.DarkRed);
            WriteColoredLines(letterSTs12, new Point(5, 4), ConsoleColor.White);
            Console.WriteLine("" + myIP);


            string[] topOfT3s1 =
{
         " ",
         " ",
         "   [",
     };

            string[] bottomOfT3s1 =
            {
         " ",
     };

            string[] letterE3s1 =
            {
                "!",
     };
            string[] letterST3s1 =
{
                 "] Press any key to go back! ",
     };

            WriteColoredLines(topOfT3s1, new Point(0, 4), ConsoleColor.White);
            WriteColoredLines(bottomOfT3s1, new Point(0, 11), ConsoleColor.White);
            WriteColoredLines(letterE3s1, new Point(4, 6), ConsoleColor.DarkRed);
            WriteColoredLines(letterST3s1, new Point(5, 6), ConsoleColor.White);

            Console.ReadKey(true);
            misc();
        }

        public static void spoof()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n  [1] Spoof\n  [2] Clean\n  [3] CitizenFX\n  [4] Unlink Discord\n  [5] Change Rockstar\n  [0] Back");

            string[] topOfTs =
{
        " ",
        " ",
        "  [",
    };

            string[] bottomOfTs =
            {
        " ",
    };

            string[] letterEs =
            {
               "!",
    };
            string[] letterSTs =
{
                "] : Option - ",
    };

            WriteColoredLines(topOfTs, new Point(0, 6), ConsoleColor.White);
            WriteColoredLines(bottomOfTs, new Point(0, 10), ConsoleColor.White);
            WriteColoredLines(letterEs, new Point(3, 8), ConsoleColor.DarkRed);
            WriteColoredLines(letterSTs, new Point(4, 8), ConsoleColor.White);

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    bypass();
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    clean();
                    break;
                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    citizen();
                    break;
                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    discord();
                    break;
                case 5:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    rockstar();
                    break;
                case 0:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    main();
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\n  [!] Invalid Selection");
                    Thread.Sleep(1500);
                    spoof();
                    break; // no point in this other than to not get error from IDE
            }
        }
        public static void bypass()
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"taskkill /f /im Steam.exe /t");
                writer.WriteLine(@"@echo off");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\HardwareID /f");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\Store /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory /f");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S -1-5-21-1282084573-1681065996-3115981261-1001 /va /f");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView /f");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched /f");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView /f");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S-1-5-21-332004695-2829936588-140372829-1002 /f");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched /f");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S -1-5-21-1282084573-1681065996-3115981261-1001 /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched /f");
                writer.WriteLine(@"del /y c:\windows\tempor~1");
                writer.WriteLine(@"del /y c:\windows\temp");
                writer.WriteLine(@"del /y c:\windows\tmp");
                writer.WriteLine(@"del /y c:\windows\ff *.tmp");
                writer.WriteLine(@"del /y c:\windows\history");
                writer.WriteLine(@"del /y c:\windows\cookies");
                writer.WriteLine(@"del /y c:\windows\recent");
                writer.WriteLine(@"del /y c:\windows\spool\printers");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_chrome.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_372.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_1604.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_1868.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_2060.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_2189.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\botan.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\asi - five.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\steam.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\steam_api64.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenGame.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\profiles.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\cfx_curl_x86_64.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX.ini");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\caches.XML");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\adhesive.dll");
                writer.WriteLine(@"cls");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);

            string[] topOfTs3 =
{
        " ",
        " ",
        "   [",
    };

            string[] bottomOfTs3 =
            {
        " ",
    };

            string[] letterEs3 =
            {
               "Done",
    };
            string[] letterSTs3 =
{
                "]",
    };

            WriteColoredLines(topOfTs3, new Point(0, 0), ConsoleColor.Green);
            WriteColoredLines(bottomOfTs3, new Point(0, 10), ConsoleColor.White);
            WriteColoredLines(letterEs3, new Point(4, 2), ConsoleColor.White);
            WriteColoredLines(letterSTs3, new Point(8, 2), ConsoleColor.Green);


            Thread.Sleep(2000);
            main();
        }

        public static void clean()
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"cls");
                writer.WriteLine(@"taskkill /f /im Steam.exe /t");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"@echo off");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\HardwareID /f");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSLicensing\Store /f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory /f");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S -1-5-21-1282084573-1681065996-3115981261-1001 /va /f");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView /f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETEH KEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\WinRAR\ArcHistory /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched /f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView /f");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S-1-5-21-332004695-2829936588-140372829-1002 /f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_CLASSES_ROOT\Local Settings\Software\Microsoft\Windows\Shell\MuiCache /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched /f");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"REG DELETE HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Services\bam\State\UserSettings\S -1-5-21-1282084573-1681065996-3115981261-1001 /f");
                writer.WriteLine(@"REG DELETE HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched /f");
                writer.WriteLine(@"del /y c:\windows\tempor~1");
                writer.WriteLine(@"del /y c:\windows\temp");
                writer.WriteLine(@"del /y c:\windows\tmp");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del /y c:\windows\ff *.tmp");
                writer.WriteLine(@"del /y c:\windows\history");
                writer.WriteLine(@"del /y c:\windows\cookies");
                writer.WriteLine(@"del /y c:\windows\recent");
                writer.WriteLine(@"del /y c:\windows\spool\printers");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_chrome.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_372.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_1604.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_1868.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_2060.bin");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX_SubProcess_game_2189.bin");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\botan.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\asi - five.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\steam.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\steam_api64.dll");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenGame.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\profiles.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\cfx_curl_x86_64.dll");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\CitizenFX.ini");
                writer.WriteLine(@"cls");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\caches.XML");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\adhesive.dll");
                writer.WriteLine(@"cls");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);

            string[] topOfTs3 =
{
        " ",
        " ",
        "   [",
    };

            string[] bottomOfTs3 =
            {
        " ",
    };

            string[] letterEs3 =
            {
               "Done",
    };
            string[] letterSTs3 =
{
                "]",
    };

            WriteColoredLines(topOfTs3, new Point(0, 0), ConsoleColor.Green);
            WriteColoredLines(bottomOfTs3, new Point(0, 10), ConsoleColor.White);
            WriteColoredLines(letterEs3, new Point(4, 2), ConsoleColor.White);
            WriteColoredLines(letterSTs3, new Point(8, 2), ConsoleColor.Green);


            Thread.Sleep(2000);
            main();
        }

        public static void citizen()
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"@echo off");
                writer.WriteLine(@"timeout 2 >nul");
                writer.WriteLine(@"rmdir /s /q %userprofile%\AppData\Roaming\CitizenFX");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);

            string[] topOfTs3 =
{
        " ",
        " ",
        "   [",
    };

            string[] bottomOfTs3 =
            {
        " ",
    };

            string[] letterEs3 =
            {
               "Done",
    };
            string[] letterSTs3 =
{
                "]",
    };

            WriteColoredLines(topOfTs3, new Point(0, 0), ConsoleColor.Green);
            WriteColoredLines(bottomOfTs3, new Point(0, 10), ConsoleColor.White);
            WriteColoredLines(letterEs3, new Point(4, 2), ConsoleColor.White);
            WriteColoredLines(letterSTs3, new Point(8, 2), ConsoleColor.Green);


            Thread.Sleep(2000);
            main();
        }

        public static void discord()
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"@echo off");
                writer.WriteLine(@"del /s /q /f %LocalAppData%\FiveM\FiveM.app\discord.dll");
                writer.WriteLine(@"RENAME %userprofile%\AppData\Roaming\discord\0.0.309\modules\discord_rpc SPOOFER");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);

            string[] topOfTs3 =
{
        " ",
        " ",
        "   [",
    };

            string[] bottomOfTs3 =
            {
        " ",
    };

            string[] letterEs3 =
            {
               "Done",
    };
            string[] letterSTs3 =
{
                "]",
    };

            WriteColoredLines(topOfTs3, new Point(0, 0), ConsoleColor.Green);
            WriteColoredLines(bottomOfTs3, new Point(0, 10), ConsoleColor.White);
            WriteColoredLines(letterEs3, new Point(4, 2), ConsoleColor.White);
            WriteColoredLines(letterSTs3, new Point(8, 2), ConsoleColor.Green);


            Thread.Sleep(2000);
            main();
        }

        public static void rockstar()
        {
            string tempFilename = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
            using (StreamWriter writer = new StreamWriter(tempFilename))
            {
                writer.WriteLine(@"@echo off");
                writer.WriteLine(@"rmdir /s /q  %LocalAppData%\DigitalEntitlements");
            }
            Process process = Process.Start(tempFilename);
            process.WaitForExit();
            File.Delete(tempFilename);

            string[] topOfTs3 =
{
        " ",
        " ",
        "   [",
    };

            string[] bottomOfTs3 =
            {
        " ",
    };

            string[] letterEs3 =
            {
               "Done",
    };
            string[] letterSTs3 =
{
                "]",
    };

            WriteColoredLines(topOfTs3, new Point(0, 0), ConsoleColor.Green);
            WriteColoredLines(bottomOfTs3, new Point(0, 10), ConsoleColor.White);
            WriteColoredLines(letterEs3, new Point(4, 2), ConsoleColor.White);
            WriteColoredLines(letterSTs3, new Point(8, 2), ConsoleColor.Green);


            Thread.Sleep(2000);
            main();
        }
    }
}
