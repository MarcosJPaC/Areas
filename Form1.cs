using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            decimal resultado = ClassAreas.Cuadrado(Numdato1.Value);
            Lblcuadra2.Text = "A = LxL  " + "A= " + Numdato1.Value + "x" + Numdato1.Value + "   A= " + resultado;

        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            decimal resultadotriangulo = ClassAreas.Triangulo(NumTriangulo1.Value, NumTriangulo2.Value);
            lbltriangulo.Text = "A = BxH/2  " + "A= " + NumTriangulo1.Value + "x" + NumTriangulo2.Value + "   A= " + resultadotriangulo;

        }

        private void btnrectangulo_Click(object sender, EventArgs e)
        {
            decimal resultado = ClassAreas.Rectangulo(Numrectangulo1.Value, Numrectangulo2.Value);
            lblrectangulo.Text = "A = BxH  " + "A= " + Numrectangulo1.Value + "x" + Numrectangulo2.Value + "   A= " + resultado;
        }

        private void btnRombo_Click(object sender, EventArgs e)
        {
            decimal resultado = ClassAreas.Rombo(Numrombo1.Value, Numrombo2.Value);
            lblrombo.Text = "A = Dxd/2  " + "A= " + Numrombo1.Value + "x" + Numrombo2.Value + "   A= " + resultado;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
