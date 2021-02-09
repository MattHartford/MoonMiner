using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderAssets
{
    public class Players
    {
        public string PlayerName { get; set; }
        public int PlayerLives { get; set; }
        public int TotalResources { get; set; }
        public int Gold { get; set; }
        public int Platinum { get; set; }
        public int Emerald { get; set; }
        public int Etherium { get; set; }
        public int Madtweed { get; set; }
        public int Coin { get; set; }

        public Players(string playerName, int playerLives, int totalResources, int gold, int platinum,
            int emerald, int etherium, int madtweed, int coin)
        {
            gold = 0;
            platinum = 0;
            emerald = 0;
            etherium = 0;
            madtweed = 0;
            coin = 0;
        }
        public Planet PlayerLocation()
        {
            return Planet.GalacticTradeFederation;
        }
    }
}