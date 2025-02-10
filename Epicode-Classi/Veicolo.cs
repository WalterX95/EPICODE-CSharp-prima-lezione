using System.Xml.Linq;

namespace Epicode_Classi
{
    public class Veicolo
    {
        private string _autoName;
        private int _numberRoutes;
        private string _autoColor;
        private string _autoTarga;

        public Veicolo(string autoName, int numberRoutes, string autoColor, string autoTarga) {

            _autoName = autoName;
            _numberRoutes = numberRoutes;
            _autoTarga = autoTarga;
            _autoColor = autoColor;

        }

        public string SetAutoName { get { return _autoName; } set { _autoName = value; } }
        public int SetNumberRoutes { get { return _numberRoutes; } set { _numberRoutes = value; } }

        public string SetAutoColor { get { return _autoColor; } set { _autoColor = value; } }

        public string SetAutoTarga {
            get { return _autoTarga; }
            set {
                _autoTarga = value;
                if(_autoTarga.Length > 6)
                {
                    Console.WriteLine("Targa con più di 6 caratteri, Targa non riconoscuta");
                }
            } }

   
      public void GetInfoVeicolo()
        {
            Console.WriteLine("Scheda Automobile ");
            Console.WriteLine("Nome Veicolo : " + _autoName);
            Console.WriteLine("Colore Telaio :" + _autoColor);
            Console.WriteLine("Targa Auto : " + _autoTarga);
        }
    }
}
