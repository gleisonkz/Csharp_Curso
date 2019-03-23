namespace Menus
{
    partial class frm_principal
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
            this.menu_geral = new System.Windows.Forms.MenuStrip();
            this.mnu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_executar = new System.Windows.Forms.Button();
            this.mnu_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menu_geral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_geral
            // 
            this.menu_geral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file,
            this.mnu_edit,
            this.toolStripComboBox1});
            this.menu_geral.Location = new System.Drawing.Point(0, 0);
            this.menu_geral.Name = "menu_geral";
            this.menu_geral.Size = new System.Drawing.Size(572, 27);
            this.menu_geral.TabIndex = 0;
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
            // mnu_new_project
            // 
            this.mnu_new_project.Name = "mnu_new_project";
            this.mnu_new_project.Size = new System.Drawing.Size(180, 22);
            this.mnu_new_project.Text = "Project";
            // 
            // mnu_open
            // 
            this.mnu_open.Name = "mnu_open";
            this.mnu_open.Size = new System.Drawing.Size(180, 22);
            this.mnu_open.Text = "Open";
            this.mnu_open.Click += new System.EventHandler(this.mnu_open_Click);
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
            this.mnu_exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnu_edit
            // 
            this.mnu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_copy,
            this.mnu_paste,
            this.toolStripSeparator2,
            this.propertiesToolStripMenuItem});
            this.mnu_edit.Name = "mnu_edit";
            this.mnu_edit.Size = new System.Drawing.Size(39, 23);
            this.mnu_edit.Text = "Edit";
            // 
            // mnu_copy
            // 
            this.mnu_copy.Name = "mnu_copy";
            this.mnu_copy.Size = new System.Drawing.Size(180, 22);
            this.mnu_copy.Text = "Copy";
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(403, 267);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(157, 45);
            this.btn_executar.TabIndex = 1;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // mnu_new_file
            // 
            this.mnu_new_file.Name = "mnu_new_file";
            this.mnu_new_file.Size = new System.Drawing.Size(180, 22);
            this.mnu_new_file.Text = "File";
            // 
            // mnu_paste
            // 
            this.mnu_paste.Name = "mnu_paste";
            this.mnu_paste.Size = new System.Drawing.Size(180, 22);
            this.mnu_paste.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.propertiesToolStripMenuItem.Text = "Properties...";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 324);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.menu_geral);
            this.MainMenuStrip = this.menu_geral;
            this.Name = "frm_principal";
            this.Text = "Form1";
            this.menu_geral.ResumeLayout(false);
            this.menu_geral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_geral;
        private System.Windows.Forms.ToolStripMenuItem mnu_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_new_project;
        private System.Windows.Forms.ToolStripMenuItem mnu_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_edit;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.ToolStripMenuItem mnu_copy;
        private System.Windows.Forms.ToolStripMenuItem mnu_new_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

