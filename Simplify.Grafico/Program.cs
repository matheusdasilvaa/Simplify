using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplify.Grafico
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TelaLogin telalogin = new TelaLogin();

            if (telalogin.ShowDialog() == DialogResult.OK)

                Application.Run(new TelaPrincipal());




        }
    }
}
