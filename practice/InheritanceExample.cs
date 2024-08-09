using System;

namespace practice
{
    internal class InheritanceExample
    {
    }
        public class Example
        {
            public static void Main(string[] args)
            {

                //TV tv = new TV(); we can't instantiate abstract class or interface
                
                
                SamsungTV samsungTV = new SamsungTV("LED", 55, "1440p");
                samsungTV.TurnOn();
                samsungTV.TurnOff();
                Console.WriteLine($"model : {samsungTV.Model}");
                Console.WriteLine("brand : " + samsungTV.Brand);
                

               
                SamsungSmartTV samsungSmartTV = new SamsungSmartTV("OLED Smart", 65, "4K", true);
                samsungSmartTV.TurnOn();
                samsungSmartTV.TurnOff();
                Console.WriteLine(samsungSmartTV.HasWiFi);

               TV tv = new SamsungTV("LCD", 35, "1080p");
               tv.TurnOn();
               tv.TurnOff();   

               TV tv2 = new SamsungSmartTV("QLED smart",55,"4k",true);
               tv2.TurnOn();
               tv2.TurnOff();

               SamsungTV stv = new SamsungSmartTV("POLED", 66, "2k",true);
               stv.TurnOn();
               stv.TurnOff();
               //Console.WriteLine(stv.HasWiFi);

               //SamsungSmartTV smartTV = new SamsungTV("LCD", 33, "1080p");
               //smartTV.TurnOn();
               //smartTV.TurnOff();


            }
        }

}
