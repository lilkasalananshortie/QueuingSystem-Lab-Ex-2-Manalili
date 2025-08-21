using System;
using System.Collections;
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
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            nextInLine.Items.Clear();
            bool removeFirst = true;
            foreach (Object obj in CashierList)
            {
                if (removeFirst)
                {
                    removeFirst = false;    
                    continue;
                }
                nextInLine.Items.Add(obj.ToString());
            }
        }
        private void peekForm_Load(object sender, EventArgs e)
        {
            nowServingLabel.Text = CashierClass.CashierQueue.Peek();
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        private void nowServingLabel_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
