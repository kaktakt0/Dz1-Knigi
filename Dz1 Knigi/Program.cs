using System;
using System.Windows.Forms;

namespace Dz1_Knigi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Bookshop());
        }
    }
}
