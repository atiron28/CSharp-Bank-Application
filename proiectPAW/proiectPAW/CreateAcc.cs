using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Serialization.Formatters.Binary;

namespace proiectPAW
{
    
    public partial class CreateAcc : Form
    {
        
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void CreateAcc_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();
            l.Show();
            Hide();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.Name = numeBox.Text;
            ac.Email = emailBox.Text;
            ac.Phone = tlfBox.Text;
            ac.New_password = newpassBox.Text;
            ac.New_username = newuserBox.Text;
           

            Regex s = new Regex("^[a-zA-Z][a-zA-Z0-9]{5,11}$");
            Regex n = new Regex("^\\S+@\\S+\\.\\S+$");
            Regex k = new Regex("^\\+?[1-9][0-9]{7,14}$");
            Regex m = new Regex("^[A-Z][\\p{L}\\p{M}' \\.\\-]+$");
            bool pas = s.IsMatch(ac.New_password);
            bool usr = s.IsMatch(ac.New_username);
            bool email = n.IsMatch(ac.Email);
            bool telefon = k.IsMatch(ac.Phone);
            bool nume = m.IsMatch(ac.Name);


            int ok = 1;


            if (ac.Name == "")
            {

                errorProvider6.SetError(numeBox, "Introduceti numele");
                ok = 0;
            }
            else if(nume == false)
            {
                errorProvider14.SetError(numeBox, "Nume incorect");
                ok = 0;
            }
            else
            {
                errorProvider6.Clear();
                errorProvider14.Clear();
            }


            if (ac.Phone == "")
            {
                errorProvider4.SetError(tlfBox, "Introduceti numarul de telefon");
                ok = 0;
            }
            else if(telefon == false)
            {
                errorProvider13.SetError(tlfBox, "Numar de telefon incorect");
                ok = 0;
            }
            else
            {
                errorProvider4.Clear();
                errorProvider13.Clear();
            }


            if (genBox.Text == "")
            {
                errorProvider5.SetError(genBox, "Selectati genul!");
                ok = 0;
            }
            else
            {
                errorProvider5.Clear();
            }


            if (ac.Email == "")
            {
                errorProvider3.SetError(emailBox, "Introduceti emailul");
                ok = 0;
            }
            else if(email==false)
            {   
                errorProvider12.SetError(emailBox, "Email incorect");
                ok = 0; 
            }
            else
            {
                errorProvider3.Clear();
                errorProvider12.Clear();
            }


            if (ac.New_username == "")
            {
                errorProvider1.SetError(newuserBox, "Introduceti username-ul");
                ok = 0;
                
            }
            else if(usr == false )
                {
                errorProvider9.SetError(newuserBox, "Username incorect");
                ok = 0;
            }
            else
            {
                errorProvider1.Clear();
                errorProvider9.Clear();
            }


            if (ac.New_password == "")
            {
                errorProvider2.SetError(newpassBox, "introduceti parola");
                ok = 0;
            }
            else
            if (ac.New_password.Length < 5)
            {
                errorProvider10.SetError(newpassBox, "Parola prea mica");
                ok = 0;
            }
            else if (pas == true)
            {
                errorProvider11.SetError(newpassBox, "Parola incorecta");
                ok = 0;
            }
            else
            {
                errorProvider2.Clear();
                errorProvider10.Clear();
                errorProvider11.Clear();
            }

            if (ok == 1)
            {

                LoginPage l = new LoginPage();
                l.Show();
                this.Close();
            }
                
        }
        
    


        

    



        private void label7_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void genBox_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void pictureBox1_Click(object sender, EventArgs e)
         {


        }

        private void newpassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvareInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.Name = numeBox.Text;
            ac.Email = emailBox.Text;
            ac.Phone = tlfBox.Text;
            ac.New_password = newpassBox.Text;
            ac.New_username = newuserBox.Text;
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(ac.Name);
                sw.WriteLine(ac.Phone);
                sw.WriteLine(genBox.Text);
                sw.WriteLine(ac.Email);
                sw.WriteLine(ac.New_username);
                sw.WriteLine(ac.New_password);
                sw.Close();

                numeBox.Clear();
                tlfBox.Clear();
                emailBox.Clear();
                genBox.Refresh();
                newuserBox.Clear();
                newpassBox.Clear();
            }
        }

        private void citireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.Name = numeBox.Text;
            ac.Email = emailBox.Text;
            ac.Phone = tlfBox.Text;
            ac.New_password = newpassBox.Text;
            ac.New_username = newuserBox.Text;
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                ac.Name = sr.ReadToEnd();
                ac.Email = sr.ReadToEnd();
                ac.Phone = sr.ReadToEnd();
                genBox.Text = sr.ReadToEnd();
                ac.New_password = sr.ReadToEnd();
                ac.New_username = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            
            FileStream fs = new FileStream("fisier.dat",
                FileMode.Open, FileAccess.Read);
            textBox1.Text = (string)bf.Deserialize(fs);


            fs.Close();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat",
                FileMode.Create, FileAccess.Write);
            Account ac = new Account();
            ac.Name = numeBox.Text;
            ac.Email = emailBox.Text;
            ac.Phone = tlfBox.Text;
            ac.New_password = newpassBox.Text;
            ac.New_username = newuserBox.Text;
            bf.Serialize(fs, ac.Name);
            bf.Serialize(fs, ac.Email);
            bf.Serialize(fs, ac.Phone);
            bf.Serialize(fs, genBox.Text);
            bf.Serialize(fs, ac.New_password);
            bf.Serialize(fs, ac.New_username);

            fs.Close();
            numeBox.Clear();
            tlfBox.Clear();
            emailBox.Clear();
            newuserBox.Clear();
            newpassBox.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}



