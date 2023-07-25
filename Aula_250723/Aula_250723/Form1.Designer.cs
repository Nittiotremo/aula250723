namespace Aula_250723
{
    partial class Form1
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
            this.lbl_Gastos = new System.Windows.Forms.Label();
            this.txt_Gastos = new System.Windows.Forms.TextBox();
            this.lbl_Acrescimo = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_Acrescimo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Gastos
            // 
            this.lbl_Gastos.AutoSize = true;
            this.lbl_Gastos.Location = new System.Drawing.Point(16, 20);
            this.lbl_Gastos.Name = "lbl_Gastos";
            this.lbl_Gastos.Size = new System.Drawing.Size(43, 13);
            this.lbl_Gastos.TabIndex = 0;
            this.lbl_Gastos.Text = "Gastos:";
            // 
            // txt_Gastos
            // 
            this.txt_Gastos.Location = new System.Drawing.Point(65, 17);
            this.txt_Gastos.Name = "txt_Gastos";
            this.txt_Gastos.Size = new System.Drawing.Size(138, 20);
            this.txt_Gastos.TabIndex = 1;
            // 
            // lbl_Acrescimo
            // 
            this.lbl_Acrescimo.AutoSize = true;
            this.lbl_Acrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Acrescimo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Acrescimo.Location = new System.Drawing.Point(15, 56);
            this.lbl_Acrescimo.Name = "lbl_Acrescimo";
            this.lbl_Acrescimo.Size = new System.Drawing.Size(162, 20);
            this.lbl_Acrescimo.TabIndex = 2;
            this.lbl_Acrescimo.Text = "Acrescimo de 10%:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Calcular.Location = new System.Drawing.Point(209, 15);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 3;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_Acrescimo
            // 
            this.txt_Acrescimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_Acrescimo.Enabled = false;
            this.txt_Acrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Acrescimo.Location = new System.Drawing.Point(183, 56);
            this.txt_Acrescimo.Name = "txt_Acrescimo";
            this.txt_Acrescimo.Size = new System.Drawing.Size(139, 26);
            this.txt_Acrescimo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Calcular;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.txt_Acrescimo);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_Acrescimo);
            this.Controls.Add(this.txt_Gastos);
            this.Controls.Add(this.lbl_Gastos);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Acrescimo";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Gastos;
        private System.Windows.Forms.TextBox txt_Gastos;
        private System.Windows.Forms.Label lbl_Acrescimo;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_Acrescimo;
    }
}

