using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaycastGameEngine
{
    public partial class ctrl_Compiller : UserControl
    {
        public ctrl_Compiller()
        {
            InitializeComponent();
            richTextBox1.Visible = false;
            label1.Text = "waiting...";
            label2.Text = "waiting...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Building...";
            label1.ForeColor = Color.Blue;
            Manager.instance.BuildGame(false, richTextBox1);
            label1.Text = "Build!";
            label1.ForeColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Regenerating...";
            label2.ForeColor = Color.Blue;
            Manager.instance.ReGenerateImageppm();
            label2.Text = "generated!";
            label2.ForeColor = Color.Green;
        }
    }
}
