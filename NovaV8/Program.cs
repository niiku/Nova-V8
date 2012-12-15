using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaV8
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ProfilForm());
            Console.WriteLine(Simplifier.findById<Customer>(1).Projects().ElementAt(0).Reports().ElementAt(0).User().Profile().Components().Count);
        }
    }
}
