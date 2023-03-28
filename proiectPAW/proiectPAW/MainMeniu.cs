using System;
using System.Windows.Forms;

namespace proiectPAW
{
    public partial class MainMeniu : Form
    {
        public MainMeniu()
        {
            InitializeComponent();
        }

        private void MainMeniu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void myaccBox_Click(object sender, EventArgs e)
        {
            ViewAcc v = new ViewAcc();
            v.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Transferuri tr = new Transferuri();
            tr.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdaugaCard adb = new AdaugaCard();
            adb.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AdaugaBani adauga = new AdaugaBani();
            adauga.Show();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            RetrageBani retrage = new RetrageBani();
            retrage.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SoldCont soldCont = new SoldCont();
            soldCont.Show();
            this.Close();
        }
    }
}
