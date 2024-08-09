namespace practice
{
    public class SamsungTV : TV
    {
        public string Resolution { get; set; } 

        
        public SamsungTV(string model, int screenSize, string resolution)
            : base("Samsung", model, screenSize) 
        {
            Resolution = resolution;
        }

        
        public override void TurnOn()
        {
            //base.TurnOn(); 
            Console.WriteLine($"Samsung TV Model {Model} with {Resolution} resolution is now ON.");
        }

        
        public override void TurnOff()
        {
            //base.TurnOff();
            Console.WriteLine($"Samsung TV Model {Model} is now OFF.");
        }
    }
}
