using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UlamSpiralLibrary;

namespace cSharpUsingLibrary
{
        public partial class FrmLibrary : Form
    {
        public FrmLibrary()
        {
            InitializeComponent();
        }

        private void FrmLibrary_Load(object sender, EventArgs e)
        {

            int num = 2381;
            UlamSpiral abc = new UlamSpiral(num);

            this.Text = Convert.ToString($"NUM= {num}         X= {abc.X}     Y= {abc.Y}");

        }
    }
}
