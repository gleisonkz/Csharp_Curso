namespace AgendaSQL
{
    partial class frmResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultados));
            this.BtnFechar = new System.Windows.Forms.Button();
            this.grid_resultados = new System.Windows.Forms.DataGridView();
            this.label_registros = new System.Windows.Forms.Label();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnVerTudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(428, 315);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(93, 32);
            this.BtnFechar.TabIndex = 0;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFecharClick);
            // 
            // grid_resultados
            // 
            this.grid_resultados.AllowUserToAddRows = false;
            this.grid_resultados.AllowUserToDeleteRows = false;
            this.grid_resultados.AllowUserToResizeRows = false;
            this.grid_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_resultados.Location = new System.Drawing.Point(12, 12);
            this.grid_resultados.MultiSelect = false;
            this.grid_resultados.Name = "grid_resultados";
            this.grid_resultados.ReadOnly = true;
            this.grid_resultados.RowHeadersVisible = false;
            this.grid_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_resultados.Size = new System.Drawing.Size(509, 297);
            this.grid_resultados.TabIndex = 1;
            this.grid_resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResultadosCellClick);
            // 
            // label_registros
            // 
            this.label_registros.AutoSize = true;
            this.label_registros.Location = new System.Drawing.Point(12, 312);
            this.label_registros.Name = "label_registros";
            this.label_registros.Size = new System.Drawing.Size(35, 13);
            this.label_registros.TabIndex = 2;
            this.label_registros.Text = "label1";
            // 
            // BtnApagar
            // 
            this.BtnApagar.Enabled = false;
            this.BtnApagar.Location = new System.Drawing.Point(329, 315);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(93, 32);
            this.BtnApagar.TabIndex = 3;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagarClick);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Enabled = false;
            this.BtnEditar.Location = new System.Drawing.Point(230, 315);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(93, 32);
            this.BtnEditar.TabIndex = 4;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditarClick);
            // 
            // BtnVerTudo
            // 
            this.BtnVerTudo.Location = new System.Drawing.Point(131, 315);
            this.BtnVerTudo.Name = "BtnVerTudo";
            this.BtnVerTudo.Size = new System.Drawing.Size(93, 32);
            this.BtnVerTudo.TabIndex = 5;
            this.BtnVerTudo.Text = "Ver Tudo";
            this.BtnVerTudo.UseVisualStyleBackColor = true;
            this.BtnVerTudo.Click += new System.EventHandler(this.BtnVerTudoClick);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 368);
            this.ControlBox = false;
            this.Controls.Add(this.BtnVerTudo);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.label_registros);
            this.Controls.Add(this.grid_resultados);
            this.Controls.Add(this.BtnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResultados";
            this.Load += new System.EventHandler(this.FrmResultadosLoad);
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridView grid_resultados;
        private System.Windows.Forms.Label label_registros;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnVerTudo;
    }
}