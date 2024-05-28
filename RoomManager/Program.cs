using System;
using System.Windows.Forms;

namespace RoomManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DB db = new DB();
            db.createTables();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap_DangKy());
            //Application.Run(new Dat_TraPhong());

        }
    }
}
