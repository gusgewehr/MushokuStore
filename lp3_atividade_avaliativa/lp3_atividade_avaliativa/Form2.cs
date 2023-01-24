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
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        public Form2()
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

        private void cad_prod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fm = new Form3();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }

        private void venda_pdv_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fm = new Form4();
            fm.Closed += (s, args) => this.Close();
            fm.Show();
        }
    }
}
