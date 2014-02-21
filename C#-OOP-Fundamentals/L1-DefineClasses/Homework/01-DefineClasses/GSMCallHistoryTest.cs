namespace MobilePhone
{
    using MobilePhone.Hardware;
    using MobilePhone.CallManager;
    using System;

    class GSMCallHistoryTest
    {
        public static void Test()
        {
            //Create Instance of GSM
            GSM myMobile = new GSM("One", "HTC", 1240, "Pratchett, Terry",
                                new Display(720, 1280, 4.5, 64000000),
                                new Battery("2070 mAh", 300, 150, Battery.BatteryTypes.LiIon)
                                );

            //Add some calls to CallHistory
            Call callOne = new Call(DateTime.Now, "+898 888 888", 1204);
            Call callTwo = new Call(DateTime.Now.AddDays(1), "+888 888 898", 1024);
            Call callThree = new Call(DateTime.Now.AddDays(1), "+888 888 898", 200);
            Call callFour = new Call(DateTime.Now.AddHours(1), "+888 898 898", 2020);

            myMobile.CallHistory.Add(callOne);
            myMobile.CallHistory.Add(callTwo);
            myMobile.CallHistory.Add(callThree);
            myMobile.CallHistory.Add(callFour);


            //Display the information about the calls
            Console.WriteLine("All calls information\n");
            foreach (Call item in myMobile.CallHistory)
            {
                Console.WriteLine(item);
            }

            //Assuming that the price per minute is 0.37 calculate and print 
            //the total price of the calls in the history.
            Console.WriteLine("Calculate price example: ");
            var pricePerMinute = 0.37m;
            Console.WriteLine("Price of all calls {0:c}", myMobile.CallculatePrice(pricePerMinute));

            //Remove the longest call from the history and calculate the total price again.

                //find the longest call
            Call longestCall = FindLongestCall(myMobile);
                
                //remove the longest call
            myMobile.RemoveCall(longestCall);

                //calculate the price again and print it
            Console.WriteLine("Price after removing longest call: {0:c}", myMobile.CallculatePrice(pricePerMinute));

            //Finally clear the call history and print it.
            Console.WriteLine("\nBefore clear call history stores {0} items", myMobile.CallHistory.Count);
            myMobile.ClearCallHistory();
            Console.WriteLine("Now call history stores {0} items", myMobile.CallHistory.Count);           
        }

        private static Call FindLongestCall(GSM gsm)
        {
            if (gsm.CallHistory.Count == 0)
            {
                throw new ArgumentNullException("Call history is empty!");
            }
            Call longest = gsm.CallHistory[0];
            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                if (longest.CallDuration < gsm.CallHistory[i].CallDuration)
                {
                    longest = gsm.CallHistory[i];
                }
            }

            return longest;
        }      
    }
}
