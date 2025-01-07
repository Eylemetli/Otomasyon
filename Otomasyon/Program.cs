using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmAnaModül());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Login formunu başlat
            FrmLogin loginForm = new FrmLogin();
            if (loginForm.ShowDialog() == DialogResult.OK) // Eğer giriş başarılıysa
            {
                Application.Run(new FrmAnaModül()); // Ana modül ekranını başlat
            }
        }
    }
}
