using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSDeskBand;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DeskBandTest
{

    [ComVisible(true)]
    [Guid("90C19864-6366-459F-BA63-67B2F9C90E77")]
    [CSDeskBandRegistration(Name = "DeskBandTest", ShowDeskBand = true)]
    public partial class Deskband : CSDeskBandWin
    {
        Control _control;
        public Deskband()
        {
            Options.MinHorizontalSize = new Size(100, 30);
            _control = new UserControl1();
        }

        protected override Control Control => _control; // Returns your main control
    }
}
