using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MangalaCSharp
{

    public partial class Form2 : Form
    {
        int sayac = 0;
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
                for(int i=0; i<14; i++)
                {
                    if (i != 6 && i != 13)
                        dizi[i] = 0;
                }
                isimEslestir();
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
                this.Close();
            }

            else if (Convert.ToInt32(dizi[7].ToString()) == 0
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
                for (int i = 0; i < 14; i++)
                {
                    if (i != 6 && i != 13)
                        dizi[i] = 0;
                }
                isimEslestir();
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
                                    "KAZANAN BERABERE BİTTİ !!");
                }
                this.Close();
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
            int random = rasgele.Next(1);//2 DİYE DÜZELTİLECEK 

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
                dizi[0] = 4;
                dizi[1] = 4;
                dizi[2] = 4;
                dizi[3] = 4;
                dizi[4] = 4;
                dizi[5] = 4;
                dizi[6] = 0;
                dizi[7] = 4;
                dizi[8] = 4;
                dizi[9] = 4;
                dizi[10] = 4;
                dizi[11] = 4;
                dizi[12] = 4;
                dizi[13] = 0;

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
            kuyu1.Refresh();
            kuyu2.Refresh();
            kuyu3.Refresh();
            kuyu4.Refresh();
            kuyu5.Refresh();
            kuyu6.Refresh();
            kuyu7.Refresh();
            kuyu8.Refresh();
            kuyu9.Refresh();
            kuyu10.Refresh();
            kuyu11.Refresh();
            kuyu12.Refresh();
            kuyu13.Refresh();
            kuyu14.Refresh();
        }

        private void func(int id, int tas)
        {
            sayac++;
            // ******** taşları birer birer dağıtma kuralı eklendi ***********
            int i = id + 1;
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
            if (player1 == true && temp % 2 == 0 && i > 6)
            {
                dizi[6] = Convert.ToInt32(dizi[6].ToString()) + Convert.ToInt32(dizi[i].ToString());
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


            if (player1 == true && temp == 1 && i < 6)
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

            if (player2 == true && temp == 1 && i > 6 && i < 13)
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
            else if (player2 == true && i != 13)
            {
                oyuncuIkiKapat();
            }

            // ***********

            if (player2 == true && kolayRadioButton.Checked)
            {
                kolayYapayZeka();
            }
            else if (player2 == true && zorRadioButton.Checked)
            {
                zorYapayZeka();
            }

        }


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void kuyu1_Click(object sender, EventArgs e)
        {
            if (kuyu1.Text != "0")
            {
                func(0, Convert.ToInt32(kuyu1.Text));
            }
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
            if (kuyu4.Text != "0")
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            oyunuSifirla();
            if (player2 == true && kolayRadioButton.Checked)
            {
                kolayYapayZeka();

            }
            else if (player2 == true && zorRadioButton.Checked)
            {
                zorYapayZeka();
            }
        }

        public void kolayYapayZeka()
        {
            Random rastgele = new Random();
            int rastgeleSayi;
            do
            {
                rastgeleSayi = rastgele.Next(7, 13);
            } while (dizi[rastgeleSayi].Equals(0));

            if (rastgeleSayi == 7)
            {
                pictureVisibleFalse(7);
                kuyu8.PerformClick();
            }
            else if (rastgeleSayi == 8)
            {
                pictureVisibleFalse(8);
                kuyu9.PerformClick();
            }
            else if (rastgeleSayi == 9)
            {
                pictureVisibleFalse(9);
                kuyu10.PerformClick();
            }
            else if (rastgeleSayi == 10)
            {
                pictureVisibleFalse(10);
                kuyu11.PerformClick();
            }
            else if (rastgeleSayi == 11)
            {
                pictureVisibleFalse(11);
                kuyu12.PerformClick();
            }
            else if (rastgeleSayi == 12)
            {
                pictureVisibleFalse(12);
                kuyu13.PerformClick();
            }
        }

        public void zorYapayZeka()
        {
            Boolean oynadiMi = false;
            isimEslestir();
            // player1 oyuna başladı
            if (player2 == true && sayac == 1 && (diziKontrol(1, 5, 5, 5, 4, 4, 0, 4, 4, 4, 4, 4, 4, 0) ||
                               diziKontrol(4, 1, 5, 5, 5, 4, 0, 4, 4, 4, 4, 4, 4, 0) ||
                               diziKontrol(4, 4, 1, 5, 5, 5, 0, 4, 4, 4, 4, 4, 4, 0) ||
                               diziKontrol(4, 4, 4, 4, 1, 5, 1, 5, 4, 4, 4, 4, 4, 0) ||
                               diziKontrol(4, 4, 4, 4, 4, 1, 1, 5, 5, 4, 4, 4, 4, 0)))
            {
                pictureVisibleFalse(10);
                kuyu11.PerformClick();
            }
            else if (player2 == true && sayac == 2)
            {

                if ((diziKontrol(4, 4, 4, 4, 4, 1, 1, 5, 5, 4, 1, 5, 5, 1)))
                {
                    pictureVisibleFalse(7);
                    kuyu8.PerformClick();
                }
                else if ((diziKontrol(4, 4, 4, 4, 1, 5, 1, 5, 4, 4, 1, 5, 5, 1)) ||
                    (diziKontrol(4, 4, 4, 1, 5, 1, 2, 5, 5, 5, 4, 4, 4, 0)) ||
                    (diziKontrol(4, 4, 4, 1, 1, 6, 2, 5, 5, 4, 4, 4, 4, 0)) ||
                    (diziKontrol(4, 4, 4, 0, 6, 5, 1, 4, 4, 4, 4, 4, 4, 0)) ||
                    (diziKontrol(4, 4, 1, 2, 6, 6, 1, 4, 4, 4, 4, 4, 4, 0)) ||
                    (diziKontrol(4, 1, 5, 2, 6, 5, 1, 4, 4, 4, 4, 4, 4, 0)) ||
                    (diziKontrol(1, 5, 5, 2, 5, 5, 1, 4, 4, 4, 4, 4, 4, 0)))
                {
                    pictureVisibleFalse(10);
                    kuyu11.PerformClick();
                }
                else if ((diziKontrol(4, 4, 1, 5, 5, 5, 0, 4, 4, 4, 1, 5, 5, 1)) ||
                    (diziKontrol(4, 1, 5, 5, 5, 4, 0, 4, 4, 4, 1, 5, 5, 1)) ||
                    (diziKontrol(1, 5, 5, 5, 4, 4, 0, 4, 4, 4, 1, 5, 5, 1))
                    )
                {
                    pictureVisibleFalse(12);
                    kuyu13.PerformClick();
                }
            }

            else if (player2 == true && sayac == 3)
            {
                if ((diziKontrol(4, 4, 4, 1, 5, 1, 2, 5, 5, 5, 1, 5, 5, 1)))
                {
                    pictureVisibleFalse(9);
                    kuyu10.PerformClick();
                }
                else if ((diziKontrol(4, 4, 4, 1, 1, 6, 2, 5, 5, 4, 1, 5, 5, 1)) ||
                         (diziKontrol(4, 4, 4, 0, 6, 5, 1, 4, 4, 4, 1, 5, 5, 1)) ||
                         (diziKontrol(4, 4, 1, 2, 6, 6, 1, 4, 4, 4, 1, 5, 5, 1)) ||
                         (diziKontrol(4, 1, 5, 2, 6, 5, 1, 4, 4, 4, 1, 5, 5, 1)) ||
                         (diziKontrol(1, 5, 5, 2, 5, 5, 1, 4, 4, 4, 1, 5, 5, 1))
                         )
                {
                    pictureVisibleFalse(10);
                    kuyu11.PerformClick();
                }
            }
            else if (player2 == true && sayac == 4)
            {
                if ((diziKontrol(4, 4, 4, 4, 1, 2, 2, 2, 6, 5, 2, 6, 5, 1)) ||
                    (diziKontrol(4, 4, 1, 5, 5, 2, 1, 1, 6, 5, 2, 6, 5, 1)) ||
                    (diziKontrol(4, 1, 5, 5, 5, 1, 1, 1, 6, 5, 2, 6, 5, 1)) ||
                    (diziKontrol(1, 5, 5, 5, 4, 1, 1, 1, 6, 5, 2, 6, 5, 1)) ||
                    (diziKontrol(4, 4, 4, 4, 1, 1, 2, 6, 5, 5, 0, 6, 5, 1))
                   )
                {
                    pictureVisibleFalse(9);
                    kuyu10.PerformClick();
                }
                else if ((diziKontrol(4, 4, 4, 4, 0, 6, 1, 5, 4, 4, 0, 6, 5, 1))
                    )
                {
                    pictureVisibleFalse(11);
                    kuyu12.PerformClick();
                }
                else if ((diziKontrol(4, 4, 1, 5, 2, 6, 1, 5, 4, 4, 0, 6, 5, 1)) ||
                     (diziKontrol(4, 4, 4, 1, 5, 1, 2, 5, 5, 1, 2, 6, 6, 2)))
                {
                    pictureVisibleFalse(7);
                    kuyu8.PerformClick();
                }
                else if ((diziKontrol(4, 1, 5, 5, 2, 5, 1, 5, 4, 4, 0, 6, 5, 1)) ||
                    (diziKontrol(1, 5, 5, 5, 1, 5, 1, 5, 4, 4, 0, 6, 5, 1)) ||
                    (diziKontrol(5, 5, 0, 5, 5, 1, 1, 5, 5, 5, 1, 5, 1, 4)) ||
                    (diziKontrol(5, 5, 0, 5, 1, 6, 1, 5, 5, 4, 1, 5, 1, 4)) ||
                    (diziKontrol(5, 5, 0, 1, 6, 6, 1, 5, 4, 4, 1, 5, 1, 4)) ||
                    (diziKontrol(5, 1, 1, 6, 6, 6, 0, 4, 4, 4, 1, 5, 1, 4)) ||
                    (diziKontrol(1, 6, 1, 6, 6, 5, 0, 4, 4, 4, 1, 5, 1, 4)) ||
                    (diziKontrol(5, 2, 0, 5, 5, 1, 1, 5, 5, 4, 1, 5, 1, 8)) ||
                    (diziKontrol(5, 2, 0, 5, 1, 5, 1, 5, 5, 4, 1, 5, 1, 8)) ||
                    (diziKontrol(5, 2, 0, 1, 6, 5, 1, 5, 4, 4, 1, 5, 1, 8)) ||
                    (diziKontrol(5, 1, 1, 5, 5, 4, 0, 4, 4, 4, 1, 5, 1, 8)) ||
                    (diziKontrol(1, 3, 1, 6, 6, 4, 0, 4, 4, 4, 1, 5, 1, 8)) ||
                    (diziKontrol(2, 6, 0, 5, 4, 1, 1, 5, 5, 4, 1, 5, 1, 8)) ||
                    (diziKontrol(2, 6, 0, 5, 1, 5, 1, 5, 4, 4, 1, 5, 1, 8)) ||
                    (diziKontrol(2, 6, 0, 1, 5, 5, 1, 5, 4, 4, 1, 5, 1, 8)) ||
                    (diziKontrol(1, 7, 0, 5, 4, 4, 0, 4, 4, 4, 1, 5, 1, 8)) ||
                    (diziKontrol(5, 1, 0, 5, 5, 4, 2, 4, 4, 4, 0, 5, 1, 8))
                   )
                {
                    pictureVisibleFalse(12);
                    kuyu13.PerformClick();
                }
            }
            else
            {
                    //*******HERHANGİ BİR KUYUYA BASINCA OYUN HAKKI TEKRAR BENDEYSE O BUTONA BASIYOR**//
                    if (dizi[12].Equals(1) || dizi[12].Equals(2))
                    {
                        pictureVisibleFalse(12);
                        kuyu13.PerformClick();
                    }
                    else if (dizi[11].Equals(3))
                    {
                        pictureVisibleFalse(11);
                        kuyu12.PerformClick();
                    }
                    else if (dizi[10].Equals(4))
                    {
                        pictureVisibleFalse(10);
                        kuyu11.PerformClick();
                    }
                    else if (dizi[9].Equals(5))
                    {
                        pictureVisibleFalse(9);
                        kuyu10.PerformClick();
                    }
                    else if (dizi[8].Equals(6))
                    {
                        pictureVisibleFalse(8);
                        kuyu9.PerformClick();
                    }
                    else if (dizi[7].Equals(7))
                    {
                        pictureVisibleFalse(7);
                        kuyu8.PerformClick();
                    }
                    //*******************************//
                    else
                    {
                    /***********************bilgisayarın son haznesindeki taşı alacaksa kaybetmemek için onu oynuyor*******/
                    if (Convert.ToInt32(dizi[5].ToString()) == 1 && Convert.ToInt32(dizi[7].ToString()) != 0)
                    {
                        butonaBas(7);
                        oynadiMi = true;
                        return;
                    }
                    /************************************************************************/
                    ///************rakipbin son taşı kendi haznesinde boş kuyuya geliyorsa taşlarımı kaybetmemek için karşısındaki kuyuya basıyor **///
                    int rakipSonIndex = 0;
                    
                    for (int i = 0; i < 6; i++)
                        {
                            if (Convert.ToInt32(dizi[i].ToString()) == 0)
                                continue;
                            else if (Convert.ToInt32(dizi[i].ToString()) == 1)
                                rakipSonIndex = i + Convert.ToInt32(dizi[i].ToString());
                            else if (Convert.ToInt32(dizi[i].ToString()) != 0 && Convert.ToInt32(dizi[i].ToString()) != 1)
                                rakipSonIndex = i + Convert.ToInt32(dizi[i].ToString()) - 1;

                            if (rakipSonIndex > 0 && rakipSonIndex < 6 && Convert.ToInt32(dizi[rakipSonIndex].ToString()) == 0)
                            {
                                if (player2 == true && rakipSonIndex == 1 && Convert.ToInt32(dizi[11].ToString()) != 0)
                                {
                                oynadiMi = true;
                                butonaBas(11);
                                
                                    break;
                                }
                                else if (player2 == true && rakipSonIndex == 2 && Convert.ToInt32(dizi[10].ToString()) != 0)
                                {
                                oynadiMi = true;
                                butonaBas(10);
                                    break;
                                }
                                else if (player2 == true && rakipSonIndex == 3 && Convert.ToInt32(dizi[9].ToString()) != 0)
                                {
                                oynadiMi = true;
                                butonaBas(9);
                                    break;
                                }
                                else if (player2 == true && rakipSonIndex == 4 && Convert.ToInt32(dizi[8].ToString()) != 0)
                                {
                                oynadiMi = true;
                                butonaBas(8);
                                    break;
                                }
                                else if (player2 == true && rakipSonIndex == 5 && Convert.ToInt32(dizi[7].ToString()) != 0)
                                {
                                oynadiMi = true;
                                butonaBas(7);
                                    break;
                                }

                            }

                         }

                    
                        int icindekiSayi, j = 0;
                   
                        for (int i = 12; i > 6; i--)
                        {
                            icindekiSayi = Convert.ToInt32(dizi[i].ToString());
                            if (icindekiSayi == 0)
                                continue;
                            //**************RAKİP BENİM BİR TAŞIMI ÇİFT YAPIP ALACAK İSE KAYBETMEMEK İÇİN O TUŞA BASIYORUM *********///////
                            for (int t = 0; t <= 5; t++)
                            {
                                if (Convert.ToInt32(dizi[t].ToString()) > 1 && Convert.ToInt32(dizi[t].ToString()) - 1 + t > 6 && Convert.ToInt32(dizi[Convert.ToInt32(dizi[t].ToString()) - 1 + t]) % 2 != 0)
                                {
                                    butonaBas(Convert.ToInt32(dizi[t].ToString()) - 1 + t);
                                    oynadiMi = true;
                                    break;                              
                                }
                            }
                        //////////////****************************************////////////////////
                        if (oynadiMi == true)
                            break;

                            /*****  KARŞI TARAFIN HERHANGİ BİR KUYUSUNU ÇİFT YAPARSA OYNUOR   *******////
                            icindekiSayi = Convert.ToInt32(dizi[i].ToString());
                            if (icindekiSayi - 1 + i > 13)
                            {
                                j = i + icindekiSayi - 15;
                                if (j < 0)
                                    j = 0;
                                if (Convert.ToInt32(dizi[j].ToString()) % 2 != 0 && player2 == true && j != 13 && Convert.ToInt32(dizi[i].ToString()) != 0)
                                {
                                    butonaBas(i);
                                oynadiMi = true;
                                    break;
                                }
                            }
                        /************************ ******************************/
                        if (oynadiMi == true)
                            break;

                        /*********** KENDİ ALANINDA SON TAŞI BOŞ KUYUYA GELİRSE KARŞI HAZNESİNİ ALMAK İÇİN OYNUYOR ***************/
                        int sonIndex;
                            if (icindekiSayi != 0 && icindekiSayi != 1)
                                sonIndex = i + icindekiSayi - 1;
                            else if (icindekiSayi != 0 && icindekiSayi == 1)
                                sonIndex = i + icindekiSayi;
                            else
                                continue;

                            if (sonIndex > 13)
                                sonIndex = sonIndex - 14;

                            if (sonIndex < 13 && sonIndex > 7 && Convert.ToInt32(dizi[sonIndex]) == 0 && player2 == true)
                            {
                                if (sonIndex == 12 && Convert.ToInt32(dizi[0].ToString()) != 0)
                                {
                                    butonaBas(i);
                                oynadiMi = true;
                                break;
                                }
                                else if (sonIndex == 11 && Convert.ToInt32(dizi[1].ToString()) != 0)
                                {
                                    butonaBas(i);
                                oynadiMi = true;
                                break;
                                }
                                else if (sonIndex == 10 && Convert.ToInt32(dizi[2].ToString()) != 0)
                                {
                                    butonaBas(i);
                                oynadiMi = true;
                                break;
                                }
                                else if (sonIndex == 9 && Convert.ToInt32(dizi[3].ToString()) != 0)
                                {
                                    butonaBas(i);
                                oynadiMi = true;
                                break;
                                }
                                else if (sonIndex == 8 && Convert.ToInt32(dizi[4].ToString()) != 0)
                                {
                                    butonaBas(i);
                                oynadiMi = true;
                                break;
                                }

                            }

                            /*************************************/

                        }
                    if (oynadiMi == true)
                        return ;
                    //******************* bilgisayar tarafında haznelerdeki toplan taş sayısı 10ten küçükse sondan basıyor****//

                    if (Convert.ToInt32(dizi[12].ToString()) +
                              Convert.ToInt32(dizi[11].ToString()) +
                              Convert.ToInt32(dizi[10].ToString()) +
                              Convert.ToInt32(dizi[9].ToString()) +
                              Convert.ToInt32(dizi[8].ToString()) +
                              Convert.ToInt32(dizi[7].ToString()) < 10)
                        {
                            for (int l = 7; l <= 12; l++)
                            {
                                if (Convert.ToInt32(dizi[l].ToString()) != 0)
                                {
                                    butonaBas(l);
                                oynadiMi = true;
                                    break;
                                }
                            }

                        }

                    else
                    {
                        ///*****en kötü koşul en büyük taşa sahip kuyuya basıyor *******/////
                        int max;
                        j = 0;
                        max = Convert.ToInt32(dizi[12].ToString());
                        for (int i = 12; i > 6; i--)
                        {
                            if (max <= Convert.ToInt32(dizi[i].ToString()))
                            {
                                max = Convert.ToInt32(dizi[i].ToString());
                                j = i;
                            }
                        }
                        butonaBas(j);

                        /////**********************************************///
                    }


                    }

                
            }

        }
        public void butonaBas(int j)
        {
            if (j == 12)
            {
                pictureVisibleFalse(12);
                kuyu13.PerformClick();
            }
            else if (j == 11)
            {
                pictureVisibleFalse(11);
                kuyu12.PerformClick();
            }
            else if (j == 10)
            {
                pictureVisibleFalse(10);
                kuyu11.PerformClick();
            }
            else if (j == 9)
            {
                pictureVisibleFalse(9);
                kuyu10.PerformClick();
            }
            else if (j == 8)
            {
                pictureVisibleFalse(8);
                kuyu9.PerformClick();
            }
            else if (j == 7)
            {
                pictureVisibleFalse(7);
                kuyu8.PerformClick();
            }
            isimEslestir();


        }

        public bool diziKontrol(int dizi0, int dizi1, int dizi2, int dizi3, int dizi4,
            int dizi5, int dizi6, int dizi7, int dizi8, int dizi9,
            int dizi10, int dizi11, int dizi12, int dizi13)
        {
            if (dizi[0].Equals(dizi0) &&
                dizi[1].Equals(dizi1) &&
                dizi[2].Equals(dizi2) &&
                dizi[3].Equals(dizi3) &&
                dizi[4].Equals(dizi4) &&
                dizi[5].Equals(dizi5) &&
                dizi[6].Equals(dizi6) &&
                dizi[7].Equals(dizi7) &&
                dizi[8].Equals(dizi8) &&
                dizi[9].Equals(dizi9) &&
                dizi[10].Equals(dizi10) &&
                dizi[11].Equals(dizi11) &&
                dizi[12].Equals(dizi12) &&
                dizi[13].Equals(dizi13))
            {
                return true;
            }

            return false;
        }

        public void oyunuSifirla()
        {
            arrayDoldur();
            isimEslestir();
            baslangicSirasi();
        }


        public void pictureVisibleFalse(int i)
        {
            Size size = new Size(62, 54);
            Size size1 = new Size(42, 34);
            refreshAllPicture();
            if (i == 7)
            {
                picture7.Visible = true;
                picture8.Visible = false;
                picture9.Visible = false;
                picture10.Visible = false;
                picture11.Visible = false;
                picture12.Visible = false;
                picture7.Size = size1;
                picture7.Refresh();
                System.Threading.Thread.Sleep(200);
                picture7.Size = size;

            }
            else if (i == 8)
            {
                picture7.Visible = false;
                picture8.Visible = true;
                picture9.Visible = false;
                picture10.Visible = false;
                picture11.Visible = false;
                picture12.Visible = false;
                picture8.Size = size1;
                picture8.Refresh();
                System.Threading.Thread.Sleep(200);
                picture8.Size = size;
            }
            else if (i == 9)
            {
                picture7.Visible = false;
                picture8.Visible = false;
                picture9.Visible = true;
                picture10.Visible = false;
                picture11.Visible = false;
                picture12.Visible = false;
                picture9.Size = size1;
                picture9.Refresh();
                System.Threading.Thread.Sleep(200);
                picture9.Size = size;
            }
            else if (i == 10)
            {
                picture7.Visible = false;
                picture8.Visible = false;
                picture9.Visible = false;
                picture10.Visible = true;
                picture11.Visible = false;
                picture12.Visible = false;
                picture10.Size = size1;
                picture10.Refresh();
                System.Threading.Thread.Sleep(200);
                picture10.Size = size;

            }
            else if (i == 11)
            {
                picture7.Visible = false;
                picture8.Visible = false;
                picture9.Visible = false;
                picture10.Visible = false;
                picture11.Visible = true;
                picture12.Visible = false;
                picture11.Size = size1;
                picture11.Refresh();
                System.Threading.Thread.Sleep(200);
                picture11.Size = size;
            }
            else if (i == 12)
            {
                picture7.Visible = false;
                picture8.Visible = false;
                picture9.Visible = false;
                picture10.Visible = false;
                picture11.Visible = false;
                picture12.Visible = true;
                picture12.Size = size1;
                picture12.Refresh();
                System.Threading.Thread.Sleep(200);
                picture12.Size = size;
            }
            refreshAllPicture();
            System.Threading.Thread.Sleep(1500);

        }
        private void refreshAllPicture()
        {
            picture7.Refresh();
            picture8.Refresh();
            picture9.Refresh();
            picture10.Refresh();
            picture11.Refresh();
            picture12.Refresh();
        }

    }

}