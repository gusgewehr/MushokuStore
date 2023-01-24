namespace lp3_atividade_avaliativa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_UserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.myDatabaseDataSet1 = new lp3_atividade_avaliativa.MyDatabaseDataSet1();
            this.tbl_LoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_LoginTableAdapter = new lp3_atividade_avaliativa.MyDatabaseDataSet1TableAdapters.tbl_LoginTableAdapter();
            this.tableAdapterManager = new lp3_atividade_avaliativa.MyDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LoginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_UserName.Depth = 0;
            this.txt_UserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_UserName.Hint = "Usuário";
            this.txt_UserName.Location = new System.Drawing.Point(116, 246);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(5);
            this.txt_UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PasswordChar = '\0';
            this.txt_UserName.SelectedText = "";
            this.txt_UserName.SelectionLength = 0;
            this.txt_UserName.SelectionStart = 0;
            this.txt_UserName.Size = new System.Drawing.Size(567, 23);
            this.txt_UserName.TabIndex = 0;
            this.txt_UserName.UseSystemPasswordChar = false;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Password.Depth = 0;
            this.txt_Password.Hint = "Senha";
            this.txt_Password.Location = new System.Drawing.Point(116, 338);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.Size = new System.Drawing.Size(567, 23);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(489, 441);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(193, 80);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // myDatabaseDataSet1
            // 
            this.myDatabaseDataSet1.DataSetName = "MyDatabaseDataSet1";
            this.myDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_LoginBindingSource
            // 
            this.tbl_LoginBindingSource.DataMember = "tbl_Login";
            this.tbl_LoginBindingSource.DataSource = this.myDatabaseDataSet1;
            // 
            // tbl_LoginTableAdapter
            // 
            this.tbl_LoginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_LoginTableAdapter = this.tbl_LoginTableAdapter;
            this.tableAdapterManager.tbl_ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lp3_atividade_avaliativa.MyDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "MUSHOKU STORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "rudeus_anime_3.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_LoginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_UserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Password;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MyDatabaseDataSet1 myDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tbl_LoginBindingSource;
        private MyDatabaseDataSet1TableAdapters.tbl_LoginTableAdapter tbl_LoginTableAdapter;
        private MyDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

