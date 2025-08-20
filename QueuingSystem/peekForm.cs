using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingSystem
{
    public partial class peekForm : Form
    {
        public peekForm()
        {
            InitializeComponent();
            
        }

        private void peekForm_Load(object sender, EventArgs e)
        {
            nowServingLabel.Text = CashierClass.CashierQueue.Peek();
        }

        private void nowServingLabel_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
