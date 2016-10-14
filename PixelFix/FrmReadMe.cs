using System;
using System.Windows.Forms;

namespace PixelFix
{
    public partial class FrmReadMe : Form
    {
        public FrmReadMe()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
