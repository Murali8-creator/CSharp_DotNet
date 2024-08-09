namespace practice
{
    
    public class SamsungSmartTV : SamsungTV
    {
       
        public bool HasWiFi { get; set; } 

        public SamsungSmartTV(string model, int screenSize, string resolution, bool hasWiFi)
            : base(model, screenSize, resolution) 
        {
            HasWiFi = hasWiFi;
        }

        public override void TurnOn()
        {
            // base.TurnOn(); 
            Console.WriteLine($"Samsung Smart TV Model {Model} with {Resolution} resolution is now ON.");
            if (HasWiFi)
            {
                Console.WriteLine("WiFi is enabled.");
            }
        }

        public override void TurnOff()
        {
            //base.TurnOff(); 
            Console.WriteLine($"Samsung Smart TV Model {Model} with {Resolution} resolution is now OFF.");
            if (HasWiFi)
            {
                Console.WriteLine("Disconnecting from WiFi.");
            }
        }
    }
}
