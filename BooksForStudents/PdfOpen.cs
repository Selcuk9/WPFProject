using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksForStudents
{
    public partial class PdfOpen: Form
    {
        public PdfOpen()
        {
            InitializeComponent();
        }

        public void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            string Path = Convert.ToString(sender);
            axAcroPDF1.src = Path;
        }
       //
    }
}
