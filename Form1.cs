using System;
using Scada.AddIn.Contracts.Variable;
using System.Windows.Forms;

namespace EnkelExempelWizard
{
    public partial class Form1 : Form
    {

        public Form1(IDriverCollection drivers, string namn)
        {
            InitializeComponent();

            this.label2.Text = namn;

            if (drivers == null || drivers.Count < 1)
                return;

            foreach (IDriver zdriver in drivers)
            {
                this.listBox1.Items.Add(zdriver.Identification + " : " + zdriver.Name + "\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
