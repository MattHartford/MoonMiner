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
        public class Drerkel : Runerth
        {
            Enemies drerkel = Enemies.Drerkel;
            public void DrerkelSaying()
            {
                WriteLine($"{drerkel}: Your comfort turns to discomfort whwen I take all of your resources!");
                // newPlayerInventory = playerInventory - EnemyBride 
                WriteLine($"{drerkel}: Thanks for the bride SpaceMonkey!");
                //WriteLine($"{PlayerName} {Material} is now down to {newPlayerRecourse} ")

            }
        }
        public class Qal : Horuta
        {
            Enemies qal = Enemies.Qal;
            public void QalSaying()
            {
                WriteLine($"{qal}: You sound like you're screaming in space!");
                // newPlayerInventory = playerInventory - EnemyBride 
            }
        }
        public class Vaakzail : Ketune
        {
            Enemies vaakzail = Enemies.Vaakzail;
            public void VaakzailSaying()
            {
                WriteLine($"{vaakzail}: Is that madtweed you have there? Oh boy, I'm going to have a good 'ol time!");
            }
        }
        public class Khingrox : Runerth
        {
            Enemies khingrox = Enemies.Khingrox;
            public void KhingroxSaying()
            {
                WriteLine($"{khingrox}: I am going to float you like a brick if you don't give me ma gold!");
            }
        }
        public class Ohex : Yaclite
        {
            Enemies ohex = Enemies.Ohex;
            public void OhexSaying()
            {
                WriteLine($"{ohex}: Silly Trader, I AM OHEX! Give you me your platinum NOW!");
            }
        }
    }
}
