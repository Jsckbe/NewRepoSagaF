using System;
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
    public partial class FrmRegistros : Form
    {
        public FrmRegistros()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //instancia del nuevo formulario
            RegistroUsuario formUsuario = new RegistroUsuario();
            formUsuario.Show();
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            //instancia del nuevo formulario
            RegistroTrabajador formTrabajador = new RegistroTrabajador();
            formTrabajador.Show();
        }
    }
}
