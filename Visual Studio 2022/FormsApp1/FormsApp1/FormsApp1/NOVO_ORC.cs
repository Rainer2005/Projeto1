using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class NOVO_ORC : Form
    {
        public NOVO_ORC()
        {
            InitializeComponent();
        }

        public static implicit operator TableLayoutPanel(NOVO_ORC NV)
        {
            //verificar
            throw new NotImplementedException();
        }
    }
}
