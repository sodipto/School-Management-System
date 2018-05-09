using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
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
           // Application.Run(new Super_Admin());
             //Application.Run(new StudentEntry());
           //  Application.Run(new ClassEntry());
            // Application.Run(new SectionEntry());
          //   Application.Run(new ClassRegistration());
          // Application.Run(new Marks());
             //Application.Run(new ResultShow());
            // Application.Run(new FeeTypes());
            //Application.Run(new FeeEntry());
            // Application.Run(new BorrowBook());
          //   Application.Run(new ReturnBook());
         //Application.Run(new LibraryDetails());
          //   Application.Run(new LibraryBookDetails());
           //  Application.Run(new Student_Details());
             Application.Run(new Login());
          //Application.Run(new UserTypeEntry());
             //Application.Run(new Payment());
             //Application.Run(new Librian());
           //Application.Run(new SubjectEntry());
        }
    }
}
