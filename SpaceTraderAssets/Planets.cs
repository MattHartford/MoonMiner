using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderAssets
{
    public class Planet
    {
        //public virtual int RiskPercent { get; set; }
        public virtual int ResourceValue { get; set; }

        public void RiskLevel()
        {
                //Determine risk level... 
        }
        public void CalcResourceValue()
        {
            //Determine resource value.. per click, beginning number + resourcevalue.. int addedresource += {resourcevalue}
        }

    }

    public class Runerth : Planet
    {
        public Runerth()
        {
            Materials resource = Materials.Gold;
            ResourceValue = 5;
        }
    }
    public class Horuta : Planet
    {
        public Horuta()
        {
            Materials resource = Materials.Silver;
            ResourceValue = 2;
        }
    }
    public class Gederth : Planet
    {
        public Gederth()
        {
            Materials resource = Materials.Emerald;
            ResourceValue = 7;
        }
    }
    public class Yaclite : Planet
    {
        public Yaclite()
        {
            Materials resource = Materials.Madtweed;
            ResourceValue = 10;
        }
    }
    public class Ketune : Planet
    {
        public Ketune()
        {
            Materials resource = Materials.Etherium;
            ResourceValue = 3;
        }
    }

}
