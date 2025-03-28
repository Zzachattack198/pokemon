using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGame
{
    public partial class Battle : Form
    {

        public Battle(Image BackgroundImage1, Image BackgroundImage2, Image BackgroundImage3, Image BackgroundImage4, Image BackgroundImage5, Image BackgroundImage6)
        {
            InitializeComponent();
            team1Poke.Image = BackgroundImage1;
        }
   
    }    
}

