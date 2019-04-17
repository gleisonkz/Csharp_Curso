namespace CalculadoraSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.text_operacao = new System.Windows.Forms.TextBox();
            this.label_algoritmo = new System.Windows.Forms.Label();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.Location = new System.Drawing.Point(151, 86);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(89, 34);
            this.cmd_calcular.TabIndex = 1;
            this.cmd_calcular.Text = "Calcular";
            this.cmd_calcular.UseVisualStyleBackColor = true;
            this.cmd_calcular.Click += new System.EventHandler(this.cmd_calcular_Click);
            // 
            // text_operacao
            // 
            this.text_operacao.Location = new System.Drawing.Point(36, 60);
            this.text_operacao.MaxLength = 30;
            this.text_operacao.Name = "text_operacao";
            this.text_operacao.Size = new System.Drawing.Size(204, 20);
            this.text_operacao.TabIndex = 0;
            this.text_operacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_operacao_KeyDown);
            // 
            // label_algoritmo
            // 
            this.label_algoritmo.AutoSize = true;
            this.label_algoritmo.Location = new System.Drawing.Point(33, 44);
            this.label_algoritmo.Name = "label_algoritmo";
            this.label_algoritmo.Size = new System.Drawing.Size(100, 13);
            this.label_algoritmo.TabIndex = 3;
            this.label_algoritmo.Text = "Escreva o algoritmo";
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(36, 86);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(89, 34);
            this.cmd_sair.TabIndex = 2;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 151);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.label_algoritmo);
            this.Controls.Add(this.text_operacao);
            this.Controls.Add(this.cmd_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.TextBox text_operacao;
        private System.Windows.Forms.Label label_algoritmo;
        private System.Windows.Forms.Button cmd_sair;
    }
}

