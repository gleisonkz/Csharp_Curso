namespace Enumeracoes
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmd_baixo = new System.Windows.Forms.Button();
            this.cmd_direita = new System.Windows.Forms.Button();
            this.cmd_cima = new System.Windows.Forms.Button();
            this.cmd_esquerda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_baixo
            // 
            this.cmd_baixo.Location = new System.Drawing.Point(237, 187);
            this.cmd_baixo.Name = "cmd_baixo";
            this.cmd_baixo.Size = new System.Drawing.Size(326, 77);
            this.cmd_baixo.TabIndex = 1;
            this.cmd_baixo.Text = "button2";
            this.cmd_baixo.UseVisualStyleBackColor = true;
            this.cmd_baixo.Click += new System.EventHandler(this.cmd_baixo_Click);
            // 
            // cmd_direita
            // 
            this.cmd_direita.Location = new System.Drawing.Point(415, 104);
            this.cmd_direita.Name = "cmd_direita";
            this.cmd_direita.Size = new System.Drawing.Size(326, 77);
            this.cmd_direita.TabIndex = 2;
            this.cmd_direita.Text = "button3";
            this.cmd_direita.UseVisualStyleBackColor = true;
            this.cmd_direita.Click += new System.EventHandler(this.cmd_direita_Click);
            // 
            // cmd_cima
            // 
            this.cmd_cima.Location = new System.Drawing.Point(226, 21);
            this.cmd_cima.Name = "cmd_cima";
            this.cmd_cima.Size = new System.Drawing.Size(326, 77);
            this.cmd_cima.TabIndex = 3;
            this.cmd_cima.Text = "button4";
            this.cmd_cima.UseVisualStyleBackColor = true;
            this.cmd_cima.Click += new System.EventHandler(this.cmd_cima_Click);
            // 
            // cmd_esquerda
            // 
            this.cmd_esquerda.Location = new System.Drawing.Point(58, 104);
            this.cmd_esquerda.Name = "cmd_esquerda";
            this.cmd_esquerda.Size = new System.Drawing.Size(326, 77);
            this.cmd_esquerda.TabIndex = 4;
            this.cmd_esquerda.Text = "button5";
            this.cmd_esquerda.UseVisualStyleBackColor = true;
            this.cmd_esquerda.Click += new System.EventHandler(this.cmd_esquerda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd_esquerda);
            this.Controls.Add(this.cmd_cima);
            this.Controls.Add(this.cmd_direita);
            this.Controls.Add(this.cmd_baixo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmd_baixo;
        private System.Windows.Forms.Button cmd_direita;
        private System.Windows.Forms.Button cmd_cima;
        private System.Windows.Forms.Button cmd_esquerda;
    }
}

