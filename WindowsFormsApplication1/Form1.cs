using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttributeLibrary;

namespace WindowsFormsApplication1
{
    [Authorize("Admin")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConfigDefault()
        {
            button1.Enabled = false;
        }

        public void ConfigAdmin()
        {
            button1.Enabled = true;
        }
    }
}
