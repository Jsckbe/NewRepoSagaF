﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagaFalabellaRetail
{
    public partial class SagaFalabellaInicio : Form
    {
        public SagaFalabellaInicio()
        {
            InitializeComponent();
        }

        private void SagaFalabellaInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //instancia del nuevo formulario
            FrmRegistros formRegistros= new FrmRegistros();
            formRegistros.Show();
        }
    }
}
