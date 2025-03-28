using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGame
{
    public partial class Choose_your_team : Form
    {
        public static Choose_your_team instance;
        public TextBox tb1;
        

        public Choose_your_team()
        {
            InitializeComponent();
            instance = this;

        }
        Image defaultPokeball = Properties.Resources.Pokeball;
        public static int index1 = 0;
        public static int index2 = 0;
        public static int index3 = 0;
        public static int index4 = 0;
        public static int index5 = 0;
        public static int index6 = 0;

        private void Choose_your_team_Load(object sender, EventArgs e)
        {
            pokemon1.BackgroundImage = defaultPokeball;
            pokemon2.BackgroundImage = defaultPokeball;
            pokemon3.BackgroundImage = defaultPokeball;
            pokemon4.BackgroundImage = defaultPokeball;
            pokemon5.BackgroundImage = defaultPokeball;
            pokemon6.BackgroundImage = defaultPokeball;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        //quit button
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void butCharizard_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butCharizard.BackgroundImage;
                index1 = 1;
                firstPokemonSelected(pokemon1.BackgroundImage);
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butCharizard.BackgroundImage;
                index2 = 1;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butCharizard.BackgroundImage;
                index3 = 1;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butCharizard.BackgroundImage;
                index4 = 1;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butCharizard.BackgroundImage;
                index5 = 1;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butCharizard.BackgroundImage;
                index6 = 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pokemon2.BackgroundImage = defaultPokeball;
        }

        private void butVenusaur_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butVenusaur.BackgroundImage;
                index1 = 2;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butVenusaur.BackgroundImage;
                index2 = 2;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butVenusaur.BackgroundImage;
                index3 = 2;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butVenusaur.BackgroundImage;
                index4 = 2;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butVenusaur.BackgroundImage;
                index5 = 2;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butVenusaur.BackgroundImage;
                index6 = 2;
            }
        }

        private void butBlastoise_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butBlastoise.BackgroundImage;
                index1 = 3;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butBlastoise.BackgroundImage;
                index2 = 3;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butBlastoise.BackgroundImage;
                index3 = 3;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butBlastoise.BackgroundImage;
                index4 = 3;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butBlastoise.BackgroundImage;
                index5 = 3;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butBlastoise.BackgroundImage;
                index6 = 3;
            }
        }

        private void butVikavolt_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butVikavolt.BackgroundImage;
                index1 = 4;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butVikavolt.BackgroundImage;
                index2 = 4;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butVikavolt.BackgroundImage;
                index3 = 4;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butVikavolt.BackgroundImage;
                index4 = 4;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butVikavolt.BackgroundImage;
                index5 = 4;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butVikavolt.BackgroundImage;
                index6 = 4;
            }
        }

        private void butFroslass_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butFroslass.BackgroundImage;
                index1 = 5;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butFroslass.BackgroundImage;
                index2 = 6;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butFroslass.BackgroundImage;
                index3 = 6;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butFroslass.BackgroundImage;
                index4 = 6;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butFroslass.BackgroundImage;
                index5 = 6;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butFroslass.BackgroundImage;
                index6 = 6;
            }
        }

        private void butToxicroak_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butToxicroak.BackgroundImage;
                index1 = 7;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butToxicroak.BackgroundImage;
                index2 = 7;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butToxicroak.BackgroundImage;
                index3 = 7;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butToxicroak.BackgroundImage;
                index4 = 7;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butToxicroak.BackgroundImage;
                index5 = 7;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butToxicroak.BackgroundImage;
                index6 = 7;
            }
        }

        private void butBlaziken_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butBlaziken.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butBlaziken.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butBlaziken.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butBlaziken.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butBlaziken.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butBlaziken.BackgroundImage;
            }
        }

        private void butSceptile_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butSceptile.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butSceptile.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butSceptile.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butSceptile.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butSceptile.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butSceptile.BackgroundImage;
            }
        }

        private void butDragapult_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butDragapult.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butDragapult.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butDragapult.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butDragapult.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butDragapult.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butDragapult.BackgroundImage;
            }
        }

        private void butKrookodile_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butKrookodile.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butKrookodile.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butKrookodile.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butKrookodile.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butKrookodile.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butKrookodile.BackgroundImage;
            }
        }

        private void butSylveon_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butSylveon.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butSylveon.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butSylveon.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butSylveon.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butSylveon.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butSylveon.BackgroundImage;
            }
        }

        private void butPikachu_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butPikachu.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butPikachu.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butPikachu.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butPikachu.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butPikachu.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butPikachu.BackgroundImage;
            }
        }

        private void butShedinja_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butShedinja.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butShedinja.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butShedinja.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butShedinja.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butShedinja.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butShedinja.BackgroundImage;
            }
        }

        private void butTyranitar_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butTyranitar.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butTyranitar.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butTyranitar.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butTyranitar.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butTyranitar.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butTyranitar.BackgroundImage;
            }
        }

        private void butGardevoir_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butGardevoir.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butGardevoir.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butGardevoir.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butGardevoir.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butGardevoir.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butGardevoir.BackgroundImage;
            }
        }

        private void butDragonite_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butDragonite.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butDragonite.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butDragonite.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butDragonite.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butDragonite.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butDragonite.BackgroundImage;
            }
        }

        private void butIncineroar_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butIncineroar.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butIncineroar.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butIncineroar.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butIncineroar.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butIncineroar.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butIncineroar.BackgroundImage;
            }
        }

        private void butMetagross_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butMetagross.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butMetagross.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butMetagross.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butMetagross.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butMetagross.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butMetagross.BackgroundImage;
            }
        }

        private void butLucario_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butLucario.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butLucario.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butLucario.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butLucario.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butLucario.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butLucario.BackgroundImage;
            }
        }

        private void butGengar_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butGengar.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butGengar.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butGengar.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butGengar.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butGengar.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butGengar.BackgroundImage;
            }
        }

        private void butAerodactyl_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butAerodactyl.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butAerodactyl.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butAerodactyl.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butAerodactyl.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butAerodactyl.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butAerodactyl.BackgroundImage;
            }
        }

        private void butSteelix_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butSteelix.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butSteelix.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butSteelix.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butSteelix.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butSteelix.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butSteelix.BackgroundImage;
            }
        }

        private void butBarbaracle_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butBarbaracle.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butBarbaracle.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butBarbaracle.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butBarbaracle.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butBarbaracle.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butBarbaracle.BackgroundImage;
            }
        }

        private void butTalonflame_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butTalonflame.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butTalonflame.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butTalonflame.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butTalonflame.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butTalonflame.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butTalonflame.BackgroundImage;
            }
        }

        private void butToxapex_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butToxapex.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butToxapex.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butToxapex.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butToxapex.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butToxapex.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butToxapex.BackgroundImage;
            }
        }

        private void butKyogre_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butKyogre.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butKyogre.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butKyogre.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butKyogre.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butKyogre.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butKyogre.BackgroundImage;
            }
        }

        private void butArticuno_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butArticuno.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butArticuno.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butArticuno.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butArticuno.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butArticuno.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butArticuno.BackgroundImage;
            }
        }

        private void butZapdos_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butZapdos.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butZapdos.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butZapdos.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butZapdos.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butZapdos.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butZapdos.BackgroundImage;
            }
        }

        private void butMewtwo_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butMewtwo.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butMewtwo.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butMewtwo.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butMewtwo.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butMewtwo.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butMewtwo.BackgroundImage;
            }
        }

        private void butGroudon_Click(object sender, EventArgs e)
        {
            if (pokemon1.BackgroundImage == defaultPokeball)
            {
                pokemon1.BackgroundImage = butGroudon.BackgroundImage;
            }
            else if (pokemon2.BackgroundImage == defaultPokeball)
            {
                pokemon2.BackgroundImage = butGroudon.BackgroundImage;
            }
            else if (pokemon3.BackgroundImage == defaultPokeball)
            {
                pokemon3.BackgroundImage = butGroudon.BackgroundImage;
            }
            else if (pokemon4.BackgroundImage == defaultPokeball)
            {
                pokemon4.BackgroundImage = butGroudon.BackgroundImage;
            }
            else if (pokemon5.BackgroundImage == defaultPokeball)
            {
                pokemon5.BackgroundImage = butShedinja.BackgroundImage;
            }
            else if (pokemon6.BackgroundImage == defaultPokeball)
            {
                pokemon6.BackgroundImage = butGroudon.BackgroundImage;
            }
        }

        private void pokemon1_Click(object sender, EventArgs e)
        {
            pokemon1.BackgroundImage = defaultPokeball;
        }

        private void pokemon3_Click(object sender, EventArgs e)
        {
            pokemon3.BackgroundImage = defaultPokeball;
        }

        private void pokemon4_Click(object sender, EventArgs e)
        {
            pokemon4.BackgroundImage = defaultPokeball;
        }

        private void pokemon5_Click(object sender, EventArgs e)
        {
            pokemon5.BackgroundImage = defaultPokeball;
        }

        private void pokemon6_Click(object sender, EventArgs e)
        {
            pokemon6.BackgroundImage = defaultPokeball;
        }
        public void firstPokemonSelected(Image pokemon)
        {
            Image image = pokemon;
        }
        public static class GlobalData
        {
            public static Image SharedImage { get; set; }

        }
        private void butChoosePoke_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Battle = new Battle(pokemon1.BackgroundImage, pokemon2.BackgroundImage, pokemon3.BackgroundImage, pokemon4.BackgroundImage, pokemon5.BackgroundImage, pokemon6.BackgroundImage);
            Battle.Closed += (s, args) => this.Close();
            Battle.Show();
        }


        //For pokemon sprites use the Gen 7 sprites as buttons to select.

    }
}
