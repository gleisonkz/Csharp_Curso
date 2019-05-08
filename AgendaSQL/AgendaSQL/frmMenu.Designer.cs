namespace AgendaSQL
{
    partial class frmMenu
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
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_adicionar = new System.Windows.Forms.Button();
            this.cmd_visualizar_tudo = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(116, 179);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(131, 43);
            this.cmd_pesquisar.TabIndex = 0;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            // 
            // label_titulo
            // 
            this.label_titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(89, 27);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(184, 39);
            this.label_titulo.TabIndex = 1;
            this.label_titulo.Text = "Agenda SQL";
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(116, 228);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(131, 43);
            this.cmd_sair.TabIndex = 2;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_adicionar
            // 
            this.cmd_adicionar.Location = new System.Drawing.Point(116, 130);
            this.cmd_adicionar.Name = "cmd_adicionar";
            this.cmd_adicionar.Size = new System.Drawing.Size(131, 43);
            this.cmd_adicionar.TabIndex = 3;
            this.cmd_adicionar.Text = "Adicionar";
            this.cmd_adicionar.UseVisualStyleBackColor = true;
            // 
            // cmd_visualizar_tudo
            // 
            this.cmd_visualizar_tudo.Location = new System.Drawing.Point(116, 81);
            this.cmd_visualizar_tudo.Name = "cmd_visualizar_tudo";
            this.cmd_visualizar_tudo.Size = new System.Drawing.Size(131, 43);
            this.cmd_visualizar_tudo.TabIndex = 4;
            this.cmd_visualizar_tudo.Text = "Visualizar Tudo";
            this.cmd_visualizar_tudo.UseVisualStyleBackColor = true;
            // 
            // label_versao
            // 
            this.label_versao.AutoSize = true;
            this.label_versao.Location = new System.Drawing.Point(162, 311);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(39, 13);
            this.label_versao.TabIndex = 5;
            this.label_versao.Text = "versao";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(363, 353);
            this.ControlBox = false;
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.cmd_visualizar_tudo);
            this.Controls.Add(this.cmd_adicionar);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.cmd_pesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_adicionar;
        private System.Windows.Forms.Button cmd_visualizar_tudo;
        private System.Windows.Forms.Label label_versao;
    }
}

