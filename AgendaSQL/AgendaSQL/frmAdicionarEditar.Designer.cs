namespace AgendaSQL
{
    partial class frmAdicionarEditar
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
            this.label_telefone = new System.Windows.Forms.Label();
            this.text_telefone = new System.Windows.Forms.TextBox();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_telefone
            // 
            this.label_telefone.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label_telefone.Location = new System.Drawing.Point(12, 69);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(83, 16);
            this.label_telefone.TabIndex = 4;
            this.label_telefone.Text = "Telefone:";
            // 
            // text_telefone
            // 
            this.text_telefone.Location = new System.Drawing.Point(12, 88);
            this.text_telefone.MaxLength = 8;
            this.text_telefone.Name = "text_telefone";
            this.text_telefone.Size = new System.Drawing.Size(100, 20);
            this.text_telefone.TabIndex = 1;
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Location = new System.Drawing.Point(235, 167);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(137, 41);
            this.cmd_gravar.TabIndex = 2;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(12, 46);
            this.text_nome.MaxLength = 50;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(185, 20);
            this.text_nome.TabIndex = 0;
            // 
            // label_nome
            // 
            this.label_nome.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label_nome.Location = new System.Drawing.Point(12, 27);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(83, 16);
            this.label_nome.TabIndex = 5;
            this.label_nome.Text = "Nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 224);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.text_telefone);
            this.Controls.Add(this.label_telefone);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarEditar";
            this.Load += new System.EventHandler(this.frmAdicionarEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.TextBox text_telefone;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Button button1;
    }
}