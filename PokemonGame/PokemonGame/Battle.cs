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
        public Battle(Image tm1BackgroundImage1, Image tm1BackgroundImage2, Image tm1BackgroundImage3, Image tm1BackgroundImage4, Image tm1BackgroundImage5, Image tm1BackgroundImage6, Image butCharizard, Image butBlaziken, Image butBlastoise, Image butBarbaracle, Image butIncineroar, Image butAerodactyl, Image butArticuno, Image butDragapult, Image butDragonite, Image butFroslass, Image butGardevoir, Image butGengar, Image butGroudon, Image butKrookodile, Image butKyogre, Image butLucario, Image butMetagross, Image butMewtwo, Image butPikachu, Image butSceptile, Image butShedinja, Image butSteelix, Image butSylveon, Image butTalonflame, Image butToxapex, Image butToxicroak, Image butTyranitar, Image butVenusaur, Image butVikavolt, Image butZapdos)
        {
            InitializeComponent();
            team1Poke.Image = tm1BackgroundImage1;
            Random rnd = new Random();
            int ranNum = rnd.Next(1, 30);
            for (int i = 0; i < 6; i++)
            {
                if (ranNum == 1)
                {
                    team2Poke.Image = butCharizard;
                }
                else if (ranNum == 2)
                {
                    team2Poke.Image = butBlaziken;
                }
                else if (ranNum == 3)
                {
                    team2Poke.Image = butBlastoise;
                }
                else if (ranNum == 4)
                {
                    team2Poke.Image = butBarbaracle;
                }
                else if (ranNum == 5)
                {
                    team2Poke.Image = butIncineroar;
                }
                else if (ranNum == 6)
                {
                    team2Poke.Image = butAerodactyl;
                }
                else if (ranNum == 7)
                {
                    team2Poke.Image = butArticuno;


                }
                else if (ranNum == 8)
                {
                    team2Poke.Image = butDragapult;
                }
                else if (ranNum == 9)
                {
                    team2Poke.Image = butDragonite;
                }
                else if (ranNum == 10)
                {
                    team2Poke.Image = butFroslass;
                }
                else if (ranNum == 11)
                {
                    team2Poke.Image = butGardevoir;
                }
                else if (ranNum == 12)
                {
                    team2Poke.Image = butGengar;   
                }
                else if (ranNum == 13)
                {
                    team2Poke.Image = butGroudon;
    }
                else if (ranNum == 14)
                {
                    team2Poke.Image = butKrookodile;
}
                else if (ranNum == 15)
                {
    team2Poke.Image = butKyogre;
                }
                else if (ranNum == 16)
                {
    team2Poke.Image = butLucario;
                }
                else if (ranNum == 18)
                {
    team2Poke.Image = butMetagross;

                }
                else if (ranNum == 19)
                {
    team2Poke.Image = butMewtwo;

                }
                else if (ranNum == 20)
                {
    team2Poke.Image = butPikachu;

                }
                else if (ranNum == 21)
                {
    team2Poke.Image = butSceptile;

                }
                else if (ranNum == 22)
                {
    team2Poke.Image = butShedinja;

                }
                else if (ranNum == 23)
                {
    team2Poke.Image = butSteelix;

                }
                else if (ranNum == 24)
                {
                    team2Poke.Image = butSylveon;

                }
                else if (ranNum == 25)
                {
                    team2Poke.Image = butTalonflame;

    }
                else if (ranNum == 26)
                {
                    team2Poke.Image = butToxapex;

}
                else if (ranNum == 27)
                {
    team2Poke.Image = butTyranitar;

                }
                else if (ranNum == 28)
                {
    team2Poke.Image = butToxicroak;

                }
                else if (ranNum == 29)
                {
    team2Poke.Image = butVenusaur;

                }
                else if (ranNum == 30)
                {
    team2Poke.Image = butVikavolt;

                }
                else if (ranNum == 30)
                {
                    team2Poke.Image = butZapdos;

                }
         
            }

            


        }
    }
   
    
}

