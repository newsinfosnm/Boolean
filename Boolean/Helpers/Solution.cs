using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

using Boolean.Network.Messages;
using Boolean.Network.Transmission;

namespace Boolean
{
    static class Solution
    {
        public static DateTime Started;

        public static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Console.CursorVisible = false;
            Console.Title = "Project Boolean - 1/1/2012 - by Breakz0ne";
            Console.ForegroundColor = ConsoleColor.White;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("                                                                               ");
            Console.WriteLine("       ########...#######...#######..##.......########....###....##....##      ");
            Console.WriteLine("       ##.....##.##.....##.##.....##.##.......##.........##.##...###...##      ");
            Console.WriteLine("       ##.....##.##.....##.##.....##.##.......##........##...##..####..##      ");
            Console.WriteLine("       ########..##.....##.##.....##.##.......######...##.....##.##.##.##      ");
            Console.WriteLine("       ##.....##.##.....##.##.....##.##.......##.......#########.##..####      ");
            Console.WriteLine("       ##.....##.##.....##.##.....##.##.......##.......##.....##.##...###      ");
            Console.WriteLine("       ########...#######...#######..########.########.##.....##.##....##      ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("       __________________________________________________________________      ");
            Console.WriteLine("       Habbo Emulator System - (Breakz0ne) - C# Thread safety & security.      ");
            Console.WriteLine("                                                                               ");

            AppendLine();
            Console.BackgroundColor = ConsoleColor.Black;
            AppendLine("© All rights reserved. Private development 2012.");
            AppendLine("© There's no way to rename, you will be dead.");
            AppendLine("© Developers: Breakz0ne (Engineer)");
            AppendLine();

            if (Settings.Serialize() == Enumerables.SerializeResult.Broken) { AppendPaint(); AppendLine("Settings: Could not serialize main method."); while (true); };
            if (SessionHandler.Serialize() == Enumerables.SerializeResult.Broken) { AppendPaint(); AppendLine("SocketHandler: Could not serialize main method."); while (true);};
            if (MessageHandler.Serialize() == Enumerables.SerializeResult.Broken) { AppendPaint(); AppendLine("MessageHandler: Could not serialize main method."); while (true);};
            if (DatabaseHandler.Serialize() == Enumerables.SerializeResult.Broken) { AppendPaint(); AppendLine("DatabaseHandler: Could not serialize main method."); while (true);};
            if (StorageHandler.Serialize() == Enumerables.SerializeResult.Broken) { AppendPaint(); AppendLine("StorageHandler: Could not serialize main method."); while (true);};

            AppendLine();
            AppendPaint(ConsoleColor.Yellow);
            AppendLine("Solution: Solution progressed, everything ready up.");
            AppendLine();

            Started = DateTime.Now;

            if (Settings.GetValue("ControlPanel.Enabled").ToLower() == "true")
            {
                Application.Run(new ControlPanel());
            }

            while (true) ;
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var Exception = e.ExceptionObject as Exception;

            AppendPaint();
            AppendLine("ExceptionHandler: {0}",Exception.ToString());

            var FileStream = StreamWriter.Null;

            if (File.Exists("boolean.errors"))
            {
                FileStream = File.AppendText("boolean.errors");
            }
            else FileStream = new StreamWriter("boolean.errors");

            FileStream.WriteLine(DateTime.Now.ToString() + " > " + Exception.ToString());
            FileStream.WriteLine();
            FileStream.Close();

            while (true) ;
        }

        #region Interface
        private static int LinesLeft;

        public static void AppendPaint()
        {
            AppendPaint(ConsoleColor.Red, 1);
        }

        public static void AppendPaint(ConsoleColor Color)
        {
            AppendPaint(Color, 1);
        }

        public static void AppendPaint(ConsoleColor Color, int Lines)
        {
            LinesLeft = Lines;

            Console.ForegroundColor = Color;
        }

        public static void AppendLine()
        {
            using (var Writer = TextWriter.Synchronized(Console.Out))
            {
                Writer.WriteLine();
            }

            if (Console.ForegroundColor != ConsoleColor.White)
            {
                LinesLeft--;

                if (LinesLeft <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        public static void AppendLine(string Line, params object[] Parameters)
        {
            using (var Writer = TextWriter.Synchronized(Console.Out))
            {
                Writer.WriteLine(GetLine(Line), Parameters);
            }

            if (Console.ForegroundColor != ConsoleColor.White)
            {
                LinesLeft--;

                if (LinesLeft <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static string GetLine(string Line)
        {
            return string.Format(" [LOG] - {0}", Line);
        }
        #endregion
    }
}
