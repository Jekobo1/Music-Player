using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class frmSavePLaylist : Form
    {
        public frmSavePLaylist(string[] value)
        {
            InitializeComponent();
            for (int i = 0; i < value.Length; i++)
            {
                listBoxSavePL.Items.Add(value[i]);
            }
            
        }
        

        private void frmSavePLaylist_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
