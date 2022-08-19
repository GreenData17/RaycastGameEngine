using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaycastGameEngine
{
    public class Manager
    {
        public static Manager instance;

        public string compilerPath;
        public string c_filePath;
        public string outputPath;
        public string glut32Path;
        
        public string gameName = "game";

        public Manager(string startupPath)
        {
            if(instance is null) instance = this;

            compilerPath = $"\"{startupPath}\\game\\mingw32\\bin\\gcc.exe\"";
            c_filePath = $"\"{startupPath}\\game\\main.c\"";
            outputPath = $"\"{startupPath}\\game\\";
            glut32Path = $"\"{startupPath}\\game\\glut32.dll\"";
        }

        public void BuildGame(bool showConsole)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            if (!showConsole) process.StartInfo.CreateNoWindow = true;
            process.Start();

            process.StandardInput.WriteLine($"{compilerPath} -g {c_filePath} -o {outputPath}{gameName}.exe\" -lglu32 -lglut32 -lopengl32 -mwindows");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
        }
    }
}
