namespace Aula_Adoo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnumero = new TextBox();
            btnok = new Button();
            btnPagar = new Button();
            comboBox1 = new ComboBox();
            txtvalor = new TextBox();
            SuspendLayout();
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(29, 32);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(380, 23);
            txtnumero.TabIndex = 0;
            // 
            // btnok
            // 
            btnok.Location = new Point(171, 77);
            btnok.Name = "btnok";
            btnok.Size = new Size(95, 35);
            btnok.TabIndex = 1;
            btnok.Text = "Ok";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(263, 362);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(83, 37);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dinheiro", "Cartão Débito", "Cartão Crédito", "Pix" });
            comboBox1.Location = new Point(29, 313);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(317, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(31, 362);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(175, 23);
            txtvalor.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 527);
            Controls.Add(txtvalor);
            Controls.Add(comboBox1);
            Controls.Add(btnPagar);
            Controls.Add(btnok);
            Controls.Add(txtnumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnumero;
        private Button btnok;
        private Button btnPagar;
        private ComboBox comboBox1;
        private TextBox txtvalor;
    }
}
