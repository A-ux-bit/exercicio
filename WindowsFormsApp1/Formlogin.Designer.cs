namespace WindowsFormsApp1
{
    partial class Formlogin
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbllogin = new System.Windows.Forms.Label();
            this.txblogin = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtbsenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(32, 260);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(42, 65);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(38, 13);
            this.lbllogin.TabIndex = 1;
            this.lbllogin.Text = "Login";
            // 
            // txblogin
            // 
            this.txblogin.Location = new System.Drawing.Point(32, 81);
            this.txblogin.Name = "txblogin";
            this.txblogin.Size = new System.Drawing.Size(338, 20);
            this.txblogin.TabIndex = 2;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(295, 260);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(42, 163);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(43, 13);
            this.lblsenha.TabIndex = 4;
            this.lblsenha.Text = "Senha";
            // 
            // txtbsenha
            // 
            this.txtbsenha.Location = new System.Drawing.Point(32, 179);
            this.txtbsenha.Name = "txtbsenha";
            this.txtbsenha.Size = new System.Drawing.Size(338, 20);
            this.txtbsenha.TabIndex = 5;
            this.txtbsenha.UseSystemPasswordChar = true;
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 356);
            this.Controls.Add(this.txtbsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txblogin);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.btnlogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            //oad += new System.EventHandler(this.Formlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txblogin;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtbsenha;
    }
}

