using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasMDS.Presentacion
{
    public partial class frmCtrlMateriales : Form
    {
        public frmCtrlMateriales()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string material = cbMateriales.Text;
            string cantidad = numMateriales.Text;
            dgvMateriales.Rows.Add(material, cantidad);
        }
    }
}
