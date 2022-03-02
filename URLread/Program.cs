using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
namespace OpenFromURL
{
    class Program
    {
        [DllImport("shell32.dll", EntryPoint = "FindExecutable")]
        private static extern long FindExecutable(string lpFile, string lpDirectory, StringBuilder lpResult);
        static void Main(string[] args)
        {
            var pathToFile = args[0].Replace("unitydoprocess:", "").Replace("%5C", "\\");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\UnityDP\\test" + Path.GetExtension(pathToFile);
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) { }
            }
            var command = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86), "Max Rook (MexiMux)", "SMPbeta Launcher", "SMPbeta Launcher.exe");
            var commandToRun ="start" + "\"" + command + "\" ";
            Console.Write(Environment.NewLine); Console.Write("Path: " + path);
            Console.Write(Environment.NewLine); Console.Write("Command to run: " + commandToRun); Console.Write(Environment.NewLine);
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(commandToRun);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
        }
    }
}