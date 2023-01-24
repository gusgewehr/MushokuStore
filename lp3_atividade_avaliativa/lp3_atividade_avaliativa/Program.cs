using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lp3_atividade_avaliativa
{

    public static class Globals
    {
        public static readonly String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gusge\Documents\GitHub\lp3_atividade_avaliativa\lp3_atividade_avaliativa\MyDatabase.mdf;Integrated Security=True";
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show("Boa noite professor! Eu só vi que não era necessário utilizar Banco de Dados quando já estava no Form4(PDV), portanto peço que para as primeiras telas funcionarem corretamente" +
                " o senhor reconfigure o caminho do arquivo de BD no documento Program.cs. Por conta disso, também, eu não fui capaz de fazer o dvg do Form3(Produto) se atualizar quando algo é inserido no banco." +
                "Após fazer esta alteração é só apertar em ok para prosseguir");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
