using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppWithAPIINtegration
{
    public partial class DataInputForm : Form
    {
        public DataInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Procedure procedure = new Procedure();
            procedure.Treatment=this.textBox1.Text;
            procedure.Medication = this.textBox2.Text;
            procedure.Dosage = this.textBox3.Text;
            this.Hide();

        }
    }
}
