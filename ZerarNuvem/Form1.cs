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

        public DatabaseManager ConectDB()
        {
            //Conexão Com nuvem PmedOnline.
            DatabaseManager BancoConectado = new DatabaseManager("Data Source=rkbljy0k4d.database.windows.net;Password=totvs@123;Persist Security Info=True;User ID=totvss1saudeuser@rkbljy0k4d;Initial Catalog=totvss1saudedb;");
            return BancoConectado;
        }

        public Form1()
        {
            InitializeComponent();
            PainelMenu.Enabled = false;
            FecharLogin.Enabled = false;
            DesativaAmbiente.Enabled = false;
            ConectDB().OpenConection();
        }

        private void DesbloqueiaMenu(string TestaSenha)
        {
            if (TestaSenha != "123")
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

            if(SenhaDelete.Text != "123")
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
            try {
                var SelectNuvem = ConectDB().GetDatable($@"select * from clinica where cpfcnpj = '{CpfCnpjBanco.Text}'");
                //MostraRazaoSocial
                MostraRazaoSocial.DataSource = SelectNuvem;
                MostraRazaoSocial.DisplayMember = "RazaoSocial";

                //MostraCpf
                MostraCpfCNPJ.DataSource = SelectNuvem;
                MostraCpfCNPJ.DisplayMember = "cpfcnpj";
                MostraCpfCNPJ.ValueMember = "cpfcnpj";


                //MostraID
                MostraID.DataSource = SelectNuvem;
                MostraID.DisplayMember = "ID";
                MostraID.ValueMember = "ID"; 
            }
            catch
            {
                MostraRazaoSocial.Text = "AMBIENTE NÃO LOCALIZADO";
            }
            
        }



        private void FecharLogin_Click(object sender, EventArgs e)
        {
            PainelMenu.Enabled = false;
            SenhaLogin.Text = "";
            FecharLogin.Enabled = false;
            FazerLogin.Enabled = true;
        }
        private void Login_Click(object sender, EventArgs e)
        {
            var testeSenha = SenhaLogin.Text;
            DesbloqueiaMenu(testeSenha);
        }
        
    
        private void DesativaAmbiente_Click(object sender, EventArgs e)
        {
            var CpfCnpj = MostraCpfCNPJ.SelectedValue;
            ConectDB().ExecuteNonQueries($@"update Clinica set Ativo = 1 where CpfCnpj = '{CpfCnpj}'");
            
        }


        private void EntrarDelete_Click(object sender, EventArgs e)
        {
            var TesteSenhaDelete = SenhaDelete.Text;
            DesbloqueiaDeleteAmbiente(TesteSenhaDelete);
            
        }

        private void SairDelete_Click(object sender, EventArgs e)
        {
            
            EntrarDelete.Enabled = true;
            SairDelete.Enabled = false;
            DesativaAmbiente.Enabled = false;

        }
    }
 }
