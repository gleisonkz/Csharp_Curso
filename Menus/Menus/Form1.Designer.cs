namespace Menus
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
            this.button1 = new System.Windows.Forms.Button();
            this.menu_geral = new System.Windows.Forms.MenuStrip();
            this.mnu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_geral.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu_geral
            // 
            this.menu_geral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file});
            this.menu_geral.Location = new System.Drawing.Point(0, 0);
            this.menu_geral.Name = "menu_geral";
            this.menu_geral.Size = new System.Drawing.Size(611, 24);
            this.menu_geral.TabIndex = 1;
            this.menu_geral.Text = "menuStrip1";
            // 
            // mnu_file
            // 
            this.mnu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_new,
            this.mnu_open,
            this.toolStripSeparator1,
            this.mnu_exit});
            this.mnu_file.Name = "mnu_file";
            this.mnu_file.Size = new System.Drawing.Size(37, 20);
            this.mnu_file.Text = "File";
            // 
            // mnu_new
            // 
            this.mnu_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_new_project,
            this.mnu_new_file});
            this.mnu_new.Name = "mnu_new";
            this.mnu_new.Size = new System.Drawing.Size(180, 22);
            this.mnu_new.Text = "New";
            // 
            // mnu_open
            // 
            this.mnu_open.Name = "mnu_open";
            this.mnu_open.Size = new System.Drawing.Size(180, 22);
            this.mnu_open.Text = "Open";
            // 
            // mnu_new_project
            // 
            this.mnu_new_project.Name = "mnu_new_project";
            this.mnu_new_project.Size = new System.Drawing.Size(180, 22);
            this.mnu_new_project.Text = "Project";
            // 
            // mnu_new_file
            // 
            this.mnu_new_file.Name = "mnu_new_file";
            this.mnu_new_file.Size = new System.Drawing.Size(180, 22);
            this.mnu_new_file.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnu_exit
            // 
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnu_exit.Size = new System.Drawing.Size(180, 22);
            this.mnu_exit.Text = "Exit";
            this.mnu_exit.Click += new System.EventHandler(this.mnu_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menu_geral);
            this.MainMenuStrip = this.menu_geral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu_geral.ResumeLayout(false);
            this.menu_geral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menu_geral;
        private System.Windows.Forms.ToolStripMenuItem mnu_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_open;
        private System.Windows.Forms.ToolStripMenuItem mnu_new_project;
        private System.Windows.Forms.ToolStripMenuItem mnu_new_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_exit;
    }
}

