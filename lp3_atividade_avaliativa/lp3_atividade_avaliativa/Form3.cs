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
using System.Data.SqlClient;

namespace lp3_atividade_avaliativa
{
    public partial class Form3 : MaterialSkin.Controls.MaterialForm
    {
        public Form3()
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void tbl_ProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_ProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDatabaseDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'myDatabaseDataSet1.tbl_Login'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_LoginTableAdapter.Fill(this.myDatabaseDataSet1.tbl_Login);
            // TODO: esta linha de código carrega dados na tabela 'myDatabaseDataSet1.tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutoTableAdapter.Fill(this.myDatabaseDataSet1.tbl_Produto);

        }

        private void compra_valor_unitarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void descricaoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        String cs = Globals.cs;
        
       

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            if (codigoTextbox.Text == "" || produto_descricao.Text == "" || produto_un.Text == "" || statusComboBox.Text == "" || produto_un.Text == "" || qtd_estoqueTextBox.Text == "" || marcaTextBox.Text == "" || modeloTextBox.Text == "" || compra_valor_unitarioTextBox.Text == "" || preco_vendaTextBox.Text == "" || data_cadastroDateTimePicker.Text == "")
            {
                MessageBox.Show("Campos obrigatórios vazios");
            }
            else
            {
                
                conn.Open();
                SqlCommand comando = new SqlCommand("Select * from tbl_Produto where codigo=@codigoTextbox", conn);
                comando.Parameters.AddWithValue("@codigoTextbox", codigoTextbox.Text);

                
                SqlDataAdapter adapt = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                conn.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    try
                    {

                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into tbl_Produto (codigo, descricao,unidade_medida,codigo_barras,status,marca,modelo,compra_valor_unitario,compra_desconto,venda_custo,desconto_a_vista,preco_venda,qtd_estoque,data_cadastro,data_att,ultimo_fornecedor) " +
                            "values(@codigoTextbox, @produto_descricao, @produto_un, @codigo_barrasTextBox, @statusComboBox, @marcaTextBox, @modeloTextBox, @compra_valor_unitarioTextBox,@compra_descontoTextBox ,@venda_custoTextBox, @desconto_a_vistaTextBox, @preco_vendaTextBox, @qtd_estoqueTextBox, @data_cadastroDateTimePicker, @data_attDateTimePicker, @ultimo_fornecedorTextBox);", conn);
                        cmd.Parameters.AddWithValue("@codigoTextbox", codigoTextbox.Text);
                        cmd.Parameters.AddWithValue("@produto_descricao", produto_descricao.Text);
                        cmd.Parameters.AddWithValue("@produto_un", produto_un.Text);
                        cmd.Parameters.AddWithValue("@codigo_barrasTextBox", codigo_barrasTextBox.Text);
                        cmd.Parameters.AddWithValue("@statusComboBox", statusComboBox.Text);
                        cmd.Parameters.AddWithValue("@marcaTextBox", marcaTextBox.Text);
                        cmd.Parameters.AddWithValue("@modeloTextBox", modeloTextBox.Text);
                        cmd.Parameters.AddWithValue("@compra_valor_unitarioTextBox", compra_valor_unitarioTextBox.Text);
                        cmd.Parameters.AddWithValue("@compra_descontoTextBox", compra_descontoTextBox.Text);
                        cmd.Parameters.AddWithValue("@venda_custoTextBox", venda_custoTextBox.Text);
                        cmd.Parameters.AddWithValue("@desconto_a_vistaTextBox", desconto_a_vistaTextBox.Text);
                        cmd.Parameters.AddWithValue("@preco_vendaTextBox", preco_vendaTextBox.Text);
                        cmd.Parameters.AddWithValue("@qtd_estoqueTextBox", qtd_estoqueTextBox.Text);
                        cmd.Parameters.AddWithValue("@data_cadastroDateTimePicker", data_cadastroDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@data_attDateTimePicker", data_attDateTimePicker.Value);
                        cmd.Parameters.AddWithValue("@ultimo_fornecedorTextBox", ultimo_fornecedorTextBox.Text);
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (i > 0)
                        {
                            MessageBox.Show("Produto Gravado com sucesso");
                            /*
                            conn.Open();
                            SqlCommand comando2 = new SqlCommand("Select * from tbl_Produto", conn);
                            comando.Parameters.AddWithValue("@codigoTextbox", codigoTextbox.Text);

                            SqlDataAdapter adapt2 = new SqlDataAdapter(comando2);
                            DataSet ds2 = new DataSet();
                            adapt2.Fill(ds2);
                            conn.Close();
                            int linhas = 1;
                            if (linhas >= ds.Tables[0].Rows.Count)
                            {
                                linhas = linhas + 1;
                            }
                            else
                            {
                                linhas = ds.Tables[0].Rows.Count;
                            }
                            dataGridView1.Rows.Add(1);                            
                            dataGridView1.Rows[linhas].Cells[0].Value = codigoTextbox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = produto_descricao.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = produto_un.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = codigo_barrasTextBox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = statusComboBox.SelectedItem.ToString();
                            dataGridView1.Rows[linhas].Cells[0].Value = marcaTextBox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = modeloTextBox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = compra_valor_unitarioTextBox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = compra_descontoTextBox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = venda_custoTextBox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = desconto_a_vistaTextBox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = preco_vendaTextBox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = qtd_estoqueTextBox.Text;
                            dataGridView1.Rows[linhas].Cells[0].Value = data_cadastroDateTimePicker.Value;
                            dataGridView1.Rows[linhas].Cells[0].Value = data_attDateTimePicker.Value;
                            dataGridView1.Rows[linhas].Cells[0].Value = ultimo_fornecedorTextBox.Text;
                            */


                            codigoTextbox.Text = "";
                            produto_descricao.Text = "";
                            produto_un.Text = "";
                            codigo_barrasTextBox.Text = "";
                            statusComboBox.SelectedIndex = 0;
                            marcaTextBox.Text = "";
                            modeloTextBox.Text = "";
                            compra_valor_unitarioTextBox.Text = "";
                            compra_descontoTextBox.Text = "";
                            venda_custoTextBox.Text = "";
                            desconto_a_vistaTextBox.Text = "";
                            preco_vendaTextBox.Text = "";
                            qtd_estoqueTextBox.Text = "";
                            ultimo_fornecedorTextBox.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Falha na execução");

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Código de produto ja existente");
                    this.Hide();
                    Form3 fm = new Form3();
                    fm.Show();
                }
            }
        }

        private void data_attLabel_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_ProdutoTableAdapter.FillBy(this.myDatabaseDataSet1.tbl_Produto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
