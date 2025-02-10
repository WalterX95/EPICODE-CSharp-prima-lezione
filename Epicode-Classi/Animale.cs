using System.Xml.Linq;

namespace Epicode_Classi
{
    public class Animale
    {
        private string _animalName;
        private string _animalType;
        private string _animalColor;

        public Animale(string animalName, string animalType, string animalColor)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalColor = animalColor;

        }

        public string SetAnimalName
        {
            get { return _animalName; }
            set { _animalName = value; }
        }

        public string SetAnimalType
        {
            get { return _animalType; }
            set { 
                
                _animalType = value;
                if(value == "Cavallo")
                {
                    Console.WriteLine("Spirit Cavallo Selvaggio");
                }
                else
                {
                    Console.WriteLine("E allora niente fra, niente Spirit");
                }
            }
        }

        public void GetInfoAnimale()
        {
            Console.WriteLine("Scheda Dipendente");
            Console.WriteLine("Nome Animale : " + _animalName);
            Console.WriteLine("Colore Animale :" + _animalColor);
            Console.WriteLine("Categoria Animale : " + _animalType);
        }
    }
}
