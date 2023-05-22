using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotteri
{
    public partial class Form1 : Form
    {
        int lotteryNum = 1;
        string[] prices = { "", "Fortnite Monopol", "30 Among us stjärnor ", "'Hur man blir mästare på Among Us' Bok", "100 Robux", "100 kr presentkort på Arvids kycklingkorv", "Adodes tröja", "Adodes byxor", "Boll", "1 månads prenumeration till Bflix" };
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            lotteryNum = new Random().Next(1, 10);
            label1.Text = "Du vann";
            label2.Text = prices[lotteryNum];
            lotteryNum = 0;
        }
    }
}
