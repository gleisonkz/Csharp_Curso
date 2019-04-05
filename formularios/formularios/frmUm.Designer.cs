namespace formularios
{
    partial class frmUm
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
            this.label_resultado_final = new System.Windows.Forms.Label();
            this.cmd_copiar = new System.Windows.Forms.Button();
            this.label_copia = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(70, 206);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(154, 39);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label_resultado_final
            // 
            this.label_resultado_final.AutoSize = true;
            this.label_resultado_final.Location = new System.Drawing.Point(12, 9);
            this.label_resultado_final.Name = "label_resultado_final";
            this.label_resultado_final.Size = new System.Drawing.Size(35, 13);
            this.label_resultado_final.TabIndex = 2;
            this.label_resultado_final.Text = "label1";
            this.label_resultado_final.Click += new System.EventHandler(this.label_resultado_final_Click);
            // 
            // cmd_copiar
            // 
            this.cmd_copiar.Location = new System.Drawing.Point(70, 161);
            this.cmd_copiar.Name = "cmd_copiar";
            this.cmd_copiar.Size = new System.Drawing.Size(154, 39);
            this.cmd_copiar.TabIndex = 3;
            this.cmd_copiar.Text = "Copiar";
            this.cmd_copiar.UseVisualStyleBackColor = true;
            this.cmd_copiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_copia
            // 
            this.label_copia.AutoSize = true;
            this.label_copia.Location = new System.Drawing.Point(12, 104);
            this.label_copia.Name = "label_copia";
            this.label_copia.Size = new System.Drawing.Size(35, 13);
            this.label_copia.TabIndex = 4;
            this.label_copia.Text = "label1";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(230, 161);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(154, 39);
            this.cmd_apagar.TabIndex = 5;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // frmUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 298);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_copia);
            this.Controls.Add(this.cmd_copiar);
            this.Controls.Add(this.label_resultado_final);
            this.Controls.Add(this.cmd_fechar);
            this.Name = "frmUm";
            this.Text = "frmUm";
            this.Load += new System.EventHandler(this.frmUm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label_resultado_final;
        private System.Windows.Forms.Button cmd_copiar;
        private System.Windows.Forms.Label label_copia;
        private System.Windows.Forms.Button cmd_apagar;
    }
}