namespace lp3_atividade_avaliativa
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label data_cadastroLabel;
            System.Windows.Forms.Label data_attLabel;
            this.btn_voltar_1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.data_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.produto_descricao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.produto_un = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.codigo_barrasTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.marcaTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.modeloTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.codigoTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.qtd_estoqueTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compra_valor_unitarioTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.compra_descontoTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.venda_custoTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.desconto_a_vistaTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ultimo_fornecedorTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.preco_vendaTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.data_attDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbl_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabaseDataSet1 = new lp3_atividade_avaliativa.MyDatabaseDataSet1();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidademedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigobarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compravalorunitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compradescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendacustoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoavistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precovendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdestoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataattDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimofornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_ProdutoTableAdapter = new lp3_atividade_avaliativa.MyDatabaseDataSet1TableAdapters.tbl_ProdutoTableAdapter();
            this.tableAdapterManager = new lp3_atividade_avaliativa.MyDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.tblLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_LoginTableAdapter = new lp3_atividade_avaliativa.MyDatabaseDataSet1TableAdapters.tbl_LoginTableAdapter();
            statusLabel = new System.Windows.Forms.Label();
            data_cadastroLabel = new System.Windows.Forms.Label();
            data_attLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(580, 85);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(69, 22);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "status*:";
            // 
            // data_cadastroLabel
            // 
            data_cadastroLabel.AutoSize = true;
            data_cadastroLabel.Location = new System.Drawing.Point(12, 305);
            data_cadastroLabel.Name = "data_cadastroLabel";
            data_cadastroLabel.Size = new System.Drawing.Size(128, 22);
            data_cadastroLabel.TabIndex = 28;
            data_cadastroLabel.Text = "data cadastro*:";
            // 
            // data_attLabel
            // 
            data_attLabel.AutoSize = true;
            data_attLabel.Location = new System.Drawing.Point(409, 305);
            data_attLabel.Name = "data_attLabel";
            data_attLabel.Size = new System.Drawing.Size(76, 22);
            data_attLabel.TabIndex = 43;
            data_attLabel.Text = "data att:";
            data_attLabel.Click += new System.EventHandler(this.data_attLabel_Click);
            // 
            // btn_voltar_1
            // 
            this.btn_voltar_1.Depth = 0;
            this.btn_voltar_1.Location = new System.Drawing.Point(12, 390);
            this.btn_voltar_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_voltar_1.Name = "btn_voltar_1";
            this.btn_voltar_1.Primary = true;
            this.btn_voltar_1.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar_1.TabIndex = 0;
            this.btn_voltar_1.Text = "Voltar";
            this.btn_voltar_1.UseVisualStyleBackColor = true;
            this.btn_voltar_1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProdutoBindingSource, "status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.statusComboBox.Location = new System.Drawing.Point(649, 82);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 30);
            this.statusComboBox.TabIndex = 9;
            this.statusComboBox.Text = "Ativo";
            // 
            // data_cadastroDateTimePicker
            // 
            this.data_cadastroDateTimePicker.Location = new System.Drawing.Point(140, 301);
            this.data_cadastroDateTimePicker.Name = "data_cadastroDateTimePicker";
            this.data_cadastroDateTimePicker.Size = new System.Drawing.Size(227, 27);
            this.data_cadastroDateTimePicker.TabIndex = 29;
            // 
            // produto_descricao
            // 
            this.produto_descricao.Depth = 0;
            this.produto_descricao.Hint = "Descrição*";
            this.produto_descricao.Location = new System.Drawing.Point(12, 120);
            this.produto_descricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.produto_descricao.Name = "produto_descricao";
            this.produto_descricao.PasswordChar = '\0';
            this.produto_descricao.SelectedText = "";
            this.produto_descricao.SelectionLength = 0;
            this.produto_descricao.SelectionStart = 0;
            this.produto_descricao.Size = new System.Drawing.Size(758, 23);
            this.produto_descricao.TabIndex = 30;
            this.produto_descricao.UseSystemPasswordChar = false;
            // 
            // produto_un
            // 
            this.produto_un.Depth = 0;
            this.produto_un.Hint = "Un. medida*";
            this.produto_un.Location = new System.Drawing.Point(13, 158);
            this.produto_un.MouseState = MaterialSkin.MouseState.HOVER;
            this.produto_un.Name = "produto_un";
            this.produto_un.PasswordChar = '\0';
            this.produto_un.SelectedText = "";
            this.produto_un.SelectionLength = 0;
            this.produto_un.SelectionStart = 0;
            this.produto_un.Size = new System.Drawing.Size(205, 23);
            this.produto_un.TabIndex = 31;
            this.produto_un.UseSystemPasswordChar = false;
            // 
            // codigo_barrasTextBox
            // 
            this.codigo_barrasTextBox.Depth = 0;
            this.codigo_barrasTextBox.Hint = "Código de barras";
            this.codigo_barrasTextBox.Location = new System.Drawing.Point(240, 157);
            this.codigo_barrasTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.codigo_barrasTextBox.Name = "codigo_barrasTextBox";
            this.codigo_barrasTextBox.PasswordChar = '\0';
            this.codigo_barrasTextBox.SelectedText = "";
            this.codigo_barrasTextBox.SelectionLength = 0;
            this.codigo_barrasTextBox.SelectionStart = 0;
            this.codigo_barrasTextBox.Size = new System.Drawing.Size(327, 23);
            this.codigo_barrasTextBox.TabIndex = 32;
            this.codigo_barrasTextBox.UseSystemPasswordChar = false;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Depth = 0;
            this.marcaTextBox.Hint = "Marca*";
            this.marcaTextBox.Location = new System.Drawing.Point(13, 195);
            this.marcaTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.PasswordChar = '\0';
            this.marcaTextBox.SelectedText = "";
            this.marcaTextBox.SelectionLength = 0;
            this.marcaTextBox.SelectionStart = 0;
            this.marcaTextBox.Size = new System.Drawing.Size(372, 23);
            this.marcaTextBox.TabIndex = 33;
            this.marcaTextBox.UseSystemPasswordChar = false;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Depth = 0;
            this.modeloTextBox.Hint = "Modelo*";
            this.modeloTextBox.Location = new System.Drawing.Point(413, 195);
            this.modeloTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.PasswordChar = '\0';
            this.modeloTextBox.SelectedText = "";
            this.modeloTextBox.SelectionLength = 0;
            this.modeloTextBox.SelectionStart = 0;
            this.modeloTextBox.Size = new System.Drawing.Size(359, 23);
            this.modeloTextBox.TabIndex = 34;
            this.modeloTextBox.UseSystemPasswordChar = false;
            // 
            // codigoTextbox
            // 
            this.codigoTextbox.Depth = 0;
            this.codigoTextbox.Hint = "Código*";
            this.codigoTextbox.Location = new System.Drawing.Point(12, 82);
            this.codigoTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.codigoTextbox.Name = "codigoTextbox";
            this.codigoTextbox.PasswordChar = '\0';
            this.codigoTextbox.SelectedText = "";
            this.codigoTextbox.SelectionLength = 0;
            this.codigoTextbox.SelectionStart = 0;
            this.codigoTextbox.Size = new System.Drawing.Size(555, 23);
            this.codigoTextbox.TabIndex = 35;
            this.codigoTextbox.UseSystemPasswordChar = false;
            this.codigoTextbox.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // qtd_estoqueTextBox
            // 
            this.qtd_estoqueTextBox.Depth = 0;
            this.qtd_estoqueTextBox.Hint = "Qtd. Estoque*";
            this.qtd_estoqueTextBox.Location = new System.Drawing.Point(593, 158);
            this.qtd_estoqueTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.qtd_estoqueTextBox.Name = "qtd_estoqueTextBox";
            this.qtd_estoqueTextBox.PasswordChar = '\0';
            this.qtd_estoqueTextBox.SelectedText = "";
            this.qtd_estoqueTextBox.SelectionLength = 0;
            this.qtd_estoqueTextBox.SelectionStart = 0;
            this.qtd_estoqueTextBox.Size = new System.Drawing.Size(177, 23);
            this.qtd_estoqueTextBox.TabIndex = 36;
            this.qtd_estoqueTextBox.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.unidademedidaDataGridViewTextBoxColumn,
            this.codigobarrasDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.compravalorunitarioDataGridViewTextBoxColumn,
            this.compradescontoDataGridViewTextBoxColumn,
            this.vendacustoDataGridViewTextBoxColumn,
            this.descontoavistaDataGridViewTextBoxColumn,
            this.precovendaDataGridViewTextBoxColumn,
            this.qtdestoqueDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.dataattDataGridViewTextBoxColumn,
            this.ultimofornecedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbl_ProdutoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(758, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // compra_valor_unitarioTextBox
            // 
            this.compra_valor_unitarioTextBox.Depth = 0;
            this.compra_valor_unitarioTextBox.Hint = "Compra valor unitario*";
            this.compra_valor_unitarioTextBox.Location = new System.Drawing.Point(12, 229);
            this.compra_valor_unitarioTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.compra_valor_unitarioTextBox.Name = "compra_valor_unitarioTextBox";
            this.compra_valor_unitarioTextBox.PasswordChar = '\0';
            this.compra_valor_unitarioTextBox.SelectedText = "";
            this.compra_valor_unitarioTextBox.SelectionLength = 0;
            this.compra_valor_unitarioTextBox.SelectionStart = 0;
            this.compra_valor_unitarioTextBox.Size = new System.Drawing.Size(373, 23);
            this.compra_valor_unitarioTextBox.TabIndex = 38;
            this.compra_valor_unitarioTextBox.UseSystemPasswordChar = false;
            // 
            // compra_descontoTextBox
            // 
            this.compra_descontoTextBox.Depth = 0;
            this.compra_descontoTextBox.Hint = "Compra desconto";
            this.compra_descontoTextBox.Location = new System.Drawing.Point(413, 229);
            this.compra_descontoTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.compra_descontoTextBox.Name = "compra_descontoTextBox";
            this.compra_descontoTextBox.PasswordChar = '\0';
            this.compra_descontoTextBox.SelectedText = "";
            this.compra_descontoTextBox.SelectionLength = 0;
            this.compra_descontoTextBox.SelectionStart = 0;
            this.compra_descontoTextBox.Size = new System.Drawing.Size(357, 23);
            this.compra_descontoTextBox.TabIndex = 39;
            this.compra_descontoTextBox.UseSystemPasswordChar = false;
            // 
            // venda_custoTextBox
            // 
            this.venda_custoTextBox.Depth = 0;
            this.venda_custoTextBox.Hint = "Venda custo";
            this.venda_custoTextBox.Location = new System.Drawing.Point(13, 266);
            this.venda_custoTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.venda_custoTextBox.Name = "venda_custoTextBox";
            this.venda_custoTextBox.PasswordChar = '\0';
            this.venda_custoTextBox.SelectedText = "";
            this.venda_custoTextBox.SelectionLength = 0;
            this.venda_custoTextBox.SelectionStart = 0;
            this.venda_custoTextBox.Size = new System.Drawing.Size(205, 23);
            this.venda_custoTextBox.TabIndex = 40;
            this.venda_custoTextBox.UseSystemPasswordChar = false;
            // 
            // desconto_a_vistaTextBox
            // 
            this.desconto_a_vistaTextBox.Depth = 0;
            this.desconto_a_vistaTextBox.Hint = "Desconto a vista";
            this.desconto_a_vistaTextBox.Location = new System.Drawing.Point(267, 266);
            this.desconto_a_vistaTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.desconto_a_vistaTextBox.Name = "desconto_a_vistaTextBox";
            this.desconto_a_vistaTextBox.PasswordChar = '\0';
            this.desconto_a_vistaTextBox.SelectedText = "";
            this.desconto_a_vistaTextBox.SelectionLength = 0;
            this.desconto_a_vistaTextBox.SelectionStart = 0;
            this.desconto_a_vistaTextBox.Size = new System.Drawing.Size(285, 23);
            this.desconto_a_vistaTextBox.TabIndex = 41;
            this.desconto_a_vistaTextBox.UseSystemPasswordChar = false;
            // 
            // ultimo_fornecedorTextBox
            // 
            this.ultimo_fornecedorTextBox.Depth = 0;
            this.ultimo_fornecedorTextBox.Hint = "Último fornecedor";
            this.ultimo_fornecedorTextBox.Location = new System.Drawing.Point(12, 343);
            this.ultimo_fornecedorTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ultimo_fornecedorTextBox.Name = "ultimo_fornecedorTextBox";
            this.ultimo_fornecedorTextBox.PasswordChar = '\0';
            this.ultimo_fornecedorTextBox.SelectedText = "";
            this.ultimo_fornecedorTextBox.SelectionLength = 0;
            this.ultimo_fornecedorTextBox.SelectionStart = 0;
            this.ultimo_fornecedorTextBox.Size = new System.Drawing.Size(758, 23);
            this.ultimo_fornecedorTextBox.TabIndex = 42;
            this.ultimo_fornecedorTextBox.UseSystemPasswordChar = false;
            // 
            // preco_vendaTextBox
            // 
            this.preco_vendaTextBox.Depth = 0;
            this.preco_vendaTextBox.Hint = "Preço venda*";
            this.preco_vendaTextBox.Location = new System.Drawing.Point(593, 266);
            this.preco_vendaTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.preco_vendaTextBox.Name = "preco_vendaTextBox";
            this.preco_vendaTextBox.PasswordChar = '\0';
            this.preco_vendaTextBox.SelectedText = "";
            this.preco_vendaTextBox.SelectionLength = 0;
            this.preco_vendaTextBox.SelectionStart = 0;
            this.preco_vendaTextBox.Size = new System.Drawing.Size(177, 23);
            this.preco_vendaTextBox.TabIndex = 43;
            this.preco_vendaTextBox.UseSystemPasswordChar = false;
            // 
            // data_attDateTimePicker
            // 
            this.data_attDateTimePicker.Location = new System.Drawing.Point(491, 300);
            this.data_attDateTimePicker.Name = "data_attDateTimePicker";
            this.data_attDateTimePicker.Size = new System.Drawing.Size(279, 27);
            this.data_attDateTimePicker.TabIndex = 44;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(649, 380);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(121, 47);
            this.materialRaisedButton1.TabIndex = 45;
            this.materialRaisedButton1.Text = "Gravar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // tbl_ProdutoBindingSource
            // 
            this.tbl_ProdutoBindingSource.DataMember = "tbl_Produto";
            this.tbl_ProdutoBindingSource.DataSource = this.myDatabaseDataSet1;
            // 
            // myDatabaseDataSet1
            // 
            this.myDatabaseDataSet1.DataSetName = "MyDatabaseDataSet1";
            this.myDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidademedidaDataGridViewTextBoxColumn
            // 
            this.unidademedidaDataGridViewTextBoxColumn.DataPropertyName = "unidade_medida";
            this.unidademedidaDataGridViewTextBoxColumn.HeaderText = "unidade_medida";
            this.unidademedidaDataGridViewTextBoxColumn.Name = "unidademedidaDataGridViewTextBoxColumn";
            this.unidademedidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigobarrasDataGridViewTextBoxColumn
            // 
            this.codigobarrasDataGridViewTextBoxColumn.DataPropertyName = "codigo_barras";
            this.codigobarrasDataGridViewTextBoxColumn.HeaderText = "codigo_barras";
            this.codigobarrasDataGridViewTextBoxColumn.Name = "codigobarrasDataGridViewTextBoxColumn";
            this.codigobarrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compravalorunitarioDataGridViewTextBoxColumn
            // 
            this.compravalorunitarioDataGridViewTextBoxColumn.DataPropertyName = "compra_valor_unitario";
            this.compravalorunitarioDataGridViewTextBoxColumn.HeaderText = "compra_valor_unitario";
            this.compravalorunitarioDataGridViewTextBoxColumn.Name = "compravalorunitarioDataGridViewTextBoxColumn";
            this.compravalorunitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compradescontoDataGridViewTextBoxColumn
            // 
            this.compradescontoDataGridViewTextBoxColumn.DataPropertyName = "compra_desconto";
            this.compradescontoDataGridViewTextBoxColumn.HeaderText = "compra_desconto";
            this.compradescontoDataGridViewTextBoxColumn.Name = "compradescontoDataGridViewTextBoxColumn";
            this.compradescontoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendacustoDataGridViewTextBoxColumn
            // 
            this.vendacustoDataGridViewTextBoxColumn.DataPropertyName = "venda_custo";
            this.vendacustoDataGridViewTextBoxColumn.HeaderText = "venda_custo";
            this.vendacustoDataGridViewTextBoxColumn.Name = "vendacustoDataGridViewTextBoxColumn";
            this.vendacustoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descontoavistaDataGridViewTextBoxColumn
            // 
            this.descontoavistaDataGridViewTextBoxColumn.DataPropertyName = "desconto_a_vista";
            this.descontoavistaDataGridViewTextBoxColumn.HeaderText = "desconto_a_vista";
            this.descontoavistaDataGridViewTextBoxColumn.Name = "descontoavistaDataGridViewTextBoxColumn";
            this.descontoavistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precovendaDataGridViewTextBoxColumn
            // 
            this.precovendaDataGridViewTextBoxColumn.DataPropertyName = "preco_venda";
            this.precovendaDataGridViewTextBoxColumn.HeaderText = "preco_venda";
            this.precovendaDataGridViewTextBoxColumn.Name = "precovendaDataGridViewTextBoxColumn";
            this.precovendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdestoqueDataGridViewTextBoxColumn
            // 
            this.qtdestoqueDataGridViewTextBoxColumn.DataPropertyName = "qtd_estoque";
            this.qtdestoqueDataGridViewTextBoxColumn.HeaderText = "qtd_estoque";
            this.qtdestoqueDataGridViewTextBoxColumn.Name = "qtdestoqueDataGridViewTextBoxColumn";
            this.qtdestoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            this.datacadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataattDataGridViewTextBoxColumn
            // 
            this.dataattDataGridViewTextBoxColumn.DataPropertyName = "data_att";
            this.dataattDataGridViewTextBoxColumn.HeaderText = "data_att";
            this.dataattDataGridViewTextBoxColumn.Name = "dataattDataGridViewTextBoxColumn";
            this.dataattDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ultimofornecedorDataGridViewTextBoxColumn
            // 
            this.ultimofornecedorDataGridViewTextBoxColumn.DataPropertyName = "ultimo_fornecedor";
            this.ultimofornecedorDataGridViewTextBoxColumn.HeaderText = "ultimo_fornecedor";
            this.ultimofornecedorDataGridViewTextBoxColumn.Name = "ultimofornecedorDataGridViewTextBoxColumn";
            this.ultimofornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbl_ProdutoTableAdapter
            // 
            this.tbl_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_LoginTableAdapter = null;
            this.tableAdapterManager.tbl_ProdutoTableAdapter = this.tbl_ProdutoTableAdapter;
            this.tableAdapterManager.UpdateOrder = lp3_atividade_avaliativa.MyDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblLoginBindingSource
            // 
            this.tblLoginBindingSource.DataMember = "tbl_Login";
            this.tblLoginBindingSource.DataSource = this.myDatabaseDataSet1;
            // 
            // tbl_LoginTableAdapter
            // 
            this.tbl_LoginTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(data_attLabel);
            this.Controls.Add(this.data_attDateTimePicker);
            this.Controls.Add(this.preco_vendaTextBox);
            this.Controls.Add(this.ultimo_fornecedorTextBox);
            this.Controls.Add(this.desconto_a_vistaTextBox);
            this.Controls.Add(this.venda_custoTextBox);
            this.Controls.Add(this.compra_descontoTextBox);
            this.Controls.Add(this.compra_valor_unitarioTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.qtd_estoqueTextBox);
            this.Controls.Add(this.codigoTextbox);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.codigo_barrasTextBox);
            this.Controls.Add(this.produto_un);
            this.Controls.Add(this.produto_descricao);
            this.Controls.Add(data_cadastroLabel);
            this.Controls.Add(this.data_cadastroDateTimePicker);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.btn_voltar_1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLoginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_voltar_1;
        private MyDatabaseDataSet1 myDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tbl_ProdutoBindingSource;
        private MyDatabaseDataSet1TableAdapters.tbl_ProdutoTableAdapter tbl_ProdutoTableAdapter;
        private MyDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DateTimePicker data_cadastroDateTimePicker;
        private MaterialSkin.Controls.MaterialSingleLineTextField produto_descricao;
        private MaterialSkin.Controls.MaterialSingleLineTextField produto_un;
        private MaterialSkin.Controls.MaterialSingleLineTextField codigo_barrasTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField marcaTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField modeloTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField codigoTextbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField qtd_estoqueTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblLoginBindingSource;
        private MyDatabaseDataSet1TableAdapters.tbl_LoginTableAdapter tbl_LoginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidademedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigobarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compravalorunitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compradescontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendacustoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoavistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precovendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdestoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataattDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimofornecedorDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialSingleLineTextField compra_valor_unitarioTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField compra_descontoTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField venda_custoTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField desconto_a_vistaTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField ultimo_fornecedorTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField preco_vendaTextBox;
        private System.Windows.Forms.DateTimePicker data_attDateTimePicker;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}