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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(116, 164);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(131, 43);
            this.cmd_pesquisar.TabIndex = 2;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // label_titulo
            // 
            this.label_titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(89, 27);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(184, 39);
            this.label_titulo.TabIndex = 5;
            this.label_titulo.Text = "Agenda SQL";
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(116, 262);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(131, 43);
            this.cmd_sair.TabIndex = 3;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_adicionar
            // 
            this.cmd_adicionar.Location = new System.Drawing.Point(116, 115);
            this.cmd_adicionar.Name = "cmd_adicionar";
            this.cmd_adicionar.Size = new System.Drawing.Size(131, 43);
            this.cmd_adicionar.TabIndex = 1;
            this.cmd_adicionar.Text = "Adicionar / Editar";
            this.cmd_adicionar.UseVisualStyleBackColor = true;
            this.cmd_adicionar.Click += new System.EventHandler(this.cmd_adicionar_Click);
            // 
            // cmd_visualizar_tudo
            // 
            this.cmd_visualizar_tudo.Location = new System.Drawing.Point(116, 66);
            this.cmd_visualizar_tudo.Name = "cmd_visualizar_tudo";
            this.cmd_visualizar_tudo.Size = new System.Drawing.Size(131, 43);
            this.cmd_visualizar_tudo.TabIndex = 0;
            this.cmd_visualizar_tudo.Text = "Visualizar Tudo";
            this.cmd_visualizar_tudo.UseVisualStyleBackColor = true;
            this.cmd_visualizar_tudo.Click += new System.EventHandler(this.cmd_visualizar_tudo_Click);
            // 
            // label_versao
            // 
            this.label_versao.AutoSize = true;
            this.label_versao.Location = new System.Drawing.Point(162, 311);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(39, 13);
            this.label_versao.TabIndex = 4;
            this.label_versao.Text = "versao";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apagar Base de Dados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(363, 353);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

