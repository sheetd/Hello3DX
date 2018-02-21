using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello3DX
{
    public partial class InitForm : Form
    {
        private CATMain cm;
        private CATPart cp;
        
        public InitForm()
        {
            InitializeComponent();
            this.cm = new CATMain();
            this.cp = new CATPart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--> button click");
            cm.test();
            cp.createPoint();
        }
    }
}