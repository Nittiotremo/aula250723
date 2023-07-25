namespace Categoria
{
    partial class FrmCategoria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Nascimento = new System.Windows.Forms.Label();
            this.lbl_Aniversario = new System.Windows.Forms.Label();
            this.btn_Categoria = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Nascimento = new System.Windows.Forms.TextBox();
            this.txt_Aniversario = new System.Windows.Forms.TextBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_Nascimento
            // 
            this.lbl_Nascimento.AutoSize = true;
            this.lbl_Nascimento.Location = new System.Drawing.Point(12, 52);
            this.lbl_Nascimento.Name = "lbl_Nascimento";
            this.lbl_Nascimento.Size = new System.Drawing.Size(63, 13);
            this.lbl_Nascimento.TabIndex = 1;
            this.lbl_Nascimento.Text = "Nascimento";
            // 
            // lbl_Aniversario
            // 
            this.lbl_Aniversario.AutoSize = true;
            this.lbl_Aniversario.Location = new System.Drawing.Point(152, 52);
            this.lbl_Aniversario.Name = "lbl_Aniversario";
            this.lbl_Aniversario.Size = new System.Drawing.Size(127, 13);
            this.lbl_Aniversario.TabIndex = 2;
            this.lbl_Aniversario.Text = "Ano do Ultimo aniversario";
            // 
            // btn_Categoria
            // 
            this.btn_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Categoria.Location = new System.Drawing.Point(12, 99);
            this.btn_Categoria.Name = "btn_Categoria";
            this.btn_Categoria.Size = new System.Drawing.Size(100, 34);
            this.btn_Categoria.TabIndex = 3;
            this.btn_Categoria.Text = "Categoria";
            this.btn_Categoria.UseVisualStyleBackColor = true;
            this.btn_Categoria.Click += new System.EventHandler(this.btn_Categoria_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(12, 23);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(260, 20);
            this.txt_Nome.TabIndex = 4;
            this.txt_Nome.Enter += new System.EventHandler(this.txt_Nome_Enter);
            this.txt_Nome.Leave += new System.EventHandler(this.txt_Nome_Leave);
            // 
            // txt_Nascimento
            // 
            this.txt_Nascimento.Location = new System.Drawing.Point(12, 68);
            this.txt_Nascimento.Name = "txt_Nascimento";
            this.txt_Nascimento.Size = new System.Drawing.Size(100, 20);
            this.txt_Nascimento.TabIndex = 5;
            this.txt_Nascimento.Enter += new System.EventHandler(this.txt_Nascimento_Enter);
            this.txt_Nascimento.Leave += new System.EventHandler(this.txt_Nascimento_Leave);
            // 
            // txt_Aniversario
            // 
            this.txt_Aniversario.Location = new System.Drawing.Point(155, 68);
            this.txt_Aniversario.Name = "txt_Aniversario";
            this.txt_Aniversario.Size = new System.Drawing.Size(100, 20);
            this.txt_Aniversario.TabIndex = 6;
            this.txt_Aniversario.Enter += new System.EventHandler(this.txt_Aniversario_Enter);
            this.txt_Aniversario.Leave += new System.EventHandler(this.txt_Aniversario_Leave);
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(152, 91);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_Categoria.TabIndex = 7;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Enabled = false;
            this.txt_categoria.Location = new System.Drawing.Point(155, 108);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(100, 20);
            this.txt_categoria.TabIndex = 8;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.txt_Aniversario);
            this.Controls.Add(this.txt_Nascimento);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.btn_Categoria);
            this.Controls.Add(this.lbl_Aniversario);
            this.Controls.Add(this.lbl_Nascimento);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "FrmCategoria";
            this.Text = "Categoria Aluno";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Nascimento;
        private System.Windows.Forms.Label lbl_Aniversario;
        private System.Windows.Forms.Button btn_Categoria;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Nascimento;
        private System.Windows.Forms.TextBox txt_Aniversario;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.TextBox txt_categoria;
    }
}

