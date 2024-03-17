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
    public partial class SplitLineSelectionForm : Form
    {
        public decimal LineNumber
        {
            get { return lineNumberBox.Value; }
            set
            {
                lineNumberBox.Value = value;
                lineNumberBox.SelectAll();
            }
        }
        public decimal LineStyle
        {
            get { return lineStyleBox.Value; }
            set
            {
                lineStyleBox.Value = value;
                lineStyleBox.SelectAll();
            }
        }

        public SplitLineSelectionForm()
        {
            InitializeComponent();
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
            buttonOK.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            lineNumberBox.Minimum = -6m;
            lineNumberBox.Maximum = 6m;
            lineNumberBox.Increment = 1m;
            lineNumberBox.DecimalPlaces = 0;
            lineNumberBox.Value = 1;

            lineStyleBox.Minimum = 1m;
            lineStyleBox.Maximum = 100000m;
            lineStyleBox.Increment = 1m;
            lineStyleBox.DecimalPlaces = 0;
            lineStyleBox.Value = 1;
        }
    }
}
