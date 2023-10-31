namespace ValidadorIdade
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.txbAno = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pibStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(67, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Validador de Entrada ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(36, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome: ";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(25, 128);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(74, 13);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(12, 159);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(121, 13);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "Ano de Nascimento:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(89, 95);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(162, 20);
            this.txbNome.TabIndex = 4;
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(105, 125);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(146, 20);
            this.txbSobrenome.TabIndex = 5;
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(139, 156);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(112, 20);
            this.txbAno.TabIndex = 6;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(124, 208);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(77, 22);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "Verificar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(81, 260);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(170, 20);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status: Aguardando";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(43, 208);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(207, 207);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pibStatus
            // 
            this.pibStatus.Image = global::ValidadorIdade.Properties.Resources.Loading;
            this.pibStatus.Location = new System.Drawing.Point(55, 293);
            this.pibStatus.Name = "pibStatus";
            this.pibStatus.Size = new System.Drawing.Size(211, 166);
            this.pibStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pibStatus.TabIndex = 8;
            this.pibStatus.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 526);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pibStatus);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txbAno);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador";
            ((System.ComponentModel.ISupportInitialize)(this.pibStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.TextBox txbAno;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.PictureBox pibStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

