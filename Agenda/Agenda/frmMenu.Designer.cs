﻿namespace Agenda
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_inserir = new System.Windows.Forms.Button();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGENDA";
            // 
            // cmd_inserir
            // 
            this.cmd_inserir.Location = new System.Drawing.Point(144, 121);
            this.cmd_inserir.Name = "cmd_inserir";
            this.cmd_inserir.Size = new System.Drawing.Size(198, 55);
            this.cmd_inserir.TabIndex = 1;
            this.cmd_inserir.Text = "Inserir/Editar";
            this.cmd_inserir.UseVisualStyleBackColor = true;
            this.cmd_inserir.Click += new System.EventHandler(this.cmd_inserir_Click);
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(144, 192);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(198, 55);
            this.cmd_pesquisar.TabIndex = 2;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(144, 262);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(198, 55);
            this.cmd_sair.TabIndex = 3;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // label_versao
            // 
            this.label_versao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_versao.Location = new System.Drawing.Point(69, 343);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(349, 22);
            this.label_versao.TabIndex = 4;
            this.label_versao.Text = "apresenta a versão do programa";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 434);
            this.ControlBox = false;
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_inserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_inserir;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Label label_versao;
    }
}

