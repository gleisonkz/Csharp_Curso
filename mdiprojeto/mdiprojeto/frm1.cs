using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiprojeto
{
    public partial class frm1 : Form
    {
        public frm1(Form frmParent)
        {
            InitializeComponent();
            this.MdiParent = frmParent;
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }
    }
}
