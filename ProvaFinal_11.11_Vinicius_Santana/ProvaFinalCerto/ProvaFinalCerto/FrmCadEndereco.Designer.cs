namespace ProvaFinalCerto
{
    partial class FrmCadEndereco
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
            txtcidade = new TextBox();
            label3 = new Label();
            txtrua = new TextBox();
            label2 = new Label();
            btnsalvar = new Button();
            txtid = new TextBox();
            label1 = new Label();
            label4 = new Label();
            cbbclientes = new ComboBox();
            SuspendLayout();
            // 
            // txtcidade
            // 
            txtcidade.Location = new Point(133, 107);
            txtcidade.Margin = new Padding(5, 6, 5, 6);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(337, 29);
            txtcidade.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 80);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 12;
            label3.Text = "Cidade";
            // 
            // txtrua
            // 
            txtrua.Location = new Point(133, 43);
            txtrua.Margin = new Padding(5, 6, 5, 6);
            txtrua.Name = "txtrua";
            txtrua.Size = new Size(337, 29);
            txtrua.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 16);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 10;
            label2.Text = "Rua";
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(133, 235);
            btnsalvar.Margin = new Padding(5, 6, 5, 6);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(213, 34);
            btnsalvar.TabIndex = 9;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(31, 43);
            txtid.Margin = new Padding(5, 6, 5, 6);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(76, 29);
            txtid.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 7;
            label1.Text = "Código";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 157);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 15;
            label4.Text = "Cliente";
            // 
            // cbbclientes
            // 
            cbbclientes.FormattingEnabled = true;
            cbbclientes.Location = new Point(133, 181);
            cbbclientes.Name = "cbbclientes";
            cbbclientes.Size = new Size(265, 29);
            cbbclientes.TabIndex = 14;
            // 
            // FrmCadEndereco
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 361);
            Controls.Add(label4);
            Controls.Add(cbbclientes);
            Controls.Add(txtcidade);
            Controls.Add(label3);
            Controls.Add(txtrua);
            Controls.Add(label2);
            Controls.Add(btnsalvar);
            Controls.Add(txtid);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmCadEndereco";
            Text = "FrmCadEndereco";
            Load += FrmCadEndereco_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcidade;
        private Label label3;
        private TextBox txtrua;
        private Label label2;
        private Button btnsalvar;
        private TextBox txtid;
        private Label label1;
        private Label label4;
        private ComboBox cbbclientes;
    }
}