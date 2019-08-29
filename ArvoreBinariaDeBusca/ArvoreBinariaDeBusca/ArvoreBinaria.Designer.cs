namespace ArvoreBinariaDeBusca
{
    partial class ArvoreBinaria
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
            this.RichTxtBxArvore = new System.Windows.Forms.RichTextBox();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.BtRemover = new System.Windows.Forms.Button();
            this.TxtBxValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RichTxtBxArvore
            // 
            this.RichTxtBxArvore.Location = new System.Drawing.Point(12, 12);
            this.RichTxtBxArvore.Name = "RichTxtBxArvore";
            this.RichTxtBxArvore.Size = new System.Drawing.Size(516, 429);
            this.RichTxtBxArvore.TabIndex = 0;
            this.RichTxtBxArvore.Text = "";
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Location = new System.Drawing.Point(720, 58);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtAdicionar.TabIndex = 1;
            this.BtAdicionar.Text = "Adicionar";
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // BtRemover
            // 
            this.BtRemover.Location = new System.Drawing.Point(720, 123);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(75, 23);
            this.BtRemover.TabIndex = 2;
            this.BtRemover.Text = "Remover";
            this.BtRemover.UseVisualStyleBackColor = true;
            // 
            // TxtBxValor
            // 
            this.TxtBxValor.Location = new System.Drawing.Point(569, 61);
            this.TxtBxValor.Name = "TxtBxValor";
            this.TxtBxValor.Size = new System.Drawing.Size(100, 20);
            this.TxtBxValor.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 453);
            this.Controls.Add(this.TxtBxValor);
            this.Controls.Add(this.BtRemover);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.RichTxtBxArvore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTxtBxArvore;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.Button BtRemover;
        private System.Windows.Forms.TextBox TxtBxValor;
    }
}

