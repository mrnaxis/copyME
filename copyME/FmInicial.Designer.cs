namespace copyME
{
    partial class FmInicial
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
            this.btDirOrigem = new System.Windows.Forms.Button();
            this.btDirDestino = new System.Windows.Forms.Button();
            this.txCamOrigem = new System.Windows.Forms.TextBox();
            this.txCamDestino = new System.Windows.Forms.TextBox();
            this.btCarregar = new System.Windows.Forms.Button();
            this.ckNotSub = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btDirOrigem
            // 
            this.btDirOrigem.Location = new System.Drawing.Point(12, 12);
            this.btDirOrigem.Name = "btDirOrigem";
            this.btDirOrigem.Size = new System.Drawing.Size(153, 23);
            this.btDirOrigem.TabIndex = 0;
            this.btDirOrigem.Text = "Escolher Diretorio Origem";
            this.btDirOrigem.UseVisualStyleBackColor = true;
            this.btDirOrigem.Click += new System.EventHandler(this.btDirOrigem_Click);
            // 
            // btDirDestino
            // 
            this.btDirDestino.Location = new System.Drawing.Point(12, 55);
            this.btDirDestino.Name = "btDirDestino";
            this.btDirDestino.Size = new System.Drawing.Size(153, 23);
            this.btDirDestino.TabIndex = 1;
            this.btDirDestino.Text = "Escolher Diretorio Destino";
            this.btDirDestino.UseVisualStyleBackColor = true;
            this.btDirDestino.Click += new System.EventHandler(this.btDirDestino_Click);
            // 
            // txCamOrigem
            // 
            this.txCamOrigem.Location = new System.Drawing.Point(171, 12);
            this.txCamOrigem.Name = "txCamOrigem";
            this.txCamOrigem.Size = new System.Drawing.Size(355, 20);
            this.txCamOrigem.TabIndex = 2;
            // 
            // txCamDestino
            // 
            this.txCamDestino.Location = new System.Drawing.Point(171, 55);
            this.txCamDestino.Name = "txCamDestino";
            this.txCamDestino.Size = new System.Drawing.Size(355, 20);
            this.txCamDestino.TabIndex = 3;
            // 
            // btCarregar
            // 
            this.btCarregar.Location = new System.Drawing.Point(409, 99);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(117, 23);
            this.btCarregar.TabIndex = 4;
            this.btCarregar.Text = "Carregar Verificação";
            this.btCarregar.UseVisualStyleBackColor = true;
            this.btCarregar.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // ckNotSub
            // 
            this.ckNotSub.AutoSize = true;
            this.ckNotSub.Location = new System.Drawing.Point(12, 105);
            this.ckNotSub.Name = "ckNotSub";
            this.ckNotSub.Size = new System.Drawing.Size(137, 17);
            this.ckNotSub.TabIndex = 5;
            this.ckNotSub.Text = "Não verificar subpastas";
            this.ckNotSub.UseVisualStyleBackColor = true;
            // 
            // FmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 139);
            this.Controls.Add(this.ckNotSub);
            this.Controls.Add(this.btCarregar);
            this.Controls.Add(this.txCamDestino);
            this.Controls.Add(this.txCamOrigem);
            this.Controls.Add(this.btDirDestino);
            this.Controls.Add(this.btDirOrigem);
            this.Name = "FmInicial";
            this.Text = "Copy ME!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDirOrigem;
        private System.Windows.Forms.Button btDirDestino;
        private System.Windows.Forms.TextBox txCamOrigem;
        private System.Windows.Forms.TextBox txCamDestino;
        private System.Windows.Forms.Button btCarregar;
        private System.Windows.Forms.CheckBox ckNotSub;
    }
}

