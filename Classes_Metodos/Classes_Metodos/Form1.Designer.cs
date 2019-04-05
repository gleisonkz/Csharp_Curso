namespace Classes_Metodos
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
            this.btn_executar = new System.Windows.Forms.Button();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.label_adicao = new System.Windows.Forms.Label();
            this.label_subtracao = new System.Windows.Forms.Label();
            this.label_divisao = new System.Windows.Forms.Label();
            this.label_multiplicacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(48, 114);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(224, 48);
            this.btn_executar.TabIndex = 2;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Location = new System.Drawing.Point(156, 76);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(70, 20);
            this.textBox_valor2.TabIndex = 1;
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.Location = new System.Drawing.Point(80, 76);
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(70, 20);
            this.textBox_valor1.TabIndex = 0;
            // 
            // label_adicao
            // 
            this.label_adicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_adicao.Location = new System.Drawing.Point(398, 28);
            this.label_adicao.Name = "label_adicao";
            this.label_adicao.Size = new System.Drawing.Size(100, 23);
            this.label_adicao.TabIndex = 3;
            this.label_adicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_adicao.Click += new System.EventHandler(this.label_adicao_Click);
            // 
            // label_subtracao
            // 
            this.label_subtracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_subtracao.Location = new System.Drawing.Point(398, 65);
            this.label_subtracao.Name = "label_subtracao";
            this.label_subtracao.Size = new System.Drawing.Size(100, 23);
            this.label_subtracao.TabIndex = 4;
            this.label_subtracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_divisao
            // 
            this.label_divisao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_divisao.Location = new System.Drawing.Point(398, 104);
            this.label_divisao.Name = "label_divisao";
            this.label_divisao.Size = new System.Drawing.Size(100, 23);
            this.label_divisao.TabIndex = 5;
            this.label_divisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_multiplicacao
            // 
            this.label_multiplicacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_multiplicacao.Location = new System.Drawing.Point(398, 139);
            this.label_multiplicacao.Name = "label_multiplicacao";
            this.label_multiplicacao.Size = new System.Drawing.Size(100, 23);
            this.label_multiplicacao.TabIndex = 6;
            this.label_multiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informe os valores abaixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Subtracao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Divisão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Multiplicacao";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 218);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_multiplicacao);
            this.Controls.Add(this.label_divisao);
            this.Controls.Add(this.label_subtracao);
            this.Controls.Add(this.label_adicao);
            this.Controls.Add(this.textBox_valor1);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Classes_Metodos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.Label label_adicao;
        private System.Windows.Forms.Label label_subtracao;
        private System.Windows.Forms.Label label_divisao;
        private System.Windows.Forms.Label label_multiplicacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

