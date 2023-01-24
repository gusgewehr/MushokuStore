namespace lp3_atividade_avaliativa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.cad_prod = new MaterialSkin.Controls.MaterialRaisedButton();
            this.venda_pdv = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cad_prod
            // 
            this.cad_prod.Depth = 0;
            this.cad_prod.Location = new System.Drawing.Point(75, 300);
            this.cad_prod.Margin = new System.Windows.Forms.Padding(5);
            this.cad_prod.MouseState = MaterialSkin.MouseState.HOVER;
            this.cad_prod.Name = "cad_prod";
            this.cad_prod.Primary = true;
            this.cad_prod.Size = new System.Drawing.Size(300, 200);
            this.cad_prod.TabIndex = 4;
            this.cad_prod.Text = "Cadastrar Produto";
            this.cad_prod.UseVisualStyleBackColor = true;
            this.cad_prod.Click += new System.EventHandler(this.cad_prod_Click);
            // 
            // venda_pdv
            // 
            this.venda_pdv.Depth = 0;
            this.venda_pdv.Location = new System.Drawing.Point(425, 300);
            this.venda_pdv.Margin = new System.Windows.Forms.Padding(5);
            this.venda_pdv.MouseState = MaterialSkin.MouseState.HOVER;
            this.venda_pdv.Name = "venda_pdv";
            this.venda_pdv.Primary = true;
            this.venda_pdv.Size = new System.Drawing.Size(300, 200);
            this.venda_pdv.TabIndex = 5;
            this.venda_pdv.Text = "Venda PDV";
            this.venda_pdv.UseVisualStyleBackColor = true;
            this.venda_pdv.Click += new System.EventHandler(this.venda_pdv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "MUSHOKU STORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.venda_pdv);
            this.Controls.Add(this.cad_prod);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton cad_prod;
        private MaterialSkin.Controls.MaterialRaisedButton venda_pdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}