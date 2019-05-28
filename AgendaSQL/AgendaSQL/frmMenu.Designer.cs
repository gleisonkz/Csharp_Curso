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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnAdicionarEditar = new System.Windows.Forms.Button();
            this.BtnVisualizarTudo = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.BtnApagarBaseDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(116, 164);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(131, 43);
            this.BtnPesquisar.TabIndex = 2;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisarClick);
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
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(116, 262);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(131, 43);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSairClick);
            // 
            // BtnAdicionarEditar
            // 
            this.BtnAdicionarEditar.Location = new System.Drawing.Point(116, 115);
            this.BtnAdicionarEditar.Name = "BtnAdicionarEditar";
            this.BtnAdicionarEditar.Size = new System.Drawing.Size(131, 43);
            this.BtnAdicionarEditar.TabIndex = 1;
            this.BtnAdicionarEditar.Text = "Adicionar / Editar";
            this.BtnAdicionarEditar.UseVisualStyleBackColor = true;
            this.BtnAdicionarEditar.Click += new System.EventHandler(this.BtnAdicionarClick);
            // 
            // BtnVisualizarTudo
            // 
            this.BtnVisualizarTudo.Location = new System.Drawing.Point(116, 66);
            this.BtnVisualizarTudo.Name = "BtnVisualizarTudo";
            this.BtnVisualizarTudo.Size = new System.Drawing.Size(131, 43);
            this.BtnVisualizarTudo.TabIndex = 0;
            this.BtnVisualizarTudo.Text = "Visualizar Tudo";
            this.BtnVisualizarTudo.UseVisualStyleBackColor = true;
            this.BtnVisualizarTudo.Click += new System.EventHandler(this.BtnVisualizarTudoClick);
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
            // BtnApagarBaseDados
            // 
            this.BtnApagarBaseDados.Location = new System.Drawing.Point(116, 213);
            this.BtnApagarBaseDados.Name = "BtnApagarBaseDados";
            this.BtnApagarBaseDados.Size = new System.Drawing.Size(131, 43);
            this.BtnApagarBaseDados.TabIndex = 6;
            this.BtnApagarBaseDados.Text = "Apagar Base de Dados";
            this.BtnApagarBaseDados.UseVisualStyleBackColor = true;
            this.BtnApagarBaseDados.Click += new System.EventHandler(this.BtnApagarBaseDados_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(363, 353);
            this.ControlBox = false;
            this.Controls.Add(this.BtnApagarBaseDados);
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.BtnVisualizarTudo);
            this.Controls.Add(this.BtnAdicionarEditar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.BtnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.FrmMenuLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnAdicionarEditar;
        private System.Windows.Forms.Button BtnVisualizarTudo;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.Button BtnApagarBaseDados;
    }
}

