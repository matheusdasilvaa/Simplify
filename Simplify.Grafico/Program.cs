using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simplify.Negocio;

namespace Simplify.Grafico
{
    public static class Program
    {

        public static Gerenciador Gerenciador = new Gerenciador();
        
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
<<<<<<< HEAD
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           /* Application.Run(new TelaLogin());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);*/

            // O Form2 é o meu Login, aqui no exemplo, então vou exibi-lo
=======
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
>>>>>>> 511a554a56063e79992ad885e54fb51b36fb3bd5
            TelaLogin telalogin = new TelaLogin();

            if (telalogin.ShowDialog() == DialogResult.OK)

                Application.Run(new TelaPrincipal());




        }
    }
}
