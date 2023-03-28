using System;

namespace proiectPAW
{
    [Serializable]
    internal class Account
    {
        private int id;
        private string name;
        private string phone;
        private char gen;
        private string email;
        private string new_password;
        private string new_username;

        public Account()
        {
            id = 0;
            name = "Anonim";
            phone = "00000";
            gen = 'N';
            email = "aaaa@aaa";
            new_username = "aaaaa";
            new_password = "aaaaaa";
        }
        public Account(string name)
        {
            this.name = name;
        }

        public Account(string new_username, string new_password)
        {
            
            this.new_username = new_username;
            this.new_password = new_password;
        }

        public Account(int id, string name, string phone, char gen, string email, string new_username, string new_password)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.gen = gen;
            this.email = email;
            this.new_username = new_username;
            this.new_password = new_password;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public char Gen { get => gen; set => gen = value; }
        public string Email { get => email; set => email = value; }
        public string New_password { get => new_password; set => new_password = value; }
        public string New_username { get => new_username; set => new_username = value; }

        public override string ToString()
        {
            string rezultat = name + "\n" + phone + "\n" + gen + "\n" + email + "\n" + new_password + "\n" + new_username+"\n";
          
            return rezultat;
        }
    }
}
