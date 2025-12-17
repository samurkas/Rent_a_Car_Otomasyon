using System;
using System.Windows.Forms;

namespace Samur_Rent_a_Car
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            VeriTabani.EnsureTableExists();
            Application.Run(new Form1());
        }
    }
}
