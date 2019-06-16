namespace GestorBD
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnInsertItem = new System.Windows.Forms.Button();
            this.TextBoxInsertNome = new System.Windows.Forms.TextBox();
            this.TextBoxInsertTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCriarDataTable = new System.Windows.Forms.Button();
            this.BtnInsertBatch = new System.Windows.Forms.Button();
            this.BtnCompactar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSelectClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Criar Base de Dados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnCriarBaseDeDadosClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Insert/Update/Delete/CreateTable";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnInsertItem
            // 
            this.BtnInsertItem.Location = new System.Drawing.Point(272, 109);
            this.BtnInsertItem.Name = "BtnInsertItem";
            this.BtnInsertItem.Size = new System.Drawing.Size(210, 51);
            this.BtnInsertItem.TabIndex = 4;
            this.BtnInsertItem.Text = "Insert";
            this.BtnInsertItem.UseVisualStyleBackColor = true;
            this.BtnInsertItem.Click += new System.EventHandler(this.BtnInsertItem_Click);
            // 
            // TextBoxInsertNome
            // 
            this.TextBoxInsertNome.Location = new System.Drawing.Point(272, 35);
            this.TextBoxInsertNome.Name = "TextBoxInsertNome";
            this.TextBoxInsertNome.Size = new System.Drawing.Size(210, 20);
            this.TextBoxInsertNome.TabIndex = 5;
            // 
            // TextBoxInsertTelefone
            // 
            this.TextBoxInsertTelefone.Location = new System.Drawing.Point(272, 78);
            this.TextBoxInsertTelefone.Name = "TextBoxInsertTelefone";
            this.TextBoxInsertTelefone.Size = new System.Drawing.Size(210, 20);
            this.TextBoxInsertTelefone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefone";
            // 
            // BtnCriarDataTable
            // 
            this.BtnCriarDataTable.Location = new System.Drawing.Point(511, 109);
            this.BtnCriarDataTable.Name = "BtnCriarDataTable";
            this.BtnCriarDataTable.Size = new System.Drawing.Size(210, 51);
            this.BtnCriarDataTable.TabIndex = 9;
            this.BtnCriarDataTable.Text = "CriaDataTable";
            this.BtnCriarDataTable.UseVisualStyleBackColor = true;
            this.BtnCriarDataTable.Click += new System.EventHandler(this.BtnCriarDataTable_Click);
            // 
            // BtnInsertBatch
            // 
            this.BtnInsertBatch.Location = new System.Drawing.Point(741, 109);
            this.BtnInsertBatch.Name = "BtnInsertBatch";
            this.BtnInsertBatch.Size = new System.Drawing.Size(210, 51);
            this.BtnInsertBatch.TabIndex = 10;
            this.BtnInsertBatch.Text = "InsertBatch";
            this.BtnInsertBatch.UseVisualStyleBackColor = true;
            this.BtnInsertBatch.Click += new System.EventHandler(this.BtnInsertBatch_Click);
            // 
            // BtnCompactar
            // 
            this.BtnCompactar.Location = new System.Drawing.Point(741, 177);
            this.BtnCompactar.Name = "BtnCompactar";
            this.BtnCompactar.Size = new System.Drawing.Size(210, 51);
            this.BtnCompactar.TabIndex = 11;
            this.BtnCompactar.Text = "Compactar";
            this.BtnCompactar.UseVisualStyleBackColor = true;
            this.BtnCompactar.Click += new System.EventHandler(this.BtnCompactar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 436);
            this.Controls.Add(this.BtnCompactar);
            this.Controls.Add(this.BtnInsertBatch);
            this.Controls.Add(this.BtnCriarDataTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxInsertTelefone);
            this.Controls.Add(this.TextBoxInsertNome);
            this.Controls.Add(this.BtnInsertItem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnInsertItem;
        private System.Windows.Forms.TextBox TextBoxInsertNome;
        private System.Windows.Forms.TextBox TextBoxInsertTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCriarDataTable;
        private System.Windows.Forms.Button BtnInsertBatch;
        private System.Windows.Forms.Button BtnCompactar;
    }
}

