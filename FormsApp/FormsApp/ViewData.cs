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
    public partial class ViewData : Form
    {
        public ViewData()
        {
            InitializeComponent();
        }

        private void ViewData_Load(object sender, EventArgs e)
        {
            var provider = new DataProvider();
            var outcomes = provider.Outcomes;

            outcomes.ForEach(x => dgvOutcomes.Rows.Add(new object[] { x.Source,x.Value,x.Date}));

            var incomes = provider.Incomes;

            incomes.ForEach(x => dgvIncomes.Rows.Add(new object[] { x.Source, x.Value, x.Date }));
        }
    }
}
