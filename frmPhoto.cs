using PhotoUpSet.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoUpSet
{
    public partial class frmPhoto : Form
    {
        public frmPhoto()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            pbPhoto.Image = Resources.setman;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            pbPhoto.Image = Resources.upman;
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            pbPhoto.Image = Resources.sunman;
        }
    }
}
