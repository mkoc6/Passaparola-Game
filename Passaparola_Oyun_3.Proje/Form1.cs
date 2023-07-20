using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyun_3.Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruno = 0, doğru = 0, yanlis = 0;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "Akdeniz") 
                        {
                            Btn1.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            Btn1.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            btn2.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn2.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text =="Cuma")
                        {
                            BTN3.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            BTN3.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "Diyarbakır")
                        {
                            BTN4.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            BTN4.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "Eski")
                        {
                            Btn5.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            Btn5.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Ferman")
                        {
                            btn6.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn6.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "Güneş")
                        {
                            btn7.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn7.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Halı")
                        {
                            btn8.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn8.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "Isparta")
                        {
                            btn9.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn9.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "İstanbul")
                        {
                            btn10.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn10.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "Jandarma")
                        {
                            btn11.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn11.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Kayısı")
                        {
                            btn12.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn12.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Lale")
                        {
                            btn13.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn13.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Mart")
                        {
                            btn14.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn14.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Ozan")
                        {
                            btn15.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn15.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Ney")
                        {
                            btn16.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn16.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "Pırasa")
                        {
                            btn17.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            BTN3.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Ren Geyiği")
                        {
                            btn18.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn18.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Snake")
                        {
                            btn19.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn19.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Tarkan")
                        {
                            btn20.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn20.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "Umut")
                        {
                            btn21.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn21.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "Volum")
                        {
                            btn22.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn22.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "Yıldırım")
                        {
                            btn23.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn23.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "Zeytin")
                        {
                            btn24.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            btn24.BackColor = Color.Red;
                            yanlis++;
                            label5.Text = yanlis.ToString();
                        }
                        break;


                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Next";
            soruno ++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin Güney Kısmındaki kıyı bölgesi?";
                Btn1.BackColor = Color.Yellow;
            }
            if (soruno ==2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
                btn2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Hafta içinin son günü?";
                BTN3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                BTN4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni Kelimesiniz zıt Anlamlısı?";
                Btn5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                btn6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                btn7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne gerirince bakıştığı nesne?";
                btn8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz";
                btn9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Türkiyenn En kalabalık ili?";
                btn10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk";
                btn11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatya'nın meşhur meyvesi?";
                btn12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                btn13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3.Ayı";
                btn14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                btn15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                btn16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmedi pirinç, havuç gibi sebzeler ile yapılan yemek?";
                btn17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Bir geyik çeşidi?";//ren geyiği
                btn18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizce yılan";
                btn19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin mega satırı";
                btn20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı";//umut
                btn21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "ingilizce ses seviyesii";//volume
                btn22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Doğadaki elektrik saçılımı";//yıldırım
                btn23.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "En uzun ömürlü ağaç (ege bölgesinde de yetişir)";
                btn24.BackColor = Color.Yellow;
            }

        }
    }
}
