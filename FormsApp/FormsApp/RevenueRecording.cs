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
    public partial class RevenueRecording : Form
    {
        public void SetTitle(string title)
        {
            lblTitle.Text = title;
        }
        public RevenueRecording()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var provider = new DataProvider();
            try
            {
                provider.AddIncome(new Income()
                {
                    Date = inpDate.Value,
                    Source = inpSource.Text,
                    Value = inpValue.Value
                });

                MessageBox.Show("Record Was Added Successfully");
                inpSource.Text = "";
                inpValue.Value = 0;
                inpDate.Value = DateTime.Now;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
