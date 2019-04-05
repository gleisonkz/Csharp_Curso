namespace Teste
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.cmd_executar = new System.Windows.Forms.Button();
            this.text_parcela_2 = new System.Windows.Forms.TextBox();
            this.text_parcela_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(36, 157);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(0, 13);
            this.label_resultado.TabIndex = 0;
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(39, 208);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 3;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // text_parcela_2
            // 
            this.text_parcela_2.Location = new System.Drawing.Point(39, 84);
            this.text_parcela_2.Name = "text_parcela_2";
            this.text_parcela_2.Size = new System.Drawing.Size(100, 20);
            this.text_parcela_2.TabIndex = 2;
            // 
            // text_parcela_1
            // 
            this.text_parcela_1.Location = new System.Drawing.Point(39, 58);
            this.text_parcela_1.Name = "text_parcela_1";
            this.text_parcela_1.Size = new System.Drawing.Size(100, 20);
            this.text_parcela_1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_parcela_1);
            this.Controls.Add(this.text_parcela_2);
            this.Controls.Add(this.cmd_executar);
            this.Controls.Add(this.label_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.TextBox text_parcela_2;
        private System.Windows.Forms.TextBox text_parcela_1;
    }
}

