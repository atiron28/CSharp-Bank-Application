using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace proiectPAW
{
    internal class Card : Account
    {
        private int num;
        private string name_acc;
        private string numar;
        private string tip;
        private int suma;
        private int pin;

        public Card():base()
        {
            num= 0;
            name_acc = "ANONIM";
            numar = "0000000";
            tip = "Anonim";
            suma = 0;
        }
        public Card(int id, string numar, string tip,int suma,string name):base(name)
        {
            this.num = id;
            this.name_acc = name;
            this.numar = numar;
            this.tip = tip;
            this.suma = suma;
           
        }

        public int Id1 { get => num; set => num = value; }
        public string Name_acc { get => name_acc; set => name_acc = value; }
        public string Numar { get => numar; set => numar = value; }
        public string Tip { get => tip; set => tip = value; }
      
        public int Suma { get => suma; set => suma = value; }
        public int Pin { get => pin; set => pin = value; }

        public override string ToString()
        {
            return "ID: " + num + "\nNumar Card: " + numar + "\nNume Detinator: " + name_acc + "\nTip Card: " + tip + "\nSuma: " + suma + "\n";
        }
    }
}
