namespace LigacaoBD
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
            this.btn_select = new System.Windows.Forms.Button();
            this.lista_dados = new System.Windows.Forms.ListBox();
            this.text_bd = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_morada = new System.Windows.Forms.Label();
            this.tb_morada = new System.Windows.Forms.TextBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(629, 68);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(159, 55);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lista_dados
            // 
            this.lista_dados.FormattingEnabled = true;
            this.lista_dados.Location = new System.Drawing.Point(12, 66);
            this.lista_dados.Name = "lista_dados";
            this.lista_dados.Size = new System.Drawing.Size(611, 238);
            this.lista_dados.TabIndex = 3;
            // 
            // text_bd
            // 
            this.text_bd.Location = new System.Drawing.Point(12, 30);
            this.text_bd.Name = "text_bd";
            this.text_bd.Size = new System.Drawing.Size(102, 20);
            this.text_bd.TabIndex = 4;
            this.text_bd.Text = "dados";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(629, 129);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(159, 55);
            this.btn_insert.TabIndex = 5;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(629, 190);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(159, 55);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(629, 251);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(159, 55);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(243, 40);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(117, 20);
            this.tb_nome.TabIndex = 8;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(243, 21);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(35, 13);
            this.label_nome.TabIndex = 9;
            this.label_nome.Text = "Nome";
            // 
            // label_morada
            // 
            this.label_morada.AutoSize = true;
            this.label_morada.Location = new System.Drawing.Point(366, 21);
            this.label_morada.Name = "label_morada";
            this.label_morada.Size = new System.Drawing.Size(43, 13);
            this.label_morada.TabIndex = 11;
            this.label_morada.Text = "Morada";
            // 
            // tb_morada
            // 
            this.tb_morada.Location = new System.Drawing.Point(366, 40);
            this.tb_morada.Name = "tb_morada";
            this.tb_morada.Size = new System.Drawing.Size(117, 20);
            this.tb_morada.TabIndex = 10;
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Location = new System.Drawing.Point(489, 21);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(49, 13);
            this.label_telefone.TabIndex = 13;
            this.label_telefone.Text = "Telefone";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(489, 40);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(117, 20);
            this.tb_telefone.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 321);
            this.Controls.Add(this.label_telefone);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.label_morada);
            this.Controls.Add(this.tb_morada);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.text_bd);
            this.Controls.Add(this.lista_dados);
            this.Controls.Add(this.btn_select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ListBox lista_dados;
        private System.Windows.Forms.TextBox text_bd;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_morada;
        private System.Windows.Forms.TextBox tb_morada;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.TextBox tb_telefone;
    }
}

