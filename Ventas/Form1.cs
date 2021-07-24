using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaNegocios.Empleado empleado = new LogicaNegocios.Empleado();

                if (empleado.Login("Antonio", "Password"))
                {
                    MessageBox.Show("Conexion Satisfactoria");
                }
                else
                {
                    throw new Exception("Error de Conexión");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
