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
    public partial class FormPositionList : Form
    {
        public FormPositionList()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FormPositionStatus frm = new FormPositionStatus();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            FormPositionStatus frm = new FormPositionStatus();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
