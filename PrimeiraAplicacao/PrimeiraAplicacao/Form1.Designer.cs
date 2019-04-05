namespace PrimeiraAplicacao
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
            this.caixa_texto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.caixa_texto.Location = new System.Drawing.Point(56, 50);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(504, 41);
            this.caixa_texto.TabIndex = 0;
            this.caixa_texto.Text = "texto de exemplo";
            // 
            // btn_executar
            // 
            this.btn_executar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_executar.Location = new System.Drawing.Point(386, 256);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(233, 58);
            this.btn_executar.TabIndex = 1;
            this.btn_executar.Text = "Excecutar";
            this.btn_executar.UseVisualStyleBackColor = false;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 326);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.caixa_texto);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label caixa_texto;
        private System.Windows.Forms.Button btn_executar;
    }
}

