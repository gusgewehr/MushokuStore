using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace lp3_atividade_avaliativa
{
    public partial class Form4 : MaterialSkin.Controls.MaterialForm
    {
        public Form4()
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

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class dgv
        {
            Form4 fm = new Form4();
            int linhas = 0;
            public void insertdgv(String produto_combo, String un_combo, String marca_combo, string desconto_txt, string preco_venda_txt, string user_combo, String pagamento_combo, string qtd_text, string valor_pg_txt, String data_DateTimePicker, String operacao_combo)
            {
                fm.dgvDados.Rows.Add(1);
                fm.dgvDados.Rows[linhas].Cells[0].Value = produto_combo;
                fm.dgvDados.Rows[linhas].Cells[1].Value = un_combo;
                fm.dgvDados.Rows[linhas].Cells[2].Value = marca_combo;
                fm.dgvDados.Rows[linhas].Cells[3].Value = desconto_txt;
                fm.dgvDados.Rows[linhas].Cells[4].Value = preco_venda_txt;
                fm.dgvDados.Rows[linhas].Cells[5].Value = user_combo;
                fm.dgvDados.Rows[linhas].Cells[6].Value = pagamento_combo;
                fm.dgvDados.Rows[linhas].Cells[7].Value = qtd_text;
                fm.dgvDados.Rows[linhas].Cells[8].Value = valor_pg_txt;
                fm.dgvDados.Rows[linhas].Cells[9].Value = data_DateTimePicker;
                fm.dgvDados.Rows[linhas].Cells[10].Value = operacao_combo;

                MessageBox.Show(produto_combo);

                linhas = linhas + 1;
            }

            int contLinha = 0;
            double total_vendas = 0, total_devolucao=0;
            public void change_label ()
            {          

                foreach (DataGridViewRow linha in fm.dgvDados.Rows)
                {
                    if (fm.dgvDados.Rows[contLinha].Cells[10].Value.ToString() == "Venda")
                    {
                        total_vendas = total_vendas + Convert.ToDouble(fm.dgvDados.Rows[contLinha].Cells[4].Value);
                    }
                    else if (fm.dgvDados.Rows[contLinha].Cells[10].Value.ToString() == "Devolução")
                    {
                        total_devolucao = total_devolucao + Convert.ToDouble(fm.dgvDados.Rows[contLinha].Cells[4].Value);
                    }
                    contLinha++;
                }
                fm.qtd_venda.Text = total_vendas.ToString();
                fm.total_dev.Text = total_devolucao.ToString();
            }
                
        }
        public class pdv
        {
            public string produto_combo { get; set; }
            public string marca_combo { get; set; }
            public string un_combo { get; set; }
            public string desconto_txt { get; set; }
            public string user_combo { get; set; }
            public string pagamento_combo { get; set; }
            public string qtd_text { get; set; }
            public string valor_pg_txt { get; set; }
            public string data_DateTimePicker { get; set; }
            public string operacao_combo { get; set; }

            public string preco_venda_txt { get; set; }

            public Double CalculaDesconto(String preco_venda_txt, string desconto_txt)
            {
                return Convert.ToDouble(preco_venda_txt) * (Convert.ToDouble(desconto_txt) / 100);
            }
    
            public void Registra(String produto_combo, String un_combo, String marca_combo, string desconto_txt, string preco_venda_txt, string user_combo, String pagamento_combo, string qtd_text, string valor_pg_txt, String data_DateTimePicker, String operacao_combo)
            {
                this.produto_combo = produto_combo;
                this.un_combo = un_combo;
                this.marca_combo = marca_combo;
                this.desconto_txt = desconto_txt;
                if (pagamento_combo == "Dinheiro")
                {
                    this.preco_venda_txt = CalculaDesconto(preco_venda_txt, desconto_txt).ToString();
                }
                else
                {
                    this.preco_venda_txt = preco_venda_txt;
                }                
                this.user_combo = user_combo;
                this.pagamento_combo = pagamento_combo;
                this.qtd_text = qtd_text;
                this.valor_pg_txt = valor_pg_txt;
                this.data_DateTimePicker = data_DateTimePicker;
                this.operacao_combo = operacao_combo;
                dgv dgv = new dgv();
                dgv.insertdgv(this.produto_combo, this.un_combo, this.marca_combo, this.desconto_txt, this.preco_venda_txt, this.user_combo, this.pagamento_combo, this.qtd_text, this.valor_pg_txt, this.data_DateTimePicker, this.operacao_combo);
            }
            
        }
        int linhas = 0;
        
        public void limpaCampo()
        {
            produto_combo.SelectedIndex = 0;
            un_combo.SelectedIndex = 0;
            marca_combo.SelectedIndex = 0;
            desconto_txt.Value = 0;
            preco_venda_txt.Value = 0;
            user_combo.SelectedIndex = 0;
            pagamento_combo.SelectedIndex = 0;
            qtd_text.Text = "";
            valor_pg_txt.Text = "";
            
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            dgvDados.Rows.Add(1);
            dgvDados.Rows[linhas].Cells[0].Value = produto_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[1].Value = un_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[2].Value = marca_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[3].Value = desconto_txt.Value.ToString();
            if (pagamento_combo.SelectedItem.ToString() == "Dinheiro")
            {
                dgvDados.Rows[linhas].Cells[4].Value = (preco_venda_txt.Value) * (1-(desconto_txt.Value/100));
            }
            else
            {
                dgvDados.Rows[linhas].Cells[4].Value = preco_venda_txt.Value;
            }
            dgvDados.Rows[linhas].Cells[5].Value = user_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[6].Value = pagamento_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[7].Value = qtd_text.Text;
            dgvDados.Rows[linhas].Cells[8].Value = valor_pg_txt.Text;
            dgvDados.Rows[linhas].Cells[9].Value = data_DateTimePicker.Value.ToString();
            dgvDados.Rows[linhas].Cells[10].Value = "Venda";

            MessageBox.Show("Cadastrado");

            linhas = linhas + 1;

            
            limpaCampo();
            int contLinha = 0;
            double total_vendas = 0, total_devolucao = 0;
            foreach (DataGridViewRow linha in dgvDados.Rows)
            {
                if (dgvDados.Rows[contLinha].Cells[10].Value.ToString() == "Venda")
                {
                    total_vendas = total_vendas + Convert.ToDouble(dgvDados.Rows[contLinha].Cells[4].Value);
                }
                else if (dgvDados.Rows[contLinha].Cells[10].Value.ToString() == "Devolução")
                {
                    total_devolucao = total_devolucao + Convert.ToDouble(dgvDados.Rows[contLinha].Cells[4].Value);
                }
                contLinha++;
            }
            qtd_venda.Text = total_vendas.ToString();
            total_dev.Text = total_devolucao.ToString();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'myDatabaseDataSet1.tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutoTableAdapter.Fill(this.myDatabaseDataSet1.tbl_Produto);

        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            dgvDados.Rows.Add(1);
            dgvDados.Rows[linhas].Cells[0].Value = produto_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[1].Value = un_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[2].Value = marca_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[3].Value = desconto_txt.Value.ToString();
            if (pagamento_combo.SelectedItem.ToString() == "Dinheiro")
            {
                dgvDados.Rows[linhas].Cells[4].Value = (preco_venda_txt.Value) * (1 - (desconto_txt.Value / 100));
            }
            else
            {
                dgvDados.Rows[linhas].Cells[4].Value = preco_venda_txt.Value;
            }
            dgvDados.Rows[linhas].Cells[5].Value = user_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[6].Value = pagamento_combo.SelectedItem.ToString();
            dgvDados.Rows[linhas].Cells[7].Value = qtd_text.Text;
            dgvDados.Rows[linhas].Cells[8].Value = valor_pg_txt.Text;
            dgvDados.Rows[linhas].Cells[9].Value = data_DateTimePicker.Value.ToString();
            dgvDados.Rows[linhas].Cells[10].Value = "Devolução";

            MessageBox.Show("Cadastrado");

            linhas = linhas + 1;
            limpaCampo();
            int contLinha = 0;
            double total_vendas = 0, total_devolucao = 0;
            foreach (DataGridViewRow linha in dgvDados.Rows)
            {
                if (dgvDados.Rows[contLinha].Cells[10].Value.ToString() == "Venda")
                {
                    total_vendas = total_vendas + Convert.ToDouble(dgvDados.Rows[contLinha].Cells[4].Value);
                }
                else if (dgvDados.Rows[contLinha].Cells[10].Value.ToString() == "Devolução")
                {
                    total_devolucao = total_devolucao + Convert.ToDouble(dgvDados.Rows[contLinha].Cells[4].Value);
                }
                contLinha++;
            }
            qtd_venda.Text = total_vendas.ToString();
            total_dev.Text = total_devolucao.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
