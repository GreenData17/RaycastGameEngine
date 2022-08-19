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
    public partial class Form1 : Form
    {
        private ctrl_import ImportCtrl;

        public Form1()
        {
            InitializeComponent();
            new Manager(Application.StartupPath);

            // prepare pages
            var compileCtrl = new ctrl_Compiller();
            tab_compile.Controls.Add(compileCtrl);
            compileCtrl.Dock = DockStyle.Fill;

            ImportCtrl = new ctrl_import();
            tab_import.Controls.Add(ImportCtrl);
            ImportCtrl.Dock = DockStyle.Fill;
            tab_import.Click += Tab_import_Click;
        }

        private void Tab_import_Click(object sender, EventArgs e)
        {
            ImportCtrl = new ctrl_import();
        }
    }
}
