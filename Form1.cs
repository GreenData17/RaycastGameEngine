using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaycastGameEngine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Manager(Application.StartupPath);
            label1.Text = $"{Application.StartupPath}";
            label2.Text = Manager.instance.compilerPath;
            label3.Text = Manager.instance.c_filePath;
            label4.Text = $"{Manager.instance.outputPath}{Manager.instance.gameName}.exe\"";
            BuildProgress.Text = "UnBuild";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuildProgress.Text = "Building...";
            Manager.instance.BuildGame(true);
            BuildProgress.Text = "Build!";
        }
    }
}
