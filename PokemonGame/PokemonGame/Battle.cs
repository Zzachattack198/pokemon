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
            //team 2 and 2 speed, attack, and health variables
            int speed1, speed2, attack1, attack2, health1, health2 = 0;

            Random rnd = new Random();
            int ranNum = rnd.Next(1, 30);
            for (int i = 0; i < 6; i++)
            {
                if (ranNum == 1)
                {
                    team2Poke.Image = butCharizard;
                    speed2 = 328;
                    attack2 = 293;
                    health2 = 360;
                }
                else if (ranNum == 2)
                {
                    team2Poke.Image = butBlaziken;
                    speed2 = 284;
                    attack2 = 372;
                    health2 = 364;                 
                }
                else if (ranNum == 3)
                {
                    team2Poke.Image = butBlastoise;
                    speed2 = 280;
                    attack2 = 291;
                    health2 = 362;
                }
                else if (ranNum == 4)
                {
                    team2Poke.Image = butBarbaracle;
                    speed2 = 258;
                    attack2 = 339;
                    health2 = 348;
                }
                else if (ranNum == 5)
                {
                    team2Poke.Image = butIncineroar;
                    speed2 = 240;
                    attack2 = 361;
                    health2 = 394;
                }
                else if (ranNum == 6)
                {
                    team2Poke.Image = butAerodactyl;
                    speed2 = 394;
                    attack2 = 339;
                    health2 = 364;
                }
                else if (ranNum == 7)
                {
                    team2Poke.Image = butArticuno;
                    speed2 = 295;
                    attack2 = 295;
                    health2 = 384;
                }
                else if (ranNum == 8)
                {
                    team2Poke.Image = butDragapult;
                    speed2 = 421;
                    attack2 = 372;
                    health2 = 380;
                }
                else if (ranNum == 9)
                {
                    team2Poke.Image = butDragonite;
                    speed2 = 284;
                    attack2 = 403;
                    health2 = 386;
                }
                else if (ranNum == 10)
                {
                    team2Poke.Image = butFroslass;
                    speed2 = 350;
                    attack2 = 284;
                    health2 = 344;
                }
                else if (ranNum == 11)
                {
                    team2Poke.Image = butGardevoir;
                    speed2 = 284;
                    attack2 = 251;
                    health2 = 340;
                }
                else if (ranNum == 12)
                {
                    team2Poke.Image = butGengar;
                    speed2 = 350;
                    attack2 = 251;
                    health2 = 324;
                }
                else if (ranNum == 13)
                {
                    team2Poke.Image = butGroudon;
                    speed2 = 306;
                    attack2 = 438;
                    health2 = 404;
                }
                else if (ranNum == 14)
                {
                    team2Poke.Image = butKrookodile;
                    speed2 = 311;
                    attack2 = 366;
                    health2 = 394;
                }
                else if (ranNum == 15)
                {
                    team2Poke.Image = butKyogre;
                    speed2 = 306;
                    attack2 = 328;
                    health2 = 404;
                }
                else if (ranNum == 16)
                {
                    team2Poke.Image = butLucario;
                    speed2 = 306;
                    attack2 = 350;
                    health2 = 344;
                }
                else if (ranNum == 18)
                {
                    team2Poke.Image = butMetagross;
                    speed2 = 0;
                    attack2 = 0;
                    health2 = 0;
                }
                else if (ranNum == 19)
                {
                    team2Poke.Image = butMewtwo;
                    speed2 = 262;
                    attack2 = 405;
                    health2 = 364;
                }
                else if (ranNum == 20)
                {
                    team2Poke.Image = butPikachu;
                    speed2 = 306;
                    attack2 = 229;
                    health2 = 274;
                }
                else if (ranNum == 21)
                {
                    team2Poke.Image = butSceptile;
                    speed2 = 372;
                    attack2 = 295;
                    health2 = 344;
                }
                else if (ranNum == 22)
                {
                    team2Poke.Image = butShedinja;
                    speed2 = 196;
                    attack2 = 306;
                    health2 = 1;
                }
                else if (ranNum == 23)
                {
                    team2Poke.Image = butSteelix;
                    speed2 = 251;
                    attack2 = 295;
                    health2 = 354;
                }
                else if (ranNum == 24)
                {
                    team2Poke.Image = butSylveon;
                    speed2 = 394;
                    attack2 = 251;
                    health2 = 240;
                }
                else if (ranNum == 25)
                {
                    team2Poke.Image = butTalonflame;
                    speed2 = 386;
                    attack2 = 287;
                    health2 = 360;
                }
                else if (ranNum == 26)
                {
                    team2Poke.Image = butToxapex;
                    speed2 = 386;
                    attack2 = 287;
                    health2 = 360;
                }
                else if (ranNum == 27)
                {
                    team2Poke.Image = butTyranitar;
                    speed2 = 243;
                    attack2 = 403;
                    health2 = 404;
                }
                else if (ranNum == 28)
                {
                    team2Poke.Image = butToxicroak;
                    speed2 = 295;
                    attack2 = 342;
                    health2 = 370;
                }
                else if (ranNum == 29)
                {
                    team2Poke.Image = butVenusaur;
                    speed2 = 284;
                    attack2 = 289;
                    health2 = 364;
                }
                else if (ranNum == 30)
                {
                    team2Poke.Image = butVikavolt;
                    speed2 = 203;
                    attack2 = 262;
                    health2 = 358;

                }
                else if (ranNum == 30)
                {
                    team2Poke.Image = butZapdos;
                    speed2 = 328;
                    attack2 = 306;
                    health2 = 384;
                }
         
            }

            


        }
    }
   
    
}

