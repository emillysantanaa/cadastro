namespace funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Salvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.mkd_datanascimento = new System.Windows.Forms.MaskedTextBox();
            this.tx_rg = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.mkd_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mkd_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_estado = new System.Windows.Forms.TextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.cb_estadocivil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_funcao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Salvar.Location = new System.Drawing.Point(572, 570);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(94, 32);
            this.Salvar.TabIndex = 0;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(460, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_nome
            // 
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(46, 120);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(397, 19);
            this.tx_nome.TabIndex = 2;
            this.tx_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mkd_datanascimento
            // 
            this.mkd_datanascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mkd_datanascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkd_datanascimento.Location = new System.Drawing.Point(69, 195);
            this.mkd_datanascimento.Mask = "00/00/0000";
            this.mkd_datanascimento.Name = "mkd_datanascimento";
            this.mkd_datanascimento.Size = new System.Drawing.Size(66, 19);
            this.mkd_datanascimento.TabIndex = 4;
            this.mkd_datanascimento.ValidatingType = typeof(System.DateTime);
            // 
            // tx_rg
            // 
            this.tx_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rg.Location = new System.Drawing.Point(289, 195);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(113, 13);
            this.tx_rg.TabIndex = 5;
            // 
            // tx_email
            // 
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.Location = new System.Drawing.Point(46, 264);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(397, 19);
            this.tx_email.TabIndex = 6;
            // 
            // mkd_cpf
            // 
            this.mkd_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mkd_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkd_cpf.Location = new System.Drawing.Point(526, 190);
            this.mkd_cpf.Mask = "000.000.000-00";
            this.mkd_cpf.Name = "mkd_cpf";
            this.mkd_cpf.Size = new System.Drawing.Size(121, 19);
            this.mkd_cpf.TabIndex = 7;
            this.mkd_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // mkd_telefone
            // 
            this.mkd_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mkd_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkd_telefone.Location = new System.Drawing.Point(526, 264);
            this.mkd_telefone.Mask = "(00) 00000-0000";
            this.mkd_telefone.Name = "mkd_telefone";
            this.mkd_telefone.Size = new System.Drawing.Size(100, 19);
            this.mkd_telefone.TabIndex = 8;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_endereco.Location = new System.Drawing.Point(46, 323);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(397, 19);
            this.tx_endereco.TabIndex = 9;
            // 
            // tx_cidade
            // 
            this.tx_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cidade.Location = new System.Drawing.Point(46, 391);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(326, 17);
            this.tx_cidade.TabIndex = 10;
            this.tx_cidade.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tx_estado
            // 
            this.tx_estado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_estado.Location = new System.Drawing.Point(526, 389);
            this.tx_estado.Name = "tx_estado";
            this.tx_estado.Size = new System.Drawing.Size(133, 19);
            this.tx_estado.TabIndex = 11;
            // 
            // tx_salario
            // 
            this.tx_salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salario.Location = new System.Drawing.Point(526, 457);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(112, 19);
            this.tx_salario.TabIndex = 13;
            // 
            // cb_estadocivil
            // 
            this.cb_estadocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estadocivil.FormattingEnabled = true;
            this.cb_estadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viúvo(a)"});
            this.cb_estadocivil.Location = new System.Drawing.Point(526, 113);
            this.cb_estadocivil.Name = "cb_estadocivil";
            this.cb_estadocivil.Size = new System.Drawing.Size(133, 26);
            this.cb_estadocivil.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(66, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tx_funcao
            // 
            this.tx_funcao.Location = new System.Drawing.Point(46, 447);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(300, 20);
            this.tx_funcao.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 614);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_estadocivil);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.tx_estado);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.mkd_telefone);
            this.Controls.Add(this.mkd_cpf);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.mkd_datanascimento);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Salvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.MaskedTextBox mkd_datanascimento;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.MaskedTextBox mkd_cpf;
        private System.Windows.Forms.MaskedTextBox mkd_telefone;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_estado;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.ComboBox cb_estadocivil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_funcao;
    }
}

