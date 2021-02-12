using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceTraderAssets;

namespace MoonMiner
    {
    public partial class Form1 : Form
        {
        public Form1( )
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender , EventArgs e)
            {

            }

        private void _BuyShipButton_Click(object sender , EventArgs e)
            {

            }

        private void TradeFedButton_Click(object sender , EventArgs e)
            {

            }

        private void _RunerthButton_Click(object sender, EventArgs e)
        {

        }

        private void GoldLabel_Click(object sender, EventArgs e)
        {
            Players.PlayerGold();
        }

        private void _HorutaButton_Click(object sender, EventArgs e)
        {

        }

        private void _GederthButton_Click(object sender, EventArgs e)
        {

        }

        private void _YacliteButton_Click(object sender, EventArgs e)
        {

        }

        private void _KetuneButton_Click(object sender, EventArgs e)
        {

        }

        private void IntroNaut_Click(object sender, EventArgs e)
        {
            Players.PlayerName();
        }

        private void platinumLabel_Click(object sender, EventArgs e)
        {
            Players.PlayerPlatinum();
        }

        private void EmeraldLabel_Click(object sender, EventArgs e)
        {
            Players.PlayerEmerald();
        }

        private void EtheriumLabel_Click(object sender, EventArgs e)
        {
            Players.PlayerEtherium();
        }

        private void MadtweedLabel_Click(object sender, EventArgs e)
        {
            Players.PlayerMadtweed();
        }
    }
    }
