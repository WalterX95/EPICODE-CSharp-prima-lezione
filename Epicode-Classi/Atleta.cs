namespace Epicode_Classi
{
    public class Atleta
    {
        private string _name = string.Empty;
        private string _surname = string.Empty;
        private string _sex = string.Empty;
        private int _velocita = 0;

        public Atleta(string name, string surname, string sex, int velocita)
        {
            _name = name;
            _surname = surname;
            _sex = sex;
            _velocita = velocita;
        }
        public string SetName { 
            get
            {
                return _name;
            }
            set { 
                _name = value;
            }
        }
        public string SetSurname { 
           get
            {
                return _surname;
            }
            set { 
                _surname = value;
            }
        }

        public string SetSex {

            get {
               return _sex;
            }
            set {
                _sex = value;
            }
        }
        public int SetVelocita { 
        
           get
            {
                return _velocita;
            }

            set { 
                _velocita = value;
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Scheda Atleta");
            Console.WriteLine("Nome : " + _name);
            Console.WriteLine("Cognome :" + _surname);
            Console.WriteLine("Sesso : " + _sex);
            Console.WriteLine("Velocità: "+ _velocita);
        }
    }
}
