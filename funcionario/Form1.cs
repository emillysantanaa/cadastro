using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcionario
{
    public partial class Form1 : Form
    {
        List<Cadastro> funcionario;

        public Form1()
        {
            
            InitializeComponent();
        }
      
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        
           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            string validarcpf = mkd_cpf.Text;
            bool Resulcpf = CPF.ValidacaoCpf(validarcpf);


            if (Resulcpf == true)
            {
                Cadastro funcionario = new Cadastro();
                funcionario.Nome = tx_nome.Text;
                funcionario.EstadoCivil = cb_estadocivil.Text;
                funcionario.DataNascimento = Convert.ToDateTime(mkd_datanascimento.Text);
                funcionario.RG = Convert.ToInt32(tx_rg.Text);
                funcionario.CPF = Convert.ToInt32(mkd_cpf.Text);
                funcionario.Email = tx_email.Text;
                funcionario.Telefone = Convert.ToString(mkd_telefone.Text);
                funcionario.Endereco = tx_endereco.Text;
                funcionario.Cidade = tx_cidade.Text;
                funcionario.Estado = tx_estado.Text;
                funcionario.Funcao = tx_funcao.Text;
                funcionario.Salario = Convert.ToDouble(tx_salario.Text);

                Cadastro.Add(funcionario);

                MessageBox.Show($"Funcionário cadastrado." + "\n Dados do funcionario(a): \n ");
            }
            else
            {
                
            } 
        }
        bool cancelar = false;
        private void button1_Click(object sender, EventArgs e)
        {
            cancelar = true;
            Console.ReadKey();
          
          
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_funcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


