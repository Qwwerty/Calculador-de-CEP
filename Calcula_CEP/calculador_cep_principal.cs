using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_CEP
{
    public partial class calculador_cep_principal : Form
    {
        public calculador_cep_principal()
        {
            InitializeComponent();
        }

        private void bnt_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Testes de campos

                

                if (txt_cep.Text == "")
                {
                    MessageBox.Show("CEP inválido");
                    this.Close();
                    return;
                }

                #endregion

                //Instancia uma tabela...
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txt_cep.Text); ///API DO CEP...
                ds.ReadXml(xml);


                //pega as coluna, e adiciona nas textBox...
                txt_rua.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txt_bairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txt_cidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txt_uf.Text = ds.Tables[0].Rows[0]["uf"].ToString();

                //Verificar se o cep é correto...
                if (txt_uf.Text == "")
                {
                    MessageBox.Show("CEP inválido");
                    this.Close();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Não foi encontrado!!!");
            }


        }

        private void bnt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
