namespace CadastroAluno
{
    partial class TelaDeCadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbAluno = new System.Windows.Forms.TextBox();
            this.nrIdade = new System.Windows.Forms.NumericUpDown();
            this.Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nrIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade";
            // 
            // txbAluno
            // 
            this.txbAluno.Location = new System.Drawing.Point(118, 39);
            this.txbAluno.Name = "txbAluno";
            this.txbAluno.Size = new System.Drawing.Size(100, 22);
            this.txbAluno.TabIndex = 2;
            // 
            // nrIdade
            // 
            this.nrIdade.Location = new System.Drawing.Point(118, 74);
            this.nrIdade.Name = "nrIdade";
            this.nrIdade.Size = new System.Drawing.Size(120, 22);
            this.nrIdade.TabIndex = 3;
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(92, 141);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(176, 77);
            this.Sair.TabIndex = 4;
            this.Sair.Text = "button1";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // TelaDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.nrIdade);
            this.Controls.Add(this.txbAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaDeCadastro";
            this.Text = "TelaDeCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.nrIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAluno;
        private System.Windows.Forms.NumericUpDown nrIdade;
        private System.Windows.Forms.Button Sair;
    }
}