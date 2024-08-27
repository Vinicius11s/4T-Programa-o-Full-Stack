namespace _26_08_ProjetoAdoo
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
            gbdados = new GroupBox();
            txtdatanascimento = new DateTimePicker();
            label3 = new Label();
            txtnome = new TextBox();
            label2 = new Label();
            txtid = new TextBox();
            label1 = new Label();
            gbbotoes = new GroupBox();
            btnlocalizar = new Button();
            btncancelar = new Button();
            btnexcluir = new Button();
            btnalterar = new Button();
            btnsalvar = new Button();
            btnnovo = new Button();
            gbdados.SuspendLayout();
            gbbotoes.SuspendLayout();
            SuspendLayout();
            // 
            // gbdados
            // 
            gbdados.Controls.Add(txtdatanascimento);
            gbdados.Controls.Add(label3);
            gbdados.Controls.Add(txtnome);
            gbdados.Controls.Add(label2);
            gbdados.Controls.Add(txtid);
            gbdados.Controls.Add(label1);
            gbdados.Dock = DockStyle.Top;
            gbdados.Location = new Point(0, 0);
            gbdados.Name = "gbdados";
            gbdados.Size = new Size(904, 122);
            gbdados.TabIndex = 0;
            gbdados.TabStop = false;
            // 
            // txtdatanascimento
            // 
            txtdatanascimento.Format = DateTimePickerFormat.Short;
            txtdatanascimento.Location = new Point(696, 64);
            txtdatanascimento.Name = "txtdatanascimento";
            txtdatanascimento.Size = new Size(141, 23);
            txtdatanascimento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(696, 46);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 4;
            label3.Text = "Data de Nascimento:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(240, 64);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(396, 23);
            txtnome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 46);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtid
            // 
            txtid.Location = new Point(58, 64);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 46);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // gbbotoes
            // 
            gbbotoes.Controls.Add(btnlocalizar);
            gbbotoes.Controls.Add(btncancelar);
            gbbotoes.Controls.Add(btnexcluir);
            gbbotoes.Controls.Add(btnalterar);
            gbbotoes.Controls.Add(btnsalvar);
            gbbotoes.Controls.Add(btnnovo);
            gbbotoes.Dock = DockStyle.Bottom;
            gbbotoes.Location = new Point(0, 266);
            gbbotoes.Name = "gbbotoes";
            gbbotoes.Size = new Size(904, 100);
            gbbotoes.TabIndex = 1;
            gbbotoes.TabStop = false;
            // 
            // btnlocalizar
            // 
            btnlocalizar.Location = new Point(737, 33);
            btnlocalizar.Name = "btnlocalizar";
            btnlocalizar.Size = new Size(100, 42);
            btnlocalizar.TabIndex = 5;
            btnlocalizar.Text = "Localizar";
            btnlocalizar.UseVisualStyleBackColor = true;
            btnlocalizar.Click += btnlocalizar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(479, 33);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(100, 42);
            btncancelar.TabIndex = 4;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(610, 33);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(100, 42);
            btnexcluir.TabIndex = 2;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btnalterar
            // 
            btnalterar.Location = new Point(210, 33);
            btnalterar.Name = "btnalterar";
            btnalterar.Size = new Size(100, 42);
            btnalterar.TabIndex = 1;
            btnalterar.Text = "Alterar";
            btnalterar.UseVisualStyleBackColor = true;
            btnalterar.Click += btnalterar_Click;
            // 
            // btnsalvar
            // 
            btnsalvar.Location = new Point(345, 33);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(100, 42);
            btnsalvar.TabIndex = 3;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // btnnovo
            // 
            btnnovo.Image = Properties.Resources.botao;
            btnnovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnnovo.Location = new Point(77, 33);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(81, 42);
            btnnovo.TabIndex = 0;
            btnnovo.Text = "Novo";
            btnnovo.TextAlign = ContentAlignment.MiddleRight;
            btnnovo.UseVisualStyleBackColor = true;
            btnnovo.Click += btnnovo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 366);
            Controls.Add(gbbotoes);
            Controls.Add(gbdados);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbdados.ResumeLayout(false);
            gbdados.PerformLayout();
            gbbotoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbdados;
        private GroupBox gbbotoes;
        private DateTimePicker txtdatanascimento;
        private Label label3;
        private TextBox txtnome;
        private Label label2;
        private TextBox txtid;
        private Label label1;
        private Button btnlocalizar;
        private Button btncancelar;
        private Button btnsalvar;
        private Button btnexcluir;
        private Button btnalterar;
        private Button btnnovo;
    }
}
