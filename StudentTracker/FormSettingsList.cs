using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class FormSettingsList : Form
    {
        public FormSettingsList()
        {
            InitializeComponent();
        }

        private void FormSettingsList_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dayAmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FormSettings frm  = new FormSettings();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            FormSettings frm = new FormSettings();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
