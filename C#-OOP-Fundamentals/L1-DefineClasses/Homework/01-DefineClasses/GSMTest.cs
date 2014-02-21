namespace MobilePhone
{

    using System;
    using MobilePhone.Hardware;

    class GSMTest
    {
        public static void Test()
        {
            //Create an array of few instances of the GSM class.
            GSM[] gsmInfo = {
                            new GSM("M8", "HTC"),
                            new GSM("Z10", "BlackBerry", 440, null, 
                                new Display(),
                                new Battery("1800 mAh",null,null,Battery.BatteryTypes.LiIon) 
                                ),
                            new GSM("Moto G", "Motorola", 440, null, 
                                new Display(720,1280,4.5,32000000),
                                new Battery("2070 mAh",null,null,Battery.BatteryTypes.LiIon) 
                                )  
                        };

            //Display the information about the GSMs in the array.
            foreach (GSM item in gsmInfo)
            {
                Console.WriteLine(item);
                Console.WriteLine(new string('*', 20));
            }

            //Display the information about the static propertyIPhone4S.
            Console.WriteLine(GSM.IPhone);
        }
    }
}
