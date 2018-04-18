namespace Trabalho_Palitov1
{
    partial class FormPalito
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
			this.Lblquantidadepalitos = new System.Windows.Forms.Label();
			this.Numqtdpalitos = new System.Windows.Forms.NumericUpDown();
			this.Btnjogar = new System.Windows.Forms.Button();
			this.Lblquantospalitos = new System.Windows.Forms.Label();
			this.Btnretirar = new System.Windows.Forms.Button();
			this.Maskbxpalitos = new System.Windows.Forms.MaskedTextBox();
			this.RichTextBoxpalito = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.Numqtdpalitos)).BeginInit();
			this.SuspendLayout();
			// 
			// Lblquantidadepalitos
			// 
			this.Lblquantidadepalitos.AutoSize = true;
			this.Lblquantidadepalitos.Location = new System.Drawing.Point(12, 30);
			this.Lblquantidadepalitos.Name = "Lblquantidadepalitos";
			this.Lblquantidadepalitos.Size = new System.Drawing.Size(161, 13);
			this.Lblquantidadepalitos.TabIndex = 0;
			this.Lblquantidadepalitos.Text = "Escolha a quantidade de palitos:";
			// 
			// Numqtdpalitos
			// 
			this.Numqtdpalitos.Location = new System.Drawing.Point(229, 28);
			this.Numqtdpalitos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.Numqtdpalitos.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.Numqtdpalitos.Name = "Numqtdpalitos";
			this.Numqtdpalitos.Size = new System.Drawing.Size(87, 20);
			this.Numqtdpalitos.TabIndex = 1;
			this.Numqtdpalitos.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// Btnjogar
			// 
			this.Btnjogar.Location = new System.Drawing.Point(410, 25);
			this.Btnjogar.Name = "Btnjogar";
			this.Btnjogar.Size = new System.Drawing.Size(75, 23);
			this.Btnjogar.TabIndex = 2;
			this.Btnjogar.Text = "Jogar";
			this.Btnjogar.UseVisualStyleBackColor = true;
			this.Btnjogar.Click += new System.EventHandler(this.Btnjogar_Click);
			// 
			// Lblquantospalitos
			// 
			this.Lblquantospalitos.AutoSize = true;
			this.Lblquantospalitos.Location = new System.Drawing.Point(12, 82);
			this.Lblquantospalitos.Name = "Lblquantospalitos";
			this.Lblquantospalitos.Size = new System.Drawing.Size(146, 13);
			this.Lblquantospalitos.TabIndex = 3;
			this.Lblquantospalitos.Text = "Quantos palitos deseja retirar:";
			this.Lblquantospalitos.Visible = false;
			this.Lblquantospalitos.VisibleChanged += new System.EventHandler(this.Btnretirar_Click);
			// 
			// Btnretirar
			// 
			this.Btnretirar.Location = new System.Drawing.Point(410, 77);
			this.Btnretirar.Name = "Btnretirar";
			this.Btnretirar.Size = new System.Drawing.Size(75, 23);
			this.Btnretirar.TabIndex = 4;
			this.Btnretirar.Text = "Retirar";
			this.Btnretirar.UseVisualStyleBackColor = true;
			this.Btnretirar.Visible = false;
			this.Btnretirar.Click += new System.EventHandler(this.Btnretirar_Click);
			// 
			// Maskbxpalitos
			// 
			this.Maskbxpalitos.Location = new System.Drawing.Point(229, 79);
			this.Maskbxpalitos.Name = "Maskbxpalitos";
			this.Maskbxpalitos.Size = new System.Drawing.Size(87, 20);
			this.Maskbxpalitos.TabIndex = 0;
			this.Maskbxpalitos.Visible = false;
			// 
			// RichTextBoxpalito
			// 
			this.RichTextBoxpalito.Location = new System.Drawing.Point(12, 131);
			this.RichTextBoxpalito.Name = "RichTextBoxpalito";
			this.RichTextBoxpalito.Size = new System.Drawing.Size(562, 288);
			this.RichTextBoxpalito.TabIndex = 6;
			this.RichTextBoxpalito.Text = "";
			// 
			// FormPalito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 448);
			this.Controls.Add(this.RichTextBoxpalito);
			this.Controls.Add(this.Maskbxpalitos);
			this.Controls.Add(this.Btnretirar);
			this.Controls.Add(this.Lblquantospalitos);
			this.Controls.Add(this.Btnjogar);
			this.Controls.Add(this.Numqtdpalitos);
			this.Controls.Add(this.Lblquantidadepalitos);
			this.Name = "FormPalito";
			this.Text = "Jogo do Palito";
			((System.ComponentModel.ISupportInitialize)(this.Numqtdpalitos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblquantidadepalitos;
        private System.Windows.Forms.NumericUpDown Numqtdpalitos;
        private System.Windows.Forms.Button Btnjogar;
        private System.Windows.Forms.Label Lblquantospalitos;
        private System.Windows.Forms.Button Btnretirar;
        private System.Windows.Forms.MaskedTextBox Maskbxpalitos;
        private System.Windows.Forms.RichTextBox RichTextBoxpalito;
    }
}

