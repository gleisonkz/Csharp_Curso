namespace Agenda
{
    partial class frmResultado
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
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.cmd_nova_pesquisa = new System.Windows.Forms.Button();
            this.lista_resultado_pesquisa = new System.Windows.Forms.ListBox();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(336, 131);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(131, 43);
            this.cmd_fechar.TabIndex = 0;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // cmd_nova_pesquisa
            // 
            this.cmd_nova_pesquisa.Location = new System.Drawing.Point(199, 131);
            this.cmd_nova_pesquisa.Name = "cmd_nova_pesquisa";
            this.cmd_nova_pesquisa.Size = new System.Drawing.Size(131, 43);
            this.cmd_nova_pesquisa.TabIndex = 1;
            this.cmd_nova_pesquisa.Text = "Nova Pesquisa...";
            this.cmd_nova_pesquisa.UseVisualStyleBackColor = true;
            this.cmd_nova_pesquisa.Click += new System.EventHandler(this.cmd_nova_pesquisa_Click);
            // 
            // lista_resultado_pesquisa
            // 
            this.lista_resultado_pesquisa.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_resultado_pesquisa.FormattingEnabled = true;
            this.lista_resultado_pesquisa.ItemHeight = 14;
            this.lista_resultado_pesquisa.Location = new System.Drawing.Point(12, 12);
            this.lista_resultado_pesquisa.Name = "lista_resultado_pesquisa";
            this.lista_resultado_pesquisa.Size = new System.Drawing.Size(455, 116);
            this.lista_resultado_pesquisa.TabIndex = 2;
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.Location = new System.Drawing.Point(9, 136);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(135, 23);
            this.label_numero_registros.TabIndex = 8;
            this.label_numero_registros.Text = "Qtd Registros: 0";
            this.label_numero_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 178);
            this.ControlBox = false;
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.lista_resultado_pesquisa);
            this.Controls.Add(this.cmd_nova_pesquisa);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTADOS";
            this.Load += new System.EventHandler(this.frmResultado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Button cmd_nova_pesquisa;
        private System.Windows.Forms.ListBox lista_resultado_pesquisa;
        private System.Windows.Forms.Label label_numero_registros;
    }
}