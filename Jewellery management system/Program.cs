using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jewellery_management_system
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
            Application.Run(new CustomerDetails());

        }

        //Runng the default(floderred) Sql Services in case the services is not run automatically
        //this code may reduce the sql exception while running the form.

        //public static void StartService(string serviceName, int timeoutMilliseconds)
        //{
        //    ServiceController service = new ServiceController("C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\Binn\sqlservr.exe");
        //    try
        //    {
        //        TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

        //        service.Start();
        //        service.WaitForStatus(ServiceControllerStatus.Running, timeout);
        //    }
        //    catch
        //    {
        //            }
        //      }


    }
}
