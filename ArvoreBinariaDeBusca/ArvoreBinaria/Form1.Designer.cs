namespace ArvoreBinaria
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
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.BtListarEmOrdem = new System.Windows.Forms.Button();
            this.TxtBxValor = new System.Windows.Forms.TextBox();
            this.RichTxtBxArvore = new System.Windows.Forms.RichTextBox();
            this.BtListarPreOrdem = new System.Windows.Forms.Button();
            this.BtListarPosOrdem = new System.Windows.Forms.Button();
            this.BtRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Location = new System.Drawing.Point(77, 36);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(78, 23);
            this.BtAdicionar.TabIndex = 1;
            this.BtAdicionar.Text = "Adicionar";
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // BtListarEmOrdem
            // 
            this.BtListarEmOrdem.Location = new System.Drawing.Point(332, 39);
            this.BtListarEmOrdem.Name = "BtListarEmOrdem";
            this.BtListarEmOrdem.Size = new System.Drawing.Size(99, 23);
            this.BtListarEmOrdem.TabIndex = 2;
            this.BtListarEmOrdem.Text = "Listar em Ordem";
            this.BtListarEmOrdem.UseVisualStyleBackColor = true;
            this.BtListarEmOrdem.Click += new System.EventHandler(this.BtListar_Click);
            // 
            // TxtBxValor
            // 
            this.TxtBxValor.Location = new System.Drawing.Point(12, 39);
            this.TxtBxValor.Name = "TxtBxValor";
            this.TxtBxValor.Size = new System.Drawing.Size(50, 20);
            this.TxtBxValor.TabIndex = 3;
            // 
            // RichTxtBxArvore
            // 
            this.RichTxtBxArvore.Location = new System.Drawing.Point(12, 83);
            this.RichTxtBxArvore.Name = "RichTxtBxArvore";
            this.RichTxtBxArvore.Size = new System.Drawing.Size(624, 223);
            this.RichTxtBxArvore.TabIndex = 4;
            this.RichTxtBxArvore.Text = "";
            // 
            // BtListarPreOrdem
            // 
            this.BtListarPreOrdem.Location = new System.Drawing.Point(437, 39);
            this.BtListarPreOrdem.Name = "BtListarPreOrdem";
            this.BtListarPreOrdem.Size = new System.Drawing.Size(94, 22);
            this.BtListarPreOrdem.TabIndex = 5;
            this.BtListarPreOrdem.Text = "Listar Pré Ordem";
            this.BtListarPreOrdem.UseVisualStyleBackColor = true;
            this.BtListarPreOrdem.Click += new System.EventHandler(this.BtListarPreOrdem_Click);
            // 
            // BtListarPosOrdem
            // 
            this.BtListarPosOrdem.Location = new System.Drawing.Point(537, 37);
            this.BtListarPosOrdem.Name = "BtListarPosOrdem";
            this.BtListarPosOrdem.Size = new System.Drawing.Size(99, 22);
            this.BtListarPosOrdem.TabIndex = 6;
            this.BtListarPosOrdem.Text = "Listar Pós Ordem";
            this.BtListarPosOrdem.UseVisualStyleBackColor = true;
            this.BtListarPosOrdem.Click += new System.EventHandler(this.BtListarPosOrdem_Click);
            // 
            // BtRemover
            // 
            this.BtRemover.Location = new System.Drawing.Point(171, 36);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(78, 23);
            this.BtRemover.TabIndex = 7;
            this.BtRemover.Text = "Remover";
            this.BtRemover.UseVisualStyleBackColor = true;
            this.BtRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 318);
            this.Controls.Add(this.BtRemover);
            this.Controls.Add(this.BtListarPosOrdem);
            this.Controls.Add(this.BtListarPreOrdem);
            this.Controls.Add(this.RichTxtBxArvore);
            this.Controls.Add(this.TxtBxValor);
            this.Controls.Add(this.BtListarEmOrdem);
            this.Controls.Add(this.BtAdicionar);
            this.Name = "Form1";
            this.Text = "3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.Button BtListarEmOrdem;
        private System.Windows.Forms.TextBox TxtBxValor;
        private System.Windows.Forms.RichTextBox RichTxtBxArvore;
        private System.Windows.Forms.Button BtListarPreOrdem;
        private System.Windows.Forms.Button BtListarPosOrdem;
        private System.Windows.Forms.Button BtRemover;
    }
}

