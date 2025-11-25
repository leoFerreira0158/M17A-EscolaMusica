namespace m17_escolaMusica_projeto.Instrumentos
{
    partial class F_instrumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_instrumentos));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_tipo = new System.Windows.Forms.Label();
            this.lb_ano = new System.Windows.Forms.Label();
            this.lb_preco = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(94, 61);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(38, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_tipo
            // 
            this.lb_tipo.AutoSize = true;
            this.lb_tipo.Location = new System.Drawing.Point(97, 118);
            this.lb_tipo.Name = "lb_tipo";
            this.lb_tipo.Size = new System.Drawing.Size(31, 13);
            this.lb_tipo.TabIndex = 1;
            this.lb_tipo.Text = "Tipo:";
            // 
            // lb_ano
            // 
            this.lb_ano.AutoSize = true;
            this.lb_ano.Location = new System.Drawing.Point(103, 179);
            this.lb_ano.Name = "lb_ano";
            this.lb_ano.Size = new System.Drawing.Size(29, 13);
            this.lb_ano.TabIndex = 2;
            this.lb_ano.Text = "Ano:";
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Location = new System.Drawing.Point(103, 233);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(38, 13);
            this.lb_preco.TabIndex = 3;
            this.lb_preco.Text = "Preço:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(183, 54);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 4;
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(183, 111);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(100, 20);
            this.tb_tipo.TabIndex = 5;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(172, 176);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(100, 20);
            this.tb_ano.TabIndex = 6;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(172, 226);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(100, 20);
            this.tb_preco.TabIndex = 7;
            // 
            // F_instrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_tipo);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.lb_ano);
            this.Controls.Add(this.lb_tipo);
            this.Controls.Add(this.lb_nome);
            this.Name = "F_instrumentos";
            this.Text = "F_instrumentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_tipo;
        private System.Windows.Forms.Label lb_ano;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_preco;
    }
}