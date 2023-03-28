namespace proiectPAW
{
    internal class LoginData : Account
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public LoginData():base()
        {
            username = null;
            password = null;
        }
        public LoginData(string new_username, string new_password) : base(new_username, new_password)
        {
            this.username = new_username;
            this.password = new_password;
        }
        public override string ToString()
        {
            return "Username: " + username + "\nPassword: " + password; ;
        }
    }
}
