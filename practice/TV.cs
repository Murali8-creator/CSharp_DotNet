using System;

namespace practice
{
    public abstract class TV
    {

        private string _brand;
        private string _model;
        private int _screenSize;

    
        public TV(string brand, string model, int screenSize)
        {
            _brand = brand;
            _model = model;
            _screenSize = screenSize;
        }

        
        public virtual void TurnOn()
        {
            Console.WriteLine("The TV is now ON.");
        }


        public virtual void TurnOff()
        {
            Console.WriteLine("The TV is now OFF.");
        }

        public string Brand { get { return _brand; } }

        public string Model { get { return _model; } }

        public int ScreenSize { get { return _screenSize; } }
    }
}
