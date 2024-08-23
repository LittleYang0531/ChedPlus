using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ched.UI
{
    public partial class TickSelectionForm : Form
    {
        public decimal Tick
        {
            get { return numericUpDown1.Value; }
            set
            {
                numericUpDown1.Value = value;
                numericUpDown1.SelectAll();
            }
        }

        public TickSelectionForm()
        {
            InitializeComponent();
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
            buttonOK.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 1145141919810;
            numericUpDown1.Increment = 1;
            numericUpDown1.DecimalPlaces = 0;
            numericUpDown1.Value = 0;
        }
    }
}
