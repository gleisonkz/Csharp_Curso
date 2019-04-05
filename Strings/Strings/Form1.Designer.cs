namespace Strings
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
            this.caixa_texto = new System.Windows.Forms.Label();
            this.btn_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caixa_texto
            // 
            this.caixa_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_texto.Location = new System.Drawing.Point(12, 9);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(776, 101);
            this.caixa_texto.TabIndex = 0;
            this.caixa_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_executar
            // 
            this.btn_executar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_executar.Location = new System.Drawing.Point(546, 131);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(242, 44);
            this.btn_executar.TabIndex = 1;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = false;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 189);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.caixa_texto);
            this.Name = "Form1";
            this.Text = "Strings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label caixa_texto;
        private System.Windows.Forms.Button btn_executar;
    }
}

