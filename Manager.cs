using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RaycastGameEngine
{
    public class Manager
    {
        public static Manager instance;

        // compiling paths
        public string compilerPath;
        public string c_filePath;
        public string outputPath;
        public string glut32Path;

        // engine paths
        public string assetsPath;
        public string compilePath;

        // game infos
        public string gameName = "game";

        public Manager(string startupPath)
        {
            if(instance is null) instance = this;

            compilerPath = $"\"{startupPath}\\game\\mingw32\\bin\\gcc.exe\"";
            c_filePath = $"\"{startupPath}\\game\\main.c\"";
            outputPath = $"\"{startupPath}\\game\\";
            glut32Path = $"\"{startupPath}\\game\\glut32.dll\"";

            assetsPath = $"{startupPath}\\assets";
            compilePath = $"{startupPath}\\compile";

            // prepare folders
            if (!Directory.Exists(assetsPath))
                Directory.CreateDirectory(assetsPath);

            if (!Directory.Exists(compilePath))
                Directory.CreateDirectory(compilePath);
        }

        public void BuildGame(bool showConsole, RichTextBox textbox)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            if (!showConsole) process.StartInfo.CreateNoWindow = true;
            process.Start();

            process.StandardInput.WriteLine($"{compilerPath} -g {c_filePath} -o {outputPath}{gameName}.exe\" -lglu32 -lglut32 -lopengl32 -mwindows");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            textbox.Text = process.StandardOutput.ReadToEnd();
        }

        public void GenerateImageppm(string filePath, string fileName)
        {
            List<string> pixels = new List<string>();

            fileName = fileName.Replace(".png", "");
            fileName = fileName.Replace(" ", "_");

            Bitmap image = Bitmap.FromFile(filePath) as Bitmap;


            pixels.Add($"int {fileName}[]={{");
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    pixels.Add($"{image.GetPixel(x, y).R},");
                    pixels.Add($"{image.GetPixel(x, y).G},");
                    pixels.Add($"{image.GetPixel(x, y).B},");
                }
            }
            pixels.Add("};");


            File.WriteAllLines(assetsPath + "\\" + fileName + ".ppm", pixels);
        }

        public void ReGenerateImageppm()
        {
            foreach(string file in Directory.GetFiles(assetsPath))
            {
                if (file.EndsWith(".png")) continue;
                File.Delete(file);
            }

            foreach(string file in Directory.GetFiles(assetsPath))
            {
                FileInfo info = new FileInfo(file);
                GenerateImageppm(info.FullName, info.Name);
            }
        }
    }
}
