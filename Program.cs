using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello3DX
{
    static class Program
    {
        //public static InitForm iForm; //???
        public const bool ENGAGE_CATIA_MODE = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!CATMain.engageActiveCatiaSession()) return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InitForm());
        }
    }
}