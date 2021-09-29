using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atrapame.Entidades;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(this.txtLitros.Text == "" || this.txtKilometros.Text == "")
            {
                throw new ParametrosVaciosException("Alguno de los campos está vació");
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
