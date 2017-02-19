using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 TO-DO:

    Form3:
        - Zle czyta czy rower jest wypozyczony
        - Meoda zwracajaca rower nie dziala
        - Sprawdzic jeszcze raz metode wypozyczania
     
     */

namespace DataBaseApp
{
    
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
