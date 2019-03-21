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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_executar = new System.Windows.Forms.Button();
            this.mnu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_new_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_eidt_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file,
            this.mnu_edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // mnu_file
            // 
            this.mnu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file_new,
            this.mnu_file_open,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.mnu_file.Name = "mnu_file";
            this.mnu_file.Size = new System.Drawing.Size(37, 20);
            this.mnu_file.Text = "File";
            // 
            // mnu_edit
            // 
            this.mnu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_eidt_copy});
            this.mnu_edit.Name = "mnu_edit";
            this.mnu_edit.Size = new System.Drawing.Size(39, 20);
            this.mnu_edit.Text = "Edit";
            // 
            // mnu_file_new
            // 
            this.mnu_file_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file_new_open});
            this.mnu_file_new.Name = "mnu_file_new";
            this.mnu_file_new.Size = new System.Drawing.Size(180, 22);
            this.mnu_file_new.Text = "New";
            // 
            // mnu_file_open
            // 
            this.mnu_file_open.Name = "mnu_file_open";
            this.mnu_file_open.Size = new System.Drawing.Size(180, 22);
            this.mnu_file_open.Text = "Open";
            // 
            // mnu_file_new_open
            // 
            this.mnu_file_new_open.Name = "mnu_file_new_open";
            this.mnu_file_new_open.Size = new System.Drawing.Size(180, 22);
            this.mnu_file_new_open.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnu_eidt_copy
            // 
            this.mnu_eidt_copy.Name = "mnu_eidt_copy";
            this.mnu_eidt_copy.Size = new System.Drawing.Size(180, 22);
            this.mnu_eidt_copy.Text = "Copy";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 324);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_file_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_file_new_open;
        private System.Windows.Forms.ToolStripMenuItem mnu_file_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_edit;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.ToolStripMenuItem mnu_eidt_copy;
    }
}

