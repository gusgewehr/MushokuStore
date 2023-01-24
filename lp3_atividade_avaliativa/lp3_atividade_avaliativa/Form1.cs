using MaterialSkin;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lp3_atividade_avaliativa
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            

        }

        String cs = Globals.cs;

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Favor, forneça um usuário e senha válidos");
                return;
            }
            try
            {

                
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from tbl_Login where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login bem sucedido");
                    this.Hide();
                    Form2 fm = new Form2();
                    fm.Closed += (s, args) => this.Close();
                    fm.Show();
                }
                /*
                if (txt_UserName.Text == "teste" && txt_Password.Text == "teste")
                //if (txt_UserName.Text == "ifrs-ibiruba" && txt_Password.Text == "ciencia-computacao-2021")
                {
                    this.Hide();
                    Form2 fm = new Form2();
                    fm.Show();
                }
                */
                else
                {
                    MessageBox.Show("Falha no login");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbl_LoginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_LoginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'myDatabaseDataSet1.tbl_Login'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_LoginTableAdapter.Fill(this.myDatabaseDataSet1.tbl_Login);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
