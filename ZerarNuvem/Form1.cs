using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZerarNuvem
{
    public partial class Form1 : Form
    {
        public DatabaseManager dbConnection;
        public DatabaseManager ConectDB()
        {
            //Conexão Com nuvem PmedOnline.
            DatabaseManager BancoConectado = new DatabaseManager("Data Source=rkbljy0k4d.database.windows.net;Password=totvs@123;Persist Security Info=True;User ID=totvss1saudeuser@rkbljy0k4d;Initial Catalog=totvss1saudedb;");
            return BancoConectado;
        }

        public Form1()
        {
            try
            {
                InitializeComponent();
                PainelMenu.Enabled = false;
                FecharLogin.Enabled = false;
                DesativaAmbiente.Enabled = false;
           }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void DesbloqueiaMenu(string TestaSenha)
        {
            if (TestaSenha != "totvs@mpn123")
            {
                PainelMenu.Enabled = false;
                SenhaLogin.Text = "";
                FecharLogin.Enabled = false;
                SenhaLogin.Text = "";
            }
            else
            {
                PainelMenu.Enabled = true;
                FazerLogin.Enabled = false;
                SenhaLogin.Text = "";
                FecharLogin.Enabled = true;
                SenhaLogin.Text = "";
            }
        }


        private void DesbloqueiaDeleteAmbiente(string SenhaDeleteTeste)
        {

            if(SenhaDelete.Text != "totvs@mpn123")
            {
                SairDelete.Enabled = false;
                SenhaDelete.Text = "";
            }else  {
                DesativaAmbiente.Enabled = true;
                SairDelete.Enabled = true;
                SenhaDelete.Text = "";
            }
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    var SelectNuvem = ConectDB().GetDatable($@"select * from clinica where cpfcnpj = '{CpfCnpjBanco.Text}'");
                    //MostraRazaoSocial
                    MostraRazaoSocial.DataSource = SelectNuvem;
                    MostraRazaoSocial.DisplayMember = "RazaoSocial";

                    //MostraCpf
                    MostraCpfCNPJ.DataSource = SelectNuvem;
                    MostraCpfCNPJ.DisplayMember = "cpfcnpj";
                    //MostraCpfCNPJ.ValueMember = "cpfcnpj";


                    //MostraID
                    MostraID.DataSource = SelectNuvem;
                    MostraID.DisplayMember = "ID";
                    MostraID.ValueMember = "ID";

                }
                catch
                {
                    MostraRazaoSocial.Text = "AMBIENTE NÃO LOCALIZADO";
                }


            if (MostraRazaoSocial.Text == "AMBIENTE NÃO LOCALIZADO" || MostraRazaoSocial.Text == "" || MostraRazaoSocial.Text == null)
            {
                SenhaDelete.Enabled = false;
            }
            else
            {
                SenhaDelete.Enabled = true;
            }

        }



        private void FecharLogin_Click(object sender, EventArgs e)
        {   
            PainelMenu.Enabled = false;
            SenhaLogin.Text = "";
            FecharLogin.Enabled = false;
            FazerLogin.Enabled = true;
            MostraRazaoSocial.Text = "";
            MostraCpfCNPJ.Text = "";
            MostraID.Text = "";
            CpfCnpjBanco.Text = "";
            SenhaDelete.Enabled = false;

        }
        private void Login_Click(object sender, EventArgs e)
        {
            var testeSenha = SenhaLogin.Text;
            DesbloqueiaMenu(testeSenha);
        }


        private void DesativaAmbiente_Click(object sender, EventArgs e)
        {
            
            var IdClinica = MostraID.SelectedValue;
            var RazaoSocial = MostraRazaoSocial.SelectedValue;
            var CpfCnpj = MostraCpfCNPJ.SelectedValue;
            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM DESATIAR A CLINICA?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                ConectDB().ExecuteNonQueries($@"update Clinica set Ativo = 0 where ID = '{IdClinica}'");
                ConectDB().ExecuteNonQueries($@"update ProfissionalClinica set Ativo = 0 where ID = '{IdClinica}'");
                ConectDB().ExecuteNonQueries($@"update UsuarioClinica set Ativo = 0 where ID = '{IdClinica}'");
                MessageBox.Show("CLINICA DESATIVADA COM SUCESSO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                SenhaDelete.Text = "";
                DesativaAmbiente.Enabled = false;
            }
            



        }



        private void EntrarDelete_Click(object sender, EventArgs e)
        {
            var TesteSenhaDelete = SenhaDelete.Text;
            DesbloqueiaDeleteAmbiente(TesteSenhaDelete);
            
        }

        private void SairDelete_Click(object sender, EventArgs e)
        {
            SenhaDelete.Enabled = false;
            EntrarDelete.Enabled = true;
            SairDelete.Enabled = false;
            DesativaAmbiente.Enabled = false;
            MostraRazaoSocial.Text = "";
            MostraCpfCNPJ.Text = "";
            MostraID.Text = "";
            CpfCnpjBanco.Text = "";

        }
    }
 }
