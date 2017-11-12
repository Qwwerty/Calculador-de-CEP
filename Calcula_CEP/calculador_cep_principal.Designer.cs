namespace Calcula_CEP
{
    partial class calculador_cep_principal
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
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.bnt_pesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bnt_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP: ";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(54, 37);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(170, 20);
            this.txt_cep.TabIndex = 1;
            // 
            // txt_rua
            // 
            this.txt_rua.Location = new System.Drawing.Point(20, 141);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(204, 20);
            this.txt_rua.TabIndex = 2;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(20, 192);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(204, 20);
            this.txt_bairro.TabIndex = 3;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(20, 240);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(204, 20);
            this.txt_cidade.TabIndex = 4;
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(20, 289);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(204, 20);
            this.txt_uf.TabIndex = 5;
            // 
            // bnt_pesquisar
            // 
            this.bnt_pesquisar.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_pesquisar.Location = new System.Drawing.Point(241, 37);
            this.bnt_pesquisar.Name = "bnt_pesquisar";
            this.bnt_pesquisar.Size = new System.Drawing.Size(122, 39);
            this.bnt_pesquisar.TabIndex = 6;
            this.bnt_pesquisar.Text = "Pesquisar";
            this.bnt_pesquisar.UseVisualStyleBackColor = true;
            this.bnt_pesquisar.Click += new System.EventHandler(this.bnt_pesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orator Std", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "UF:";
            // 
            // bnt_fechar
            // 
            this.bnt_fechar.Font = new System.Drawing.Font("Orator Std", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_fechar.Location = new System.Drawing.Point(241, 82);
            this.bnt_fechar.Name = "bnt_fechar";
            this.bnt_fechar.Size = new System.Drawing.Size(122, 39);
            this.bnt_fechar.TabIndex = 11;
            this.bnt_fechar.Text = "Sair";
            this.bnt_fechar.UseVisualStyleBackColor = true;
            this.bnt_fechar.Click += new System.EventHandler(this.bnt_fechar_Click);
            // 
            // calculador_cep_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(375, 341);
            this.ControlBox = false;
            this.Controls.Add(this.bnt_fechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnt_pesquisar);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calculador_cep_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculador_cep_principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.Button bnt_pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bnt_fechar;
    }
}