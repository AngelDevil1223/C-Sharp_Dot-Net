using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliaksandrForms
{
    public partial class IncomeExpenseTracker : Form
    {
        private int childFormNumber = 0;

        public IncomeExpenseTracker()
        {
            InitializeComponent();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void incomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = MdiChildren.FirstOrDefault(x => x.GetType() == typeof(RevenueRecording));
            if (child == null)
            {
                var inp = new RevenueRecording();
                inp.MdiParent = this;
                inp.Show();
            }
        }

        private void outcomesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var child = MdiChildren.FirstOrDefault(x => x.GetType() == typeof(ExpenseRecording));
            if (child == null)
            {
                var inp = new ExpenseRecording();
                inp.MdiParent = this;
                inp.Show();
            }
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = MdiChildren.FirstOrDefault(x => x.GetType() == typeof(ViewData));
            if (child == null)
            {
                var inp = new ViewData();
                inp.MdiParent = this;
                inp.Show();
            }
        }
    }
}
