﻿using System;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           /* Application.Run(new TelaLogin());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);*/

            // O Form2 é o meu Login, aqui no exemplo, então vou exibi-lo
            TelaLogin telalogin = new TelaLogin();

            // Se o OK for pressionado, eu abro o aplicativo, senão eu saio
            if (telalogin.ShowDialog() == DialogResult.OK)
                Application.Run(new TelaPrincipal());




        }
    }
}
