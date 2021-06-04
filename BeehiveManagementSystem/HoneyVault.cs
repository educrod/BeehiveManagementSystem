using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = 10f;
        
        private static float honey = 25f;
        private static float nectar = 100f;


        public static string StatusReport
        {
            get
            {
                string warnings = "";
                string status = $"{honey} units of honey\n" +
                                $"{nectar} units of nectar";
                if (honey < LOW_LEVEL_WARNING) warnings += "LOW HONEY - ADD A HONEY MANUFACTURER\n";
                if (nectar < LOW_LEVEL_WARNING) warnings += "LOW NECTAR - ADD A NECTAR MANUFACTURER\n";

                return status + warnings;
            }
        }

        private static void ConvertNectarToHoney(float amount)
        {
            
            if (amount > nectar) amount = nectar;
            nectar -= amount;
            honey += (amount * NECTAR_CONVERSION_RATIO);
             
        }

        private static bool ConsumeHoney(float amount)
        {
            
            if (amount > honey)
            {
                honey -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void CollectNectar(float amount)
        {
            if (amount > 0f)
            {
                honey += amount;
            }
        }


    }
}
