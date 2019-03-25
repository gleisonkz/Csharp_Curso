namespace datahora
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.label_dia = new System.Windows.Forms.Label();
            this.label_mes = new System.Windows.Forms.Label();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.label_ano = new System.Windows.Forms.Label();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(114, 178);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(387, 36);
            this.label_resultado.TabIndex = 1;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(144, 85);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(100, 20);
            this.tb_dia.TabIndex = 2;
            // 
            // label_dia
            // 
            this.label_dia.AutoSize = true;
            this.label_dia.Location = new System.Drawing.Point(144, 66);
            this.label_dia.Name = "label_dia";
            this.label_dia.Size = new System.Drawing.Size(23, 13);
            this.label_dia.TabIndex = 3;
            this.label_dia.Text = "Dia";
            // 
            // label_mes
            // 
            this.label_mes.AutoSize = true;
            this.label_mes.Location = new System.Drawing.Point(250, 66);
            this.label_mes.Name = "label_mes";
            this.label_mes.Size = new System.Drawing.Size(27, 13);
            this.label_mes.TabIndex = 5;
            this.label_mes.Text = "Mês";
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(250, 85);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(100, 20);
            this.tb_mes.TabIndex = 4;
            // 
            // label_ano
            // 
            this.label_ano.AutoSize = true;
            this.label_ano.Location = new System.Drawing.Point(356, 66);
            this.label_ano.Name = "label_ano";
            this.label_ano.Size = new System.Drawing.Size(26, 13);
            this.label_ano.TabIndex = 7;
            this.label_ano.Text = "Ano";
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(356, 85);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(100, 20);
            this.tb_ano.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "O dia da semana que você nasceu foi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Informe os dados abaixo para saber o dia da semana em que você nasceu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_ano);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.label_mes);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.label_dia);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.Label label_dia;
        private System.Windows.Forms.Label label_mes;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.Label label_ano;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

