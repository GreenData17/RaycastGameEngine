using System;
using System.IO;
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
    public partial class ctrl_import : UserControl
    {
        private string m_filename;
        private string m_filePath;

        private List<PictureBox> m_images = new List<PictureBox>();

        public ctrl_import()
        {
            InitializeComponent();
            DrawImages();
        }

        private void btt_import_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            m_filename = openFileDialog.SafeFileName;
            m_filePath = openFileDialog.FileName;

            File.Copy(m_filePath, Manager.instance.assetsPath + "\\" + m_filename);

            // Create a readable file

            Manager.instance.GenerateImageppm(m_filePath, m_filename);
        }

        private void DrawImages()
        {
            string[] files = Directory.GetFiles(Manager.instance.assetsPath);

            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];

                if (file.EndsWith(".ppm")) continue;

                var picture = new PictureBox();
                picture.Image = Bitmap.FromFile(file);
                picture.Location = new Point(3 + (i*17), 32);
                picture.Size = picture.PreferredSize;
                picture.BringToFront();
                this.Controls.Add(picture);
            }
        }
    }
}
