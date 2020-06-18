using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudOperationUsingWebFormAndDapper
{
    static class Program
    {
       //If this code works, then it was writen by Rosabel Olugbenga. If it doesn't, then i can only say one thing  "IT IS WHAT IT IS".

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new myform());
        }
    }
}
