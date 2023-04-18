using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bir_Islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele= new Random();
        int sayisayac = 0;
        int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7;

        

        private void BtnYeniOyun_Click(object sender, EventArgs e)
        {
            Btnsayi1.Visible = false;
            Btnsayi2.Visible = false;
            Btnsayi3.Visible = false;
            Btnsayi4.Visible = false;
            Btnsayi5.Visible = false;
            Btnsayi6.Visible = false;
            Btnsayi7.Visible = false;
            label1.Visible = false;
            richTextBox1.Text = "";
            sayisayac = 0;
           

        }



        int sayilar1;
        int sayilar2;
        int[] dizi1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] dizi2 = {  10, 20, 30, 40, 50, 60, 70, 80, 90 };
        private void Btnsayigetir_Click(object sender, EventArgs e)
        {
            sayisayac++;

            if(sayisayac == 1) 
            {
                sayilar1=rastgele.Next(0,dizi1.Length);
                sayi1 = (dizi1[sayilar1]);
                Btnsayi1.Text = sayi1.ToString();
                Btnsayi1.Visible= true;
            }
            if (sayisayac == 2)
            {
                sayilar1 = rastgele.Next(0, dizi1.Length);
                sayi2 = (dizi1[sayilar1]);
                Btnsayi2.Text = sayi2.ToString();
                Btnsayi2.Visible = true;
            }
            if (sayisayac == 3)
            {
                sayilar1 = rastgele.Next(0, dizi1.Length);
                sayi3 = (dizi1[sayilar1]);
                Btnsayi3.Text = sayi3.ToString();
                Btnsayi3.Visible = true;
            }
            if (sayisayac == 4)
            {
                sayilar1 = rastgele.Next(0, dizi1.Length);
                sayi4 = (dizi1[sayilar1]);
                Btnsayi4.Text = sayi4.ToString();
                Btnsayi4.Visible = true;
            }
            if (sayisayac == 5)
            {
                sayilar1 = rastgele.Next(0, dizi1.Length);
                sayi5 = (dizi1[sayilar1]);
                Btnsayi5.Text = sayi5.ToString();
                Btnsayi5.Visible = true;
            }
            if (sayisayac == 6)
            {
                sayilar2 = rastgele.Next(0, dizi2.Length);
                sayi6 = (dizi2[sayilar2]);
                Btnsayi6.Text = sayi6.ToString();
                Btnsayi6.Visible = true;
            }
            if (sayisayac == 7)
            {
                sayi7 = rastgele.Next(100, 999);
                Btnsayi7.Text = sayi7.ToString();
                Btnsayi7.Visible = true;
                label1.Visible= true;
                Hesapla();
               
                


            }

             void Hesapla()
            {

                sayi3 = sayi7;
                // sayi1,sayi2 diye çağırılırsa değişiklik yaparken zorlanırız ve verimsiz olur.
                int[] sayilar = new int[] { Convert.ToInt32(Btnsayi1.Text), Convert.ToInt32(Btnsayi2.Text), Convert.ToInt32(Btnsayi3.Text), Convert.ToInt32(Btnsayi4.Text), Convert.ToInt32(Btnsayi5.Text), Convert.ToInt32(Btnsayi6.Text) };
               // Fisher - Yates shuffle algoritması kullanıldı.
                while (true)
                {
                    int num = rastgele.Next(6);
                    int temp = sayilar[num];
                    sayilar[num] = sayilar[0];
                    sayilar[0] = temp;

                    int toplam = sayilar[0];
                    string sonuc = sayilar[0].ToString();

                    int sayac = rastgele.Next(1, 7);

                    for (int i = 1; i < sayac; i++)
                    {
                        int islem = rastgele.Next(4);

                        if (islem == 0)
                        {
                            toplam += sayilar[i];
                            sonuc += " + " + sayilar[i].ToString();
                        }
                        if (islem == 1)
                        {
                            toplam -= sayilar[i];
                            sonuc += " - " + sayilar[i].ToString();
                        }
                        if (islem == 2)
                        {
                            toplam *= sayilar[i];
                            sonuc += " x " + sayilar[i].ToString();
                        }
                        if (islem == 3)
                        {
                            if (toplam % sayilar[i] != 0) continue;
                            toplam /= sayilar[i];
                            sonuc += " / " + sayilar[i].ToString();
                        }
                    }
                    sonuc += " = " + toplam.ToString();

                    if (toplam == sayi3)
                    {
                        richTextBox1.Text ="islem sonucunuz\n" +sonuc;
                        break;
                    }
                }
            }
        }

        }












        }
    

