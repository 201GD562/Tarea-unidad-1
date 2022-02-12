using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // MOSTRAR EL CUADRO DE DIALOGO "ABRIR ARCHIVO". SI EL USUARIO HACE CLICK EN OK
            // CARGA LA IMAGEN QUE ELIGIO.

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //BORAR LA IMAGEN

            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // MOSTRAR EL CUADRO DE DIALOGO DE COLOR. SI EL USUARIO HACE CLICK EN OK,
            // CAMBIE EL FONDO DEL CONTROL PICTUREBOX AL COLOR QUE EL USUARIO ELIGIO.

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // CIERRA EL FORMULARIO

            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //SI EL USUARIO SELECCIONA LA CASILLA DE VERIFICACION ESTIRAR,
            // CAMBIA EL CUADRO DE IMAGEN.
            //PROPIEDAD SIZEMODE PARA "ESTIRAR". SI EL USUARIO BORRA
            //LA CASILLA DE VERIFICACION, CAMBIELA A "NORMAL".

            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
