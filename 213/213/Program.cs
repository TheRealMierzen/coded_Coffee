using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213
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
<<<<<<< HEAD
            Application.Run(new loginForm());
            //                   ^^maak die jou form se naam
=======
            Application.Run(new OrderForm());// LoginForm was na OrderForm verander
>>>>>>> 80ebbc421a7914617e2b44f5901e06ce1be75a7f
        }
    }
}
