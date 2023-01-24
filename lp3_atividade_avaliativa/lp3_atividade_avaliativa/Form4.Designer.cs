namespace lp3_atividade_avaliativa
{
    partial class Form4
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
            this.produto_combo = new System.Windows.Forms.ComboBox();
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabaseDataSet1 = new lp3_atividade_avaliativa.MyDatabaseDataSet1();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.un_combo = new System.Windows.Forms.ComboBox();
            this.tblProdutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.marca_combo = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.user_combo = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.pagamento_combo = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.qtd_text = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.valor_pg_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.data_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_voltar_1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_vender = new MaterialSkin.Controls.MaterialRaisedButton();
            this.myDatabaseDataSet = new lp3_atividade_avaliativa.MyDatabaseDataSet();
            this.myDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_devolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbl_ProdutoTableAdapter = new lp3_atividade_avaliativa.MyDatabaseDataSet1TableAdapters.tbl_ProdutoTableAdapter();
            this.qtd_venda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.total_dev = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preco_venda_txt = new System.Windows.Forms.NumericUpDown();
            this.desconto_txt = new System.Windows.Forms.NumericUpDown();
            this.form4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preco_venda_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desconto_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form4BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // produto_combo
            // 
            this.produto_combo.FormattingEnabled = true;
            this.produto_combo.Items.AddRange(new object[] {
            "Gatorade",
            "Café",
            "Bolacha",
            "Empada",
            "Chocolate"});
            this.produto_combo.Location = new System.Drawing.Point(162, 77);
            this.produto_combo.Name = "produto_combo";
            this.produto_combo.Size = new System.Drawing.Size(617, 28);
            this.produto_combo.TabIndex = 0;
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "tbl_Produto";
            this.tblProdutoBindingSource.DataSource = this.myDatabaseDataSet1;
            // 
            // myDatabaseDataSet1
            // 
            this.myDatabaseDataSet1.DataSetName = "MyDatabaseDataSet1";
            this.myDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Produto:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // un_combo
            // 
            this.un_combo.FormattingEnabled = true;
            this.un_combo.Items.AddRange(new object[] {
            "Un.",
            "Kg",
            "L",
            "mL",
            "g",
            "Cx."});
            this.un_combo.Location = new System.Drawing.Point(162, 124);
            this.un_combo.Name = "un_combo";
            this.un_combo.Size = new System.Drawing.Size(176, 28);
            this.un_combo.TabIndex = 2;
            // 
            // tblProdutoBindingSource1
            // 
            this.tblProdutoBindingSource1.DataMember = "tbl_Produto";
            this.tblProdutoBindingSource1.DataSource = this.myDatabaseDataSet1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(19, 126);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Un. medida";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // marca_combo
            // 
            this.marca_combo.FormattingEnabled = true;
            this.marca_combo.Items.AddRange(new object[] {
            "Tres corações",
            "Balduco",
            "Nestle",
            "Gatorade"});
            this.marca_combo.Location = new System.Drawing.Point(481, 127);
            this.marca_combo.Name = "marca_combo";
            this.marca_combo.Size = new System.Drawing.Size(298, 28);
            this.marca_combo.TabIndex = 4;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(385, 127);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Marca";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(19, 178);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(111, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Preço de venda";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(385, 178);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(74, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Desconto";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // user_combo
            // 
            this.user_combo.FormattingEnabled = true;
            this.user_combo.Items.AddRange(new object[] {
            "ifrs-ibiruba",
            "teste"});
            this.user_combo.Location = new System.Drawing.Point(162, 220);
            this.user_combo.Name = "user_combo";
            this.user_combo.Size = new System.Drawing.Size(176, 28);
            this.user_combo.TabIndex = 10;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(19, 217);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(61, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Usuário";
            // 
            // pagamento_combo
            // 
            this.pagamento_combo.FormattingEnabled = true;
            this.pagamento_combo.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de débito",
            "Cartão de crédito",
            "Pix"});
            this.pagamento_combo.Location = new System.Drawing.Point(481, 218);
            this.pagamento_combo.Name = "pagamento_combo";
            this.pagamento_combo.Size = new System.Drawing.Size(298, 28);
            this.pagamento_combo.TabIndex = 12;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(385, 220);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(85, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Pagamento";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // qtd_text
            // 
            this.qtd_text.Depth = 0;
            this.qtd_text.Hint = "";
            this.qtd_text.Location = new System.Drawing.Point(162, 262);
            this.qtd_text.MouseState = MaterialSkin.MouseState.HOVER;
            this.qtd_text.Name = "qtd_text";
            this.qtd_text.PasswordChar = '\0';
            this.qtd_text.SelectedText = "";
            this.qtd_text.SelectionLength = 0;
            this.qtd_text.SelectionStart = 0;
            this.qtd_text.Size = new System.Drawing.Size(176, 23);
            this.qtd_text.TabIndex = 14;
            this.qtd_text.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(19, 262);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(84, 19);
            this.materialLabel8.TabIndex = 15;
            this.materialLabel8.Text = "Quantidade";
            this.materialLabel8.Click += new System.EventHandler(this.materialLabel8_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(384, 266);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(82, 19);
            this.materialLabel10.TabIndex = 19;
            this.materialLabel10.Text = "Valor pago";
            // 
            // valor_pg_txt
            // 
            this.valor_pg_txt.Depth = 0;
            this.valor_pg_txt.Hint = "";
            this.valor_pg_txt.Location = new System.Drawing.Point(481, 262);
            this.valor_pg_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.valor_pg_txt.Name = "valor_pg_txt";
            this.valor_pg_txt.PasswordChar = '\0';
            this.valor_pg_txt.SelectedText = "";
            this.valor_pg_txt.SelectionLength = 0;
            this.valor_pg_txt.SelectionStart = 0;
            this.valor_pg_txt.Size = new System.Drawing.Size(298, 23);
            this.valor_pg_txt.TabIndex = 18;
            this.valor_pg_txt.UseSystemPasswordChar = false;
            // 
            // data_DateTimePicker
            // 
            this.data_DateTimePicker.Location = new System.Drawing.Point(162, 296);
            this.data_DateTimePicker.Name = "data_DateTimePicker";
            this.data_DateTimePicker.Size = new System.Drawing.Size(617, 26);
            this.data_DateTimePicker.TabIndex = 30;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(19, 302);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(40, 19);
            this.materialLabel11.TabIndex = 31;
            this.materialLabel11.Text = "Data";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.un_medida,
            this.marca,
            this.preco_venda,
            this.desconto,
            this.usuario,
            this.pagamento,
            this.quantidade,
            this.valor_pago,
            this.data,
            this.operacao});
            this.dgvDados.Location = new System.Drawing.Point(23, 440);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(756, 148);
            this.dgvDados.TabIndex = 32;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // un_medida
            // 
            this.un_medida.HeaderText = "Un. Medida";
            this.un_medida.Name = "un_medida";
            this.un_medida.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // preco_venda
            // 
            this.preco_venda.HeaderText = "Preço de venda";
            this.preco_venda.Name = "preco_venda";
            this.preco_venda.ReadOnly = true;
            // 
            // desconto
            // 
            this.desconto.HeaderText = "Desconto";
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // pagamento
            // 
            this.pagamento.HeaderText = "Pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valor_pago
            // 
            this.valor_pago.HeaderText = "Valor Pago";
            this.valor_pago.Name = "valor_pago";
            this.valor_pago.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // operacao
            // 
            this.operacao.HeaderText = "Operacao";
            this.operacao.Name = "operacao";
            this.operacao.ReadOnly = true;
            // 
            // btn_voltar_1
            // 
            this.btn_voltar_1.Depth = 0;
            this.btn_voltar_1.Location = new System.Drawing.Point(23, 377);
            this.btn_voltar_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_voltar_1.Name = "btn_voltar_1";
            this.btn_voltar_1.Primary = true;
            this.btn_voltar_1.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar_1.TabIndex = 33;
            this.btn_voltar_1.Text = "Voltar";
            this.btn_voltar_1.UseVisualStyleBackColor = true;
            this.btn_voltar_1.Click += new System.EventHandler(this.btn_voltar_1_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.Depth = 0;
            this.btn_vender.Location = new System.Drawing.Point(635, 350);
            this.btn_vender.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Primary = true;
            this.btn_vender.Size = new System.Drawing.Size(144, 77);
            this.btn_vender.TabIndex = 46;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = true;
            this.btn_vender.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDatabaseDataSetBindingSource
            // 
            this.myDatabaseDataSetBindingSource.DataSource = this.myDatabaseDataSet;
            this.myDatabaseDataSetBindingSource.Position = 0;
            // 
            // btn_devolver
            // 
            this.btn_devolver.Depth = 0;
            this.btn_devolver.Location = new System.Drawing.Point(481, 359);
            this.btn_devolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Primary = true;
            this.btn_devolver.Size = new System.Drawing.Size(136, 58);
            this.btn_devolver.TabIndex = 47;
            this.btn_devolver.Text = "Devolver";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // tbl_ProdutoTableAdapter
            // 
            this.tbl_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // qtd_venda
            // 
            this.qtd_venda.AutoSize = true;
            this.qtd_venda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.qtd_venda.Location = new System.Drawing.Point(325, 359);
            this.qtd_venda.Name = "qtd_venda";
            this.qtd_venda.Size = new System.Drawing.Size(0, 20);
            this.qtd_venda.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(162, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Total vendas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // total_dev
            // 
            this.total_dev.AutoSize = true;
            this.total_dev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.total_dev.Location = new System.Drawing.Point(325, 407);
            this.total_dev.Name = "total_dev";
            this.total_dev.Size = new System.Drawing.Size(0, 20);
            this.total_dev.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(162, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Total Devoluções:";
            // 
            // preco_venda_txt
            // 
            this.preco_venda_txt.Location = new System.Drawing.Point(162, 176);
            this.preco_venda_txt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.preco_venda_txt.Name = "preco_venda_txt";
            this.preco_venda_txt.Size = new System.Drawing.Size(176, 26);
            this.preco_venda_txt.TabIndex = 53;
            // 
            // desconto_txt
            // 
            this.desconto_txt.Location = new System.Drawing.Point(481, 176);
            this.desconto_txt.Name = "desconto_txt";
            this.desconto_txt.Size = new System.Drawing.Size(298, 26);
            this.desconto_txt.TabIndex = 54;
            // 
            // form4BindingSource
            // 
            this.form4BindingSource.DataSource = typeof(lp3_atividade_avaliativa.Form4);
            // 
            // form4BindingSource1
            // 
            this.form4BindingSource1.DataSource = typeof(lp3_atividade_avaliativa.Form4);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.desconto_txt);
            this.Controls.Add(this.preco_venda_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_dev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtd_venda);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.btn_voltar_1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.data_DateTimePicker);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.valor_pg_txt);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.qtd_text);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.pagamento_combo);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.user_combo);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.marca_combo);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.un_combo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.produto_combo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda PDV";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preco_venda_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desconto_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form4BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox produto_combo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox un_combo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox marca_combo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox user_combo;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox pagamento_combo;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField qtd_text;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField valor_pg_txt;
        private System.Windows.Forms.DateTimePicker data_DateTimePicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.DataGridView dgvDados;
        private MaterialSkin.Controls.MaterialRaisedButton btn_voltar_1;
        private System.Windows.Forms.BindingSource form4BindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton btn_vender;
        private System.Windows.Forms.BindingSource form4BindingSource1;
        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource myDatabaseDataSetBindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton btn_devolver;
        private MyDatabaseDataSet1 myDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private MyDatabaseDataSet1TableAdapters.tbl_ProdutoTableAdapter tbl_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource1;
        private System.Windows.Forms.Label qtd_venda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_dev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn un_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacao;
        private System.Windows.Forms.NumericUpDown preco_venda_txt;
        private System.Windows.Forms.NumericUpDown desconto_txt;
    }
}