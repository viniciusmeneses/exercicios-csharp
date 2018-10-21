using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjExemploStatic
{
    public partial class frmExemploStatic : Form
    {
        private Cliente c1, c2, c3, c4, c5;

        private void frmExemploStatic_Load(object sender, EventArgs e)
        {

        }

        public frmExemploStatic()
        {
            InitializeComponent();
        }

        private void btnCria_Click(object sender, EventArgs e)
        {
            switch (Cliente.NroClientes)
            {
                case 0:
                    c1=new Cliente("Lia");
                    break;
                case 1:
                    c2=new Cliente("Jacira");
                    break;
                case 2:
                    c3 = new Cliente("Priscila");
                    break;
                case 3:
                    c4 = new Cliente("Darcy");
                    break;
                case 4:
                    c5 = new Cliente("Juca");
                    break;
            }
            txtNroClientes.Text = Cliente.NroClientes.ToString();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            switch (Cliente.NroClientes)
            {
                case 1:
                    c1 = null;
                    /*Chama o Garbage Collector*/
                    GC.Collect();
                    break;
                case 2:
                    c2 = null;
                    /*Chama o Garbage Collector*/
                    GC.Collect();
                    break;
                case 3:
                    c3 = null;
                    /*Chama o Garbage Collector*/
                    GC.Collect();
                    break;
                case 4:
                    c4 = null;
                    /*Chama o Garbage Collector*/
                    GC.Collect();
                    break;
                case 5:
                    c5 = null;
                    /*Chama o Garbage Collector*/
                    GC.Collect();
                    break;
            }
            txtNroClientes.Text = Cliente.NroClientes.ToString();
            
        }
    }
}
