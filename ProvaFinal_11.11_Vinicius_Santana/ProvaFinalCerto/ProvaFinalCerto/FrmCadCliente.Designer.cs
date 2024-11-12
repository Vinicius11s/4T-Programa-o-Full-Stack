namespace ProvaFinalCerto
{
    partial class FrmCadCliente
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
            label1 = new Label();
            txtid = new TextBox();
            btnsalvar = new Button();
            label2 = new Label();
            txtnome = new TextBox();
            txtemail = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // txtid
            // 
            txtid.Location = new Point(32, 43);
            txtid.Margin = new Padding(4);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(60, 29);
            txtid.TabIndex = 1;
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(32, 241);
            btnsalvar.Margin = new Padding(4);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(263, 32);
            btnsalvar.TabIndex = 2;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(32, 120);
            txtnome.Margin = new Padding(4);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(263, 29);
            txtnome.TabIndex = 4;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(32, 187);
            txtemail.Margin = new Padding(4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(263, 29);
            txtemail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 162);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // FrmCadCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 361);
            Controls.Add(txtemail);
            Controls.Add(label3);
            Controls.Add(txtnome);
            Controls.Add(label2);
            Controls.Add(btnsalvar);
            Controls.Add(txtid);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmCadCliente";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid;
        private Button btnsalvar;
        private Label label2;
        private TextBox txtnome;
        private TextBox txtemail;
        private Label label3;
    }
}
