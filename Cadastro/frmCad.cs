using Autofac.Core;
using Entidades;
using Interfacess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;


namespace Cadastro
{
    public partial class frmCad : Form
    {
         ClienteService service = new ClienteService();
        
        public frmCad()
        {
           

            InitializeComponent();
            txtNome.Text = txtNome.Text;
        }
       private string ValidarCad()
        {
            ts.ForeColor = Color.Red;
            if (txtNome.Text == string.Empty)
            {
                return "Preencha o campo Nome!";
            }
            else if (txtEndereco.Text == string.Empty)
            {
                return "Preencha o campo CPF";
            }
            else if (txtRG.Text == string.Empty)
            {
                return "Preencha o campo RG";
            }
            else if (txtCPF.Text == string.Empty)
            {
                return "Preencha o campo ENDEREÇO";
            }
            else if (txtBairro.Text == string.Empty)
            {
                return "Preencha o campo Bairro";
            }
            else
            {
                ts.ForeColor = Color.Black;
                return "Sucesso";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
              try
                        {
                            ts.Text = ValidarCad();
                            if (ts.Text == "Sucesso")
                            {
                                service.Cadastrar (objGerado());
                                MessageBox.Show("Cadastro Efetuado com Sucesso");
                                this.Close();
                            }

                        }
                        catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
            }
        }
        public Cliente objGerado()
        {
            Cliente obj = new Cliente();
            obj.Nome = txtNome.Text;
            obj.CPF = txtCPF.Text != "" ? Convert.ToInt64(txtCPF.Text) : 0;
            obj.RG = txtRG.Text != "" ? Convert.ToInt64(txtRG.Text) : 0; ;
            obj.Endereco = txtEndereco.Text;
            obj.N_Endereco = txtN_Endereco.Text != "" ? Convert.ToInt32(txtN_Endereco.Text) : 0; ;
            obj.CEP = txtCEP.Text != "" ? Convert.ToInt64(txtCEP.Text) : 0; ;
            obj.Bairro = txtBairro.Text;
            obj.Cidade = txtCidade.Text;
            obj.Estado = txtEstado.Text;

            return obj;



        }

        
    }
}
