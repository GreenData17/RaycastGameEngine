
namespace RaycastGameEngine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_map = new System.Windows.Forms.TabPage();
            this.tab_entities = new System.Windows.Forms.TabPage();
            this.tab_compile = new System.Windows.Forms.TabPage();
            this.tab_import = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_map);
            this.tabControl1.Controls.Add(this.tab_entities);
            this.tabControl1.Controls.Add(this.tab_import);
            this.tabControl1.Controls.Add(this.tab_compile);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_map
            // 
            this.tab_map.Location = new System.Drawing.Point(4, 22);
            this.tab_map.Name = "tab_map";
            this.tab_map.Padding = new System.Windows.Forms.Padding(3);
            this.tab_map.Size = new System.Drawing.Size(476, 435);
            this.tab_map.TabIndex = 0;
            this.tab_map.Text = "Map";
            this.tab_map.UseVisualStyleBackColor = true;
            // 
            // tab_entities
            // 
            this.tab_entities.Location = new System.Drawing.Point(4, 22);
            this.tab_entities.Name = "tab_entities";
            this.tab_entities.Padding = new System.Windows.Forms.Padding(3);
            this.tab_entities.Size = new System.Drawing.Size(476, 435);
            this.tab_entities.TabIndex = 1;
            this.tab_entities.Text = "Entities";
            this.tab_entities.UseVisualStyleBackColor = true;
            // 
            // tab_compile
            // 
            this.tab_compile.Location = new System.Drawing.Point(4, 22);
            this.tab_compile.Name = "tab_compile";
            this.tab_compile.Size = new System.Drawing.Size(476, 435);
            this.tab_compile.TabIndex = 2;
            this.tab_compile.Text = "Compilling";
            this.tab_compile.UseVisualStyleBackColor = true;
            // 
            // tab_import
            // 
            this.tab_import.Location = new System.Drawing.Point(4, 22);
            this.tab_import.Name = "tab_import";
            this.tab_import.Size = new System.Drawing.Size(476, 435);
            this.tab_import.TabIndex = 3;
            this.tab_import.Text = "Import";
            this.tab_import.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RaycastGameEngine";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_map;
        private System.Windows.Forms.TabPage tab_entities;
        private System.Windows.Forms.TabPage tab_compile;
        private System.Windows.Forms.TabPage tab_import;
    }
}

