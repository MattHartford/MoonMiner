using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceTraderAssets;

namespace SpaceTraderAssets
{
    class EnemyClass
    {
        enum Enemies
        {
            Drerkel,
            Qal,
            Vaakzail,
            Khingrox,
            Ohex
        }
        public class Drerkel 
        {
            Enemies drerkel = Enemies.Drerkel;
            public void DrerkelSaying()
            {
                // Enemy Greeting
                WriteLine($"{drerkel}: Your comfort turns to discomfort when I take all of your resources!");
                // After bride 
                WriteLine($"{drerkel}: Thanks for the bride SpaceMonkey!");
                // TODO: WriteLine($"{PlayerName}'s {Material} is now down to {newPlayerResource} ")
            }
            public static void DrerkelBribe()
            {
                int stolenGold = 37;
            }

        }
        public class Qal 
        {
            Enemies qal = Enemies.Qal;
            public void QalSaying()
            {
                // Enemy Greeting
                WriteLine($"{qal}: You sound like you're screaming in space!");
                // After bride 
                WriteLine($"{qal}: You got lucky this time kid!");         
            }
            public static void QalBribe()
            {
                int stolenPlatinum = 77;
            }
        }
        public class Vaakzail 
        {
            Enemies vaakzail = Enemies.Vaakzail;
            public void VaakzailSaying()
            {
                // Enemy Greeting
                WriteLine($"{vaakzail}: Is that madtweed you have there? Oh boy, I'm going to have a good 'ol time!");
                // After bride 
                WriteLine($"{vaakzail}: hehehehe.. you fool! Now I can rule the galaxy!");
            }
            public static void VaakzailBribe()
            {
                int stoleEmerald = 42;
            }
        }
        public class Khingrox
        {
            Enemies khingrox = Enemies.Khingrox;
            public void KhingroxSaying()
            {
                // Enemy Greeting
                WriteLine($"{khingrox}: I am going to float you like a brick if you don't give me ma gold!");
                // After bride 
                WriteLine($"{khingrox}: I better not see you again in my planet you Bozo!");
            }
            public static void KhingroxBribe()
            {
                int stoleMadtweed = 25;
            }
        }
        public class Ohex
        {
            Enemies ohex = Enemies.Ohex;
            public void OhexSaying()
            {
                // Enemy Greeting
                WriteLine($"{ohex}: Silly Trader, I AM OHEX! Give you me your platinum NOW!");
                // After bride 
                WriteLine($"{ohex}: pla..pla..pla..plaaaaa....PLATINUM!!!!");
            }
            public static void OhexBribe()
            {
                int stolenEtherium = 98;
            }
        }
    }
}
