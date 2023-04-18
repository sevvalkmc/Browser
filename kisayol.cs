using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class kisayol : Form
    {
        public kisayol()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void kisayol_Load(object sender, EventArgs e)
        {


            comboBox2.Items.Add("deneme");
            comboBox2.Items.Add("dsadeneme");
            comboBox2.Items.Add("densadsaeme");
            comboBox2.Items.Add("densadaseme");

            comboBox2.Items.Add("densadsadaseme");
        }
    }
}
