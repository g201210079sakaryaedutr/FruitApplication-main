using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odevim
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private int counter = 60;
        private List<Citrus> citrus = new List<Citrus>();
        private double totalYield;
        private double totalVa;
        private double totalVc;
        private Citrus selectedCitrus = new Citrus();
        private List<OtherFriut> otherFriuts = new List<OtherFriut>();
        private OtherFriut selectedOtherFriut = new OtherFriut();
        private bool selected = true;

        private void getRandomFruit()
        {
            if (!selected)
                return;
            Random rnd = new Random();
            var imgIndex = rnd.Next(6);
            masterImage.Image = imageList1.Images[imgIndex];
            selectedCitrus = null;
            selectedOtherFriut = null;
            if (imgIndex <= 2)
            {
                selectedCitrus = citrus.Where(w => w.ImageIndex == imgIndex).FirstOrDefault();
                masterGramajLbl.Text = selectedCitrus.FruitName + " Gramaj " + selectedCitrus.Weight.ToString();
            }
            else
            {
                selectedOtherFriut = otherFriuts.Where(w => w.ImageIndex == imgIndex).FirstOrDefault();
                masterGramajLbl.Text = selectedOtherFriut.FruitName + " Gramaj " + selectedOtherFriut.Weight.ToString();
            }
        }
        private void baslaButton_Click(object sender, EventArgs e)
        {
            baslaButton.Visible = false;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            totalYield = 0;
            totalVa = 0;
            totalVc = 0;
            katiMeyveLbl.Text = "";
            masterGramajLbl.Text = "";
            meyvePureLbl.Text = "";
            pureVerimLbl.Text = "";
            pureVerimLbl.Text = "";
            toplamVerimLbl.Text = "";
            VerimKatiLbl.Text = "";
            counter = 60;







            timer1.Start();
            
            getRandomFruit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            { 
                timer1.Stop();
                baslaButton.Visible = true;

            }
            sureLabel.Text = "Kalan Süre " + counter.ToString() + " Saniye";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            citrus.Add(
                new Citrus
                {
                    FruitName = "Portakal",
                    Weight = 130,
                    VitaminAFor100g = 225,
                    VitaminCFor100g = 45,
                    ImageIndex = 0
                }
                );
            citrus.Add(
                new Citrus
                {
                    FruitName = "Mandalina",
                    Weight = 50,
                    VitaminAFor100g = 681,
                    VitaminCFor100g = 26,
                    ImageIndex = 1
                }
                );
            citrus.Add(
                new Citrus
                {
                    FruitName = "Greyfurt",
                    Weight = 110,
                    VitaminAFor100g = 3,
                    VitaminCFor100g = 44,
                    ImageIndex = 2
                }
                );

            otherFriuts.Add(
                new OtherFriut
                {
                    FruitName = "Elma",
                    Weight = 60,
                    VitaminAFor100g = 54,
                    VitaminCFor100g = 5,
                    ImageIndex = 3
                }
                );
            otherFriuts.Add(
                new OtherFriut
                {
                    FruitName = "Armut",
                    Weight = 80,
                    VitaminAFor100g = 25,
                    VitaminCFor100g = 5,
                    ImageIndex = 4
                }
                );
            otherFriuts.Add(
                new OtherFriut
                {
                    FruitName = "Çilek",
                    Weight = 10,
                    VitaminAFor100g = 12,
                    VitaminCFor100g = 60,
                    ImageIndex = 5
                }
                );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (counter == 0)
                return;
            if (selectedCitrus == null)
                MessageBox.Show("Katı meyve sıkacağı kullanılmaz.");
            else
            {
                var minyield = selectedCitrus.YieldMin;
                var maxyield = selectedCitrus.YieldMax;
                Random rnd = new Random();
                var yield = rnd.Next(minyield, maxyield + 1);
                VerimKatiLbl.Text = "Verim : " + (yield/selectedCitrus.Weight  ).ToString("#0.00") + " Gram";
                VerimKatiLbl.Visible = true;
                totalYield += (yield/selectedCitrus.Weight  );                
                totalVa += (yield * selectedCitrus.VitaminAFor100g) / 100;
                totalVc += (yield * selectedCitrus.VitaminCFor100g) / 100;                
                toplamVerimLbl.Text = "Toplam Verim : " + totalYield.ToString("#0.00") + " Gram Vitamin A " + totalVa.ToString("#0.00") + " Vitamin C " + totalVc.ToString("#0.00");
                getRandomFruit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (counter == 0)
                return;
            if (selectedOtherFriut == null)
                MessageBox.Show("Meyve püre cihazı kullanılmaz.");
            else
            {
                var minyield = selectedOtherFriut.YieldMin;
                var maxyield = selectedOtherFriut.YieldMax;
                Random rnd = new Random();
                var yield = rnd.Next(minyield, maxyield + 1);
                pureVerimLbl.Text = "Verim : " + (yield/selectedOtherFriut.Weight ).ToString("#0.00") + " Gram";
                pureVerimLbl.Visible = true;
                totalYield += (yield / selectedOtherFriut.Weight);
                totalVa += (yield * selectedOtherFriut.VitaminAFor100g) / 100;                
                totalVc= (yield * selectedOtherFriut.VitaminCFor100g) / 100;
                toplamVerimLbl.Text = "Toplam Verim : " + totalYield.ToString("#0.00") + " Gram Vitamin A "+ totalVa.ToString("#0.00") + " Vitamin C "+totalVc.ToString("#0.00");
                getRandomFruit();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            katiMeyveLbl.Visible = true;
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            katiMeyveLbl.Visible = false;
            //VerimKatiLbl.Text = "";
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            meyvePureLbl.Visible = true;
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            meyvePureLbl.Visible = false;
            //pureVerimLbl.Text = "";
        }
    }
}
