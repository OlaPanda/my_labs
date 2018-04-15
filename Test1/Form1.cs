using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        List<Triangle> m_triangles = new List<Triangle> { };
        List<Isosceles> m_isosceles = new List<Isosceles> { };


        public Form1()
        {
            InitializeComponent();
        }

        private void AddTriangle_Click(object sender, EventArgs e)
        {
            Point point_A;
            double X = Convert.ToDouble(txtFirstCoord_X.Text == "" ? "0" : txtFirstCoord_X.Text);
            double Y = Convert.ToDouble(txtFirstCoord_Y.Text == "" ? "0" : txtFirstCoord_Y.Text);
            point_A = new Point(X, Y);

            Point point_B;
            X = Convert.ToDouble(txtSecondCoord_X.Text == "" ? "0" : txtSecondCoord_X.Text);
            Y = Convert.ToDouble(txtSecondCoord_Y.Text == "" ? "0" : txtSecondCoord_Y.Text);
            point_B = new Point(X, Y);

            Point point_C;
            X = Convert.ToDouble(txtThirdCoord_X.Text == "" ? "0" : txtThirdCoord_X.Text);
            Y = Convert.ToDouble(txtThirdCoord_Y.Text == "" ? "0" : txtThirdCoord_Y.Text);
            point_C = new Point(X, Y);

            m_triangles.Add(new Triangle(point_A, point_B, point_C));

            txtFirstCoord_X.Text = "";
            txtFirstCoord_Y.Text = "";
            txtSecondCoord_X.Text = "";
            txtSecondCoord_Y.Text = "";
            txtThirdCoord_X.Text = "";
            txtThirdCoord_Y.Text = "";
        }

        private void DisplayTriangles_Click(object sender, EventArgs e)
        {
            OutputTriangles.Text = "";

            String Result = "";
            for (int i = 0; i < m_triangles.Count; ++i)
                Result += m_triangles[i].ToString() + Environment.NewLine;

            OutputTriangles.Text = Result;
        }

        private void AddIsosceles_Click(object sender, EventArgs e)
        {
            Point point_A;
            double X = Convert.ToDouble(txtIsoscelesFirstCoord_X.Text == "" ? "0" : txtIsoscelesFirstCoord_X.Text);
            double Y = Convert.ToDouble(txtIsoscelesFirstCoord_Y.Text == "" ? "0" : txtIsoscelesFirstCoord_Y.Text);
            point_A = new Point(X, Y);

            Point point_B;
            X = Convert.ToDouble(txtIsoscelesSecondCoord_X.Text == "" ? "0" : txtIsoscelesSecondCoord_X.Text);
            Y = Convert.ToDouble(txtIsoscelesSecondCoord_Y.Text == "" ? "0" : txtIsoscelesSecondCoord_Y.Text);
            point_B = new Point(X, Y);

            Point point_C;
            X = Convert.ToDouble(txtIsoscelesThirdCoord_X.Text == "" ? "0" : txtIsoscelesThirdCoord_X.Text);
            Y = Convert.ToDouble(txtIsoscelesThirdCoord_Y.Text == "" ? "0" : txtIsoscelesThirdCoord_Y.Text);
            point_C = new Point(X, Y);

            m_isosceles.Add(new Isosceles(point_A, point_B, point_C));

            txtIsoscelesFirstCoord_X.Text = "";
            txtIsoscelesFirstCoord_Y.Text = "";
            txtIsoscelesSecondCoord_X.Text = "";
            txtIsoscelesSecondCoord_Y.Text = "";
            txtIsoscelesThirdCoord_X.Text = "";
            txtIsoscelesThirdCoord_Y.Text = "";
        }

        private void DisplayIsosceles_Click(object sender, EventArgs e)
        {
            OutputIsosceles.Text = "";

            String Result = "";
            for (int i = 0; i < m_isosceles.Count; ++i)
                Result += m_isosceles[i].ToString() + Environment.NewLine;

            OutputIsosceles.Text = Result;
        }

        private void TriangleSimilar_Click(object sender, EventArgs e)
        {
            OutputTriangles.Text = "In the morning I will make a commit with similar triangles and correct the interface. I make all the labs, but I forgot my own";
        }

        private void BiggestAreaIsosceles_Click(object sender, EventArgs e)
        {

            String Result = "";

            int max_area_index = 0;
            double max_area = 0;

            for (int i = 0; i < m_isosceles.Count; ++i)
                if (max_area < m_isosceles[i].GetSquare())
                {
                    max_area_index = i;
                    max_area = m_isosceles[i].GetSquare();
                }

            if (m_isosceles.Count > 0)
                Result = m_isosceles[max_area_index].ToString();

            OutputIsosceles.Text = Result;
        }
    }
}
