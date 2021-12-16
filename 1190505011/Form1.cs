using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1190505011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Drawing.Graphics GrafikCiz;

        Pen klm = new Pen(Color.Black, 2);

        double[,] Xekseni = new double[2, 4] { { 0, 0, 0, 1 }, { 2, 0, 0, 1 } };
        double[,] Yekseni = new double[2, 4] { { 0, 0, 0, 1 }, { 0, 2, 0, 1 } };
        double[,] Zekseni = new double[2, 4] { { 0, 0, 0, 1 }, { 0, 0, 2, 1 } };


        double[,] Tizometri = new double[4, 4] { { 0.707  ,-0.408, 0, 0},
                                                  { 0      , 0.816, 0, 0},
                                                  {-0.707  ,-0.408, 0, 0},
                                                  { 0      , 0    , 0, 0}
        };

        double[,] CisimNoktasi = new double[8, 4]{   {0,0,0,1},//A
                                                    {1,0,0,1},//B
                                                    {1,0,1,1},//C
                                                    {0,0,1,1},//D
                                                    {0,1,0,1},//E
                                                    {1,1,0,1},//F
                                                    {1,1,1,1},//G
                                                    {0,1,1,1} //H
            };

        double[,] XKenar = new double[12, 2]  { {0,1},
                                                {1,2},
                                                {2,3},
                                                {3,0},
                                                {4,5},
                                                {5,6},
                                                {6,7},
                                                {7,4},
                                                {0,4},
                                                {1,5},
                                                {2,6},
                                                {3,7},

        };
        

        private void button1_Click(object sender, EventArgs e)
        {
            


            GrafikCiz.DrawLine(klm, KHesaplaX(Xekseni[0, 0]), KHesaplaY(Xekseni[0, 1]), KHesaplaX(Xekseni[1, 0]), KHesaplaY(Xekseni[1, 1]));
            GrafikCiz.DrawLine(klm, KHesaplaX(Yekseni[0, 0]), KHesaplaY(Yekseni[0, 1]), KHesaplaX(Yekseni[1, 0]), KHesaplaY(Yekseni[1, 1]));
            GrafikCiz.DrawLine(klm, KHesaplaX(Zekseni[0, 0]), KHesaplaY(Zekseni[0, 1]), KHesaplaX(Zekseni[1, 0]), KHesaplaY(Zekseni[1, 1]));
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // X'=X*Tiz
            double[,] GeciciXekseni = new double[2, 4];
            double[,] GeciciYekseni = new double[2, 4];
            double[,] GeciciZekseni = new double[2, 4];

            int i, j, k;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    GeciciXekseni[i, j] = 0;
                    GeciciYekseni[i, j] = 0;
                    GeciciZekseni[i, j] = 0;




                    for (k = 0; k < 4; k++)
                    {
                        GeciciXekseni[i, j] += Xekseni[i, k] * Tizometri[k, j];    
                        GeciciYekseni[i, j] += Yekseni[i, k] * Tizometri[k, j];
                        GeciciZekseni[i, j] += Zekseni[i, k] * Tizometri[k, j];
                    }
                }

            }

            GrafikCiz.DrawLine(klm, KHesaplaX(GeciciXekseni[0, 0]), KHesaplaY(GeciciXekseni[0, 1]), KHesaplaX(GeciciXekseni[1, 0]), KHesaplaY(GeciciXekseni[1, 1]));
            GrafikCiz.DrawLine(klm, KHesaplaX(GeciciYekseni[0, 0]), KHesaplaY(GeciciYekseni[0, 1]), KHesaplaX(GeciciYekseni[1, 0]), KHesaplaY(GeciciYekseni[1, 1]));
            GrafikCiz.DrawLine(klm, KHesaplaX(GeciciZekseni[0, 0]), KHesaplaY(GeciciZekseni[0, 1]), KHesaplaX(GeciciZekseni[1, 0]), KHesaplaY(GeciciZekseni[1, 1]));

        }



        private void Form_Paint(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

            GrafikCiz = this.CreateGraphics();
        }
        private int KHesaplaX(double geciciX)
        {

            return Convert.ToInt32(400 + (100*geciciX ));
        }
        private int KHesaplaY(double geciciY)
        {

            return Convert.ToInt32(250 + (-100 *geciciY  ));
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            this.Invalidate();

            xOlcekle.Text = "";
            yOlcekle.Text = "";
            zOlcekle.Text = "";
            xOteleText.Text = "";
            yOteleText.Text = "";
            zOteleText.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //X'=X*Tiz
            double[,] GeciciBKub = new double[8,4];

            int i, j, k;
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 4; j++)
                {

                    GeciciBKub[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        GeciciBKub[i, j] += CisimNoktasi[i, k] * Tizometri[k, j];

                    }
                }
                    
            }
            klm.Color = Color.BurlyWood;
            klm.Width = 1;

            for (i = 0; i < 12; i++)
            {

                GrafikCiz.DrawLine(klm, KHesaplaX(GeciciBKub[Convert.ToInt16(XKenar[i,0]),0]), KHesaplaY(GeciciBKub[Convert.ToInt16(XKenar[i, 0]), 1]), KHesaplaX(GeciciBKub[Convert.ToInt16(XKenar[i, 1]), 0]), KHesaplaY(GeciciBKub[Convert.ToInt16(XKenar[i, 1]), 1]));
            }

        }
       
        private void otele_Click(object sender, EventArgs e)
        {
            if (!xOteleText.Text.Equals("") && !yOteleText.Text.Equals("") && !zOteleText.Text.Equals("")) {
                int x = Convert.ToInt32(xOteleText.Text);
                int y = Convert.ToInt32(yOteleText.Text);
                int z = Convert.ToInt32(zOteleText.Text);

                double[,] GeciciBKub = new double[8, 4];         
                double[,] yerelXCisimNokta = new double[8, 4]{{x,y,z,1},//A
                                                              {1+x,y,z,1},//B
                                                              {1+x,y,1+z,1},//C
                                                              {x,y,1+z,1},//D
                                                              {x,1+y,z,1},//E
                                                              {1+x,1+y,z,1},//F
                                                              {1+x,1+y,1+z,1},//G
                                                              {x,1+y,1+z,1} //H
            };

                int i, j, k;
                for (i = 0; i < 8; i++)
                {
                    for (j = 0; j < 4; j++)
                    {

                        GeciciBKub[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            GeciciBKub[i, j] += yerelXCisimNokta[i, k] * Tizometri[k, j];

                        }
                    }

                }
                klm.Color = Color.Blue;
                klm.Width = 1;

                for (i = 0; i < 12; i++)
                {

                    GrafikCiz.DrawLine(klm, KHesaplaX(GeciciBKub[Convert.ToInt16(XKenar[i, 0]), 0]), KHesaplaY(GeciciBKub[Convert.ToInt16(XKenar[i, 0]), 1]), KHesaplaX(GeciciBKub[Convert.ToInt16(XKenar[i, 1]), 0]), KHesaplaY(GeciciBKub[Convert.ToInt16(XKenar[i, 1]), 1]));
                }



            }
        }

            

        private void xOteleText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void yOteleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void zOteleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Olcekle_Click(object sender, EventArgs e)
        {
            if (!xOlcekle.Text.Equals("") && !yOlcekle.Text.Equals("") && !zOlcekle.Text.Equals("")) {
                int x = Convert.ToInt32(xOlcekle.Text);
                int y = Convert.ToInt32(yOlcekle.Text);
                int z = Convert.ToInt32(zOlcekle.Text);
                double[,] GeciciBKub = new double[8, 4];
                double[,] yerelXCisimNokta = new double[8, 4]{   {0,0,0,1},//A
                                                    {1*x,0,0,1},//B
                                                    {1*x,0,1*z,1},//C
                                                    {0,0,1*z,1},//D
                                                    {0,1*y,0,1},//E
                                                    {1*x,1*y,0,1},//F
                                                    {1*x,1*y,1*z,1},//G
                                                    {0,1*y,1*z,1} //H
            };

                double[,] tOlecek = new double[4, 4] { { 0.707  ,-0.408, 0, 0},
                                                  { 0      , 0.816, 0, 0},
                                                  {-0.707  ,-0.408, 0, 0},
                                                  { 0      , 0    , 0, 0}
        };

                int i, j, k;
                for (i = 0; i < 8; i++)
                {
                    for (j = 0; j < 4; j++)
                    {

                        GeciciBKub[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            GeciciBKub[i, j] += yerelXCisimNokta[i, k] * Tizometri[k, j];

                        }
                    }

                }
                klm.Color = Color.Black;
                klm.Width = 1;

                for (i = 0; i < 12; i++)
                {

                    GrafikCiz.DrawLine(klm, KHesaplaX(GeciciBKub[Convert.ToInt16(XKenar[i, 0]), 0]), KHesaplaY(GeciciBKub[Convert.ToInt16(XKenar[i, 0]), 1]), KHesaplaX(GeciciBKub[Convert.ToInt16(XKenar[i, 1]), 0]), KHesaplaY(GeciciBKub[Convert.ToInt16(XKenar[i, 1]), 1]));
                }

            }

        }

        private void xOlcekle_TextChanged(object sender, EventArgs e)
        {

        }

        private void yOlcekle_TextChanged(object sender, EventArgs e)
        {

        }

        private void zOlcekle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
