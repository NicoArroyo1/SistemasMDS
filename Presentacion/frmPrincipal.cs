﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            MostrarFormHerramientasEnSplit();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            MostrarFormMaterialesEnSplit();
        }


        private void MostrarFormHerramientasEnSplit()
        {
            splitContainer2.Panel2.Controls.Clear();
            frmInsumos form = new frmInsumos();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(form);
            form.Show();
        }

        private void MostrarFormMaterialesEnSplit()
        {
            splitContainer2.Panel2.Controls.Clear();
            Form3 form3 = new Form3();
            form3.TopLevel = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(form3);
            form3.Show();
        }

        private void MostrarFormCtrlHerramientasEnSplit()
        {
            frmCtrlMateriales form2 = new frmCtrlMateriales();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(form2);
            form2.Show();
        }

        private void MostrarFormCtrlMaterialesEnSplit()
        {
            frmCtrlMateriales form2 = new frmCtrlMateriales();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            splitContainer2.Panel2.Controls.Add(form2);
            form2.Show();
        }






        
    }
}
