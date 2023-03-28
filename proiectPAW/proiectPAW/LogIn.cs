using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace proiectPAW
{
   
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            //LoginData l = new LoginData();
            //l.Username = textBox1.Text;
            //l.Password = textBox2.Text;
            //lb4.Text = l.Username + l.Password;

        
        LoginData lo = new LoginData();
            
        lo.Username = userBox.Text;
        lo.Password = passwBox.Text;
        if (lo.Username == "" && lo.Password == "")
        {
            MessageBox.Show("Username-ul si Parola nu au fost introduse");

        }
       
        
            
        
    }
  
    
   
        private void button2_Click(object sender, EventArgs e)
        {
            CreateAcc c = new CreateAcc();
            c.Show();
            Hide();



        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void myaccBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter("conturi.txt");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetareParola re = new ResetareParola();
            re.Show();
            
            
        }

        private void saveFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
