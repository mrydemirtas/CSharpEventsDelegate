using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEventsDelegate
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CSharpEventsDelegate.Structs.Location location = new Structs.Location();
            location.X = 15;
            location.Y = 20;

            //Int32.TryParse();


        }
    }
}
