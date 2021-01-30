using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FBastidor : Form
    {
        public FBastidor()
        {
            InitializeComponent();
        }

        public string getNumBastidor()
        {
            return this.txBastidor.Text;
        }

    }
}
