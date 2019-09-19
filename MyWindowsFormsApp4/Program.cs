using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp4
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
            //Application.Run(new Home());
            //Application.Run(new DataTypUi());
            //Application.Run(new ConditionUi());
            //Application.Run(new ArrayUi());
            //Application.Run(new TestData());

           // Application.Run(new TryCatchUi());
            Application.Run(new StudentInfoUi());
        }
    }
}
