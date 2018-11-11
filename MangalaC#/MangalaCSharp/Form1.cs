using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangalaCSharp
{

    public partial class Form1 : Form
    {
        ArrayList dizi = new ArrayList();
        bool player1;
        bool player2;

        private void oyuncuBirKapat()
        {
            kuyu1.Enabled = false;
            kuyu2.Enabled = false;
            kuyu3.Enabled = false;
            kuyu4.Enabled = false;
            kuyu5.Enabled = false;
            kuyu6.Enabled = false;

            kuyu8.Enabled = true;
            kuyu9.Enabled = true;
            kuyu10.Enabled = true;
            kuyu11.Enabled = true;
            kuyu12.Enabled = true;
            kuyu13.Enabled = true;

            player1 = false;
            player2 = true;

            playerOne.BackColor = Color.Red;
            playerTwo.BackColor = Color.Green;
        }

        private void bitisKontrol()
        {
            if (Convert.ToInt32(dizi[0].ToString()) == 0
                && Convert.ToInt32(dizi[1].ToString()) == 0
                && Convert.ToInt32(dizi[2].ToString()) == 0
                && Convert.ToInt32(dizi[3].ToString()) == 0
                && Convert.ToInt32(dizi[4].ToString()) == 0
                && Convert.ToInt32(dizi[5].ToString()) == 0)
            {
                dizi[6] = Convert.ToInt32(dizi[6].ToString()) + Convert.ToInt32(dizi[7].ToString())
                        + Convert.ToInt32(dizi[8].ToString())
                        + Convert.ToInt32(dizi[9].ToString())
                        + Convert.ToInt32(dizi[10].ToString())
                        + Convert.ToInt32(dizi[11].ToString())
                        + Convert.ToInt32(dizi[12].ToString());
                if (Convert.ToInt32(dizi[6].ToString()) > Convert.ToInt32(dizi[13].ToString()))
                {
                    MessageBox.Show("1. Oyuncu : " + dizi[6].ToString() + "\n" +
                                    "2. Oyuncu : " + dizi[13].ToString() + "\n" +
                                    "KAZANAN BİRİNCİ OYUNCU !!");
                }
                else if (Convert.ToInt32(dizi[6].ToString()) < Convert.ToInt32(dizi[13].ToString()))
                {
                    MessageBox.Show("1. Oyuncu : " + dizi[6].ToString() + "\n" +
                                    "2. Oyuncu : " + dizi[13].ToString() + "\n" +
                                    "KAZANAN İKİNCİ OYUNCU !!");
                }
                else
                {
                    MessageBox.Show("1. Oyuncu : " + dizi[6].ToString() + "\n" +
                                    "2. Oyuncu : " + dizi[13].ToString() + "\n" +
                                    "OYUN BERABERE BİTTİ !!");
                }
                oyunuSifirla();
            }

                if (Convert.ToInt32(dizi[7].ToString()) == 0
                && Convert.ToInt32(dizi[8].ToString()) == 0
                && Convert.ToInt32(dizi[9].ToString()) == 0
                && Convert.ToInt32(dizi[10].ToString()) == 0
                && Convert.ToInt32(dizi[11].ToString()) == 0
                && Convert.ToInt32(dizi[12].ToString()) == 0)
            {
                dizi[13] = Convert.ToInt32(dizi[13].ToString()) + Convert.ToInt32(dizi[0].ToString())
                        + Convert.ToInt32(dizi[1].ToString())
                        + Convert.ToInt32(dizi[2].ToString())
                        + Convert.ToInt32(dizi[3].ToString())
                        + Convert.ToInt32(dizi[4].ToString())
                        + Convert.ToInt32(dizi[5].ToString());
                if (Convert.ToInt32(dizi[6].ToString()) > Convert.ToInt32(dizi[13].ToString()))
                {
                    MessageBox.Show("1. Oyuncu : " + dizi[6].ToString() + "\n" +
                                    "2. Oyuncu : " + dizi[13].ToString() + "\n" +
                                    "KAZANAN BİRİNCİ OYUNCU !!");
                }
                else if (Convert.ToInt32(dizi[6].ToString()) < Convert.ToInt32(dizi[13].ToString()))
                {
                    MessageBox.Show("1. Oyuncu : " + dizi[6].ToString() + "\n" +
                                    "2. Oyuncu : " + dizi[13].ToString() + "\n" +
                                    "KAZANAN İKİNCİ OYUNCU !!");
                }
                else
                {
                    MessageBox.Show("1. Oyuncu : " + dizi[6].ToString() + "\n" +
                                    "2. Oyuncu : " + dizi[13].ToString() + "\n" +
                                    "OYUN BERABERE BİTTİ !!");
                }
                oyunuSifirla();
            }
        }

        private void oyuncuIkiKapat()
        {
            kuyu8.Enabled = false;
            kuyu9.Enabled = false;
            kuyu10.Enabled = false;
            kuyu11.Enabled = false;
            kuyu12.Enabled = false;
            kuyu13.Enabled = false;

            kuyu1.Enabled = true;
            kuyu2.Enabled = true;
            kuyu3.Enabled = true;
            kuyu4.Enabled = true;
            kuyu5.Enabled = true;
            kuyu6.Enabled = true;

            playerOne.BackColor = Color.Green;
            playerTwo.BackColor = Color.Red;

            player1 = true;
            player2 = false;
        }

        private void baslangicSirasi()
        {
            Random rasgele = new Random();
            int random = rasgele.Next(3);
            if (random == 0)
            {
                playerOne.BackColor = Color.Green;
                playerTwo.BackColor = Color.Red;
                player1 = true;
                player2 = false;
                oyuncuIkiKapat();
            }
            else
            {
                playerOne.BackColor = Color.Red;
                playerTwo.BackColor = Color.Green;
                player1 = false;
                player2 = true;
                oyuncuBirKapat();
            }
        }
       
        private void arrayDoldur()
        {
            if (dizi.Count == 0)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (i == 6 || i == 13)
                        dizi.Add(0);
                    else
                        dizi.Add(4);
                }
            }
            else
            {
                dizi[0].Equals(4);
                dizi[1].Equals(4);
                dizi[2].Equals(4);
                dizi[3].Equals(4);
                dizi[4].Equals(4);
                dizi[5].Equals(4);
                dizi[6].Equals(0);
                dizi[7].Equals(4);
                dizi[8].Equals(4);
                dizi[9].Equals(4);
                dizi[10].Equals(4);
                dizi[11].Equals(4);
                dizi[12].Equals(4);
                dizi[13].Equals(0);
            }
        }
        private void isimEslestir()
        {
            kuyu1.Text = Convert.ToString(dizi[0].ToString());
            kuyu2.Text = Convert.ToString(dizi[1].ToString());
            kuyu3.Text = Convert.ToString(dizi[2].ToString());
            kuyu4.Text = Convert.ToString(dizi[3].ToString());
            kuyu5.Text = Convert.ToString(dizi[4].ToString());
            kuyu6.Text = Convert.ToString(dizi[5].ToString());
            kuyu7.Text = Convert.ToString(dizi[6].ToString());
            kuyu8.Text = Convert.ToString(dizi[7].ToString());
            kuyu9.Text = Convert.ToString(dizi[8].ToString());
            kuyu10.Text = Convert.ToString(dizi[9].ToString());
            kuyu11.Text = Convert.ToString(dizi[10].ToString());
            kuyu12.Text = Convert.ToString(dizi[11].ToString());
            kuyu13.Text = Convert.ToString(dizi[12].ToString());
            kuyu14.Text = Convert.ToString(dizi[13].ToString());

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baslangicSirasi();
            arrayDoldur();
            isimEslestir();
         //   kuyu8.PerformClick();      
        }

        private void kuyu1_Click(object sender, EventArgs e)
        {
            if (kuyu1.Text != "0")
            {
                func(0, Convert.ToInt32(kuyu1.Text));
            }
        }

        private void func(int id, int tas)
        {
            // ******** taşları birer birer dağıtma kuralı eklendi ***********
            int i = id+1;
            if (tas == 1)
            {
                dizi[id + 1] = (Convert.ToInt32(dizi[id + 1].ToString()) + 1);
                dizi[id] = 0;
                i++;
            }
            else
            {
                for (i = id; i < id + tas; i++)
                {
                    //karşı oyuncunun haznesine taş eklememek için
                    if (player1 == true && i == 13)
                    {
                        i++;
                        tas++;
                    }
                    if (player2 == true && i == 20)
                    {
                        i++;
                        tas++;
                    }
                    //*****
                    if (id == i)
                        dizi[id] = 1;
                    else if (i > 13)
                        dizi[i - 14] = (Convert.ToInt32(dizi[i - 14].ToString()) + 1);
                    else
                        dizi[i] = (Convert.ToInt32(dizi[i].ToString()) + 1);
                }
            }
            i--;
            // ******** ******

            // ***** Çift olunca alma kuralı *****
            if (i > 13) 
                i -= 14;
            int temp = Convert.ToInt32(dizi[i].ToString());            
            if (player1 == true && temp % 2 == 0 && i>6)
            {
                dizi[6] = Convert.ToInt32(dizi[6].ToString())+Convert.ToInt32(dizi[i].ToString());
                dizi[i] = 0;
                isimEslestir();
            }

            if (player2 == true && temp % 2 == 0 && i < 6)
            {
                dizi[13] = Convert.ToInt32(dizi[13].ToString()) + Convert.ToInt32(dizi[i].ToString());
                dizi[i] = 0;
                isimEslestir();
            }

            // *********

            // ********* 0 olan alan dolduğunda karşısındaki havuzu alma


            if (player1 == true && temp == 1 && i < 6 )
            {                
                if ((i) == 1)
                {
                    if (Convert.ToInt32(dizi[11].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[6] = Convert.ToInt32(dizi[6].ToString()) + Convert.ToInt32(dizi[11].ToString()) + 1;
                        dizi[11] = 0;
                    }
                }
                else if ((i) == 2)
                {
                    if (Convert.ToInt32(dizi[10].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[6] = Convert.ToInt32(dizi[6].ToString()) + Convert.ToInt32(dizi[10].ToString()) + 1;
                        dizi[10] = 0;
                    }
                }
                else if ((i) == 3)
                {
                    if (Convert.ToInt32(dizi[9].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[6] = Convert.ToInt32(dizi[6].ToString()) + Convert.ToInt32(dizi[9].ToString()) + 1;
                        dizi[9] = 0;
                    }
                }
                else if ((i) == 4)
                {
                    if (Convert.ToInt32(dizi[8].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[6] = Convert.ToInt32(dizi[6].ToString()) + Convert.ToInt32(dizi[8].ToString()) + 1;
                        dizi[8] = 0;
                    }
                }
                else if ((i) == 5)
                {
                    if (Convert.ToInt32(dizi[7].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[6] = Convert.ToInt32(dizi[6].ToString()) + Convert.ToInt32(dizi[7].ToString()) + 1;
                        dizi[7] = 0;
                    }
                }
             }

            if (player2 == true && temp == 1 && i > 6 && i<13)
            {
                if ((i) == 8)
                {
                    if (Convert.ToInt32(dizi[4].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[13] = Convert.ToInt32(dizi[13].ToString()) + Convert.ToInt32(dizi[4].ToString()) + 1;
                        dizi[4] = 0;
                    }
                }
                else if ((i) == 9)
                {
                    if (Convert.ToInt32(dizi[3].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[13] = Convert.ToInt32(dizi[13].ToString()) + Convert.ToInt32(dizi[3].ToString()) + 1;
                        dizi[3] = 0;
                    }
                }
                else if ((i) == 10)
                {
                    if (Convert.ToInt32(dizi[2].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[13] = Convert.ToInt32(dizi[13].ToString()) + Convert.ToInt32(dizi[2].ToString()) + 1;
                        dizi[2] = 0;
                    }
                }
                else if ((i) == 11)
                {
                    if (Convert.ToInt32(dizi[1].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[13] = Convert.ToInt32(dizi[13].ToString()) + Convert.ToInt32(dizi[1].ToString()) + 1;
                        dizi[1] = 0;
                    }
                }
                else if ((i) == 12)
                {
                    if (Convert.ToInt32(dizi[0].ToString()) != 0)
                    {
                        dizi[i] = 0;
                        dizi[13] = Convert.ToInt32(dizi[13].ToString()) + Convert.ToInt32(dizi[0].ToString()) + 1;
                        dizi[0] = 0;
                    }
                }
            }

            // ********************

            isimEslestir();
            bitisKontrol();
            //sıranın karşı oyuncuya geçme kuralı eklendi

            if (player1 == true && i != 6)
            {
                oyuncuBirKapat();
            }
            else if(player2==true && i!=13)
            {
                oyuncuIkiKapat();
            }

            // ***********

        }

        private void kuyu2_Click(object sender, EventArgs e)
        {
            if (kuyu2.Text != "0")
            {
                func(1, Convert.ToInt32(kuyu2.Text));
            }
        }

        private void kuyu3_Click(object sender, EventArgs e)
        {
            if (kuyu3.Text != "0")
            {
                func(2, Convert.ToInt32(kuyu3.Text));
            }
        }

        private void kuyu4_Click(object sender, EventArgs e)
        {
            if(kuyu4.Text!="0")
            {
                func(3, Convert.ToInt32(kuyu4.Text));
            }
        }

        private void kuyu5_Click(object sender, EventArgs e)
        {
            if (kuyu5.Text != "0")
            {
                func(4, Convert.ToInt32(kuyu5.Text));
            }
        }

        private void kuyu6_Click(object sender, EventArgs e)
        {
            if (kuyu6.Text != "0")
            {           
                func(5, Convert.ToInt32(kuyu6.Text));
            }
        }

        private void kuyu7_Click(object sender, EventArgs e)
        {
            if (kuyu7.Text != "0")
                func(6, Convert.ToInt32(kuyu7.Text));
        }

        private void kuyu8_Click(object sender, EventArgs e)
        {
            if (kuyu8.Text != "0")
            {
                func(7, Convert.ToInt32(kuyu8.Text));
            }
            
        }

        private void kuyu9_Click(object sender, EventArgs e)
        {
            if (kuyu9.Text != "0")
            {
                func(8, Convert.ToInt32(kuyu9.Text));
            }
        }

        private void kuyu10_Click(object sender, EventArgs e)
        {
            if (kuyu10.Text != "0")
            {
                func(9, Convert.ToInt32(kuyu10.Text));
            }
        }

        private void kuyu11_Click(object sender, EventArgs e)
        {
            if (kuyu11.Text != "0")
            {
                func(10, Convert.ToInt32(kuyu11.Text));
            }
        }

        private void kuyu12_Click(object sender, EventArgs e)
        {
            if (kuyu12.Text != "0")
            {
                func(11, Convert.ToInt32(kuyu12.Text));
            }
        }
            
        private void kuyu13_Click(object sender, EventArgs e)
        {
            if (kuyu13.Text != "0")
            {
                func(12, Convert.ToInt32(kuyu13.Text));
            }
        }
        public void oyunuSifirla()
        {
            arrayDoldur();
            isimEslestir();
            baslangicSirasi();
        }
    }
}