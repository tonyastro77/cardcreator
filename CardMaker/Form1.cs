using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CardMaker
{
    public partial class Form1 : Form
    {
        string weakness;
        string resistance;
        string no;
        string total;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureStyle.Visible = false;
            TrainerStyle.Checked = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel4.Location = new Point(99, 63);
            panel5.Location = new Point(99, 63);
            weakness = "   ";
            resistance = "   ";
            no = "000";
            total = "000";
            HasAbility.Checked = false;
            AbilityName.Visible = false;
            Attack1.Visible = true;
            AbilityLogo.Visible = false;
            Energy1.Visible = true;
            Energy2.Visible = true;
            Energy3.Visible = true;
            Energy4.Visible = true;
            AttackDamage1.Visible = true;
            label7.BringToFront();
            hplabel.BringToFront();
            EnergyType.BringToFront();
            RarityBox.BringToFront();
            textBox10.Text = "©2020 Pokémon/ Nintendo/ Creatures/ GAME FREAK.";
            comboBox1.Items.Add("Fire");
            comboBox1.Items.Add("Grass");
            comboBox1.Items.Add("Water");
            comboBox1.Items.Add("Lightning");
            comboBox1.Items.Add("Psychic");
            comboBox1.Items.Add("Fighting");
            comboBox1.Items.Add("Colorless");
            comboBox1.Items.Add("Steel");
            comboBox1.Items.Add("Dark");
            comboBox1.Items.Add("Dragon");
            comboBox1.Items.Add("Fairy");
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("Basic");
            comboBox2.Items.Add("Stage 1");
            comboBox2.Items.Add("Stage 2");
            comboBox2.SelectedIndex = 0;

            comboBox3.Items.Add("None");
            comboBox3.Items.Add("Fire");
            comboBox3.Items.Add("Grass");
            comboBox3.Items.Add("Water");
            comboBox3.Items.Add("Lightning");
            comboBox3.Items.Add("Psychic");
            comboBox3.Items.Add("Fighting");
            comboBox3.Items.Add("Steel");
            comboBox3.Items.Add("Dark");
            comboBox3.Items.Add("Fairy");
            comboBox3.SelectedIndex = 0;

            comboBox4.Items.Add("None");
            comboBox4.Items.Add("Fire");
            comboBox4.Items.Add("Grass");
            comboBox4.Items.Add("Water");
            comboBox4.Items.Add("Lightning");
            comboBox4.Items.Add("Psychic");
            comboBox4.Items.Add("Fighting");
            comboBox4.Items.Add("Steel");
            comboBox4.Items.Add("Dark");
            comboBox4.Items.Add("Fairy");
            comboBox4.SelectedIndex = 0;

            comboBox5.Items.Add("0");
            comboBox5.Items.Add("1");
            comboBox5.Items.Add("2");
            comboBox5.Items.Add("3");
            comboBox5.Items.Add("4");
            comboBox5.SelectedIndex = 0;

            comboBox7.Items.Add("   ");
            comboBox7.Items.Add("X2");
            comboBox7.Items.Add("+20");
            comboBox7.Items.Add("+30");
            comboBox7.SelectedIndex = 0;

            comboBox8.Items.Add("   ");
            comboBox8.Items.Add("-20");
            comboBox8.Items.Add("-30");
            comboBox8.Items.Add("-40");
            comboBox8.SelectedIndex = 0;

            comboBox6.Items.Add("Common");
            comboBox6.Items.Add("Uncommon");
            comboBox6.Items.Add("Rare");
            comboBox6.Items.Add("Ultra Rare");
            comboBox6.Items.Add("A");
            comboBox6.SelectedIndex = 0;

            comboBox9.Items.Add("Vivid Voltage");
            comboBox9.Items.Add("Darkness Ablaze");
            comboBox9.Items.Add("Rebel Clash");
            comboBox9.Items.Add("Sword and Shield");
            comboBox9.Items.Add("Cosmic Eclipse");
            comboBox9.Items.Add("Hidden Fates");
            comboBox9.Items.Add("Unified Minds");
            comboBox9.Items.Add("Unbroken Bonds");
            comboBox9.Items.Add("Team Up");
            comboBox9.Items.Add("Lost Thunder");
            comboBox9.Items.Add("Dragon Majesty");
            comboBox9.Items.Add("Celestial Storm");
            comboBox9.Items.Add("Forbidden Light");
            comboBox9.Items.Add("Ultra Prism");
            comboBox9.Items.Add("Crimson Invasion");
            comboBox9.Items.Add("Shining Legends");
            comboBox9.Items.Add("Burning Shadows");
            comboBox9.Items.Add("Guardians Rising");
            comboBox9.Items.Add("Sun and Moon");
            comboBox9.Items.Add("Evolutions");
            comboBox9.Items.Add("Steam Siege");
            comboBox9.Items.Add("Fates Collide");
            comboBox9.Items.Add("Generations");
            comboBox9.Items.Add("BREAKpoint");
            comboBox9.Items.Add("BREAKthrough");
            comboBox9.Items.Add("Ancient Origins");
            comboBox9.Items.Add("Roaring Skies");
            comboBox9.Items.Add("Double Crisis");
            comboBox9.Items.Add("Primal Clash");
            comboBox9.Items.Add("Phantom Forces");
            comboBox9.Items.Add("Furious Fists");
            comboBox9.Items.Add("Flashfire");
            comboBox9.Items.Add("XY");
            comboBox9.Items.Add("Kalos Starter Set");

            comboBox9.Items.Add("Gym Challenge");
            comboBox9.Items.Add("Gym Heroes");
            comboBox9.Items.Add("Team Rocket");
            comboBox9.Items.Add("Fossil");
            comboBox9.Items.Add("Jungle");
            comboBox9.Items.Add("Base Set 2");
            comboBox9.SelectedIndex = 0;

            MoreStagesPanel.Visible = false;

            pictureBox6.ImageLocation = "..\\..\\Img\\colorless.jpg";
            pictureBox5.ImageLocation = "..\\..\\Img\\colorless.jpg";
            pictureBox4.ImageLocation = "..\\..\\Img\\colorless.jpg";
            pictureBox3.ImageLocation = "..\\..\\Img\\colorless.jpg";

            NumOfAttacks.Items.Add("1");
            NumOfAttacks.Items.Add("2");
            NumOfAttacks.Items.Add("3");
            NumOfAttacks.SelectedIndex = 0;

            CostX(Cost1);
            CostX(Cost2);
            CostX(Cost3);
            CostX(Cost4);
            CostX(Cost5);
            CostX(Cost6);
            CostX(Cost7);
            CostX(Cost8);
            CostX(Cost9);
            CostX(Cost10);
            CostX(Cost11);
            CostX(Cost12);

            FontSize1.Items.Add("13");
            FontSize1.Items.Add("12");
            FontSize1.Items.Add("11");
            FontSize1.Items.Add("10");
            FontSize1.Items.Add("9");
            FontSize1.Items.Add("8");
            FontSize1.Items.Add("7");
            FontSize1.Items.Add("6");
            FontSize1.SelectedIndex = 2;
            FontSize2.Items.Add("13");
            FontSize2.Items.Add("12");
            FontSize2.Items.Add("11");
            FontSize2.Items.Add("10");
            FontSize2.Items.Add("9");
            FontSize2.Items.Add("8");
            FontSize2.Items.Add("7");
            FontSize2.Items.Add("6");
            FontSize2.SelectedIndex = 2;
            FontSize3.Items.Add("13");
            FontSize3.Items.Add("12");
            FontSize3.Items.Add("11");
            FontSize3.Items.Add("10");
            FontSize3.Items.Add("9");
            FontSize3.Items.Add("8");
            FontSize3.Items.Add("7");
            FontSize3.Items.Add("6");
            FontSize3.SelectedIndex = 2;

            InitializePosSize(Attack1Pos);
            InitializePosSize(Attack1Size);
            InitializePosSize(Attack2Pos);
            InitializePosSize(Attack2Size);
            InitializePosSize(Attack3Pos);
            InitializePosSize(Attack3Size);

            comboBox10.Items.Add("Pokémon");
            comboBox10.Items.Add("Trainer: Supporter");
            comboBox10.Items.Add("Trainer: Item");
            comboBox10.Items.Add("Trainer: Stadium");
            comboBox10.Items.Add("Energy");
            comboBox10.Items.Add("Special Energy");
            comboBox10.SelectedIndex = 0;
        }

        private void InitializePosSize(DomainUpDown domainUpDown)
        {
            domainUpDown.Items.Add("65");
            domainUpDown.Items.Add("60");
            domainUpDown.Items.Add("55");
            domainUpDown.Items.Add("50");
            domainUpDown.Items.Add("45");
            domainUpDown.Items.Add("40");
            domainUpDown.Items.Add("35");
            domainUpDown.Items.Add("30");
            domainUpDown.Items.Add("25");
            domainUpDown.Items.Add("20");
            domainUpDown.Items.Add("15");
            domainUpDown.Items.Add("10");
            domainUpDown.Items.Add("5");
            domainUpDown.Items.Add("0");
            domainUpDown.SelectedIndex = 13;
        }
        private void CostX(ComboBox comboName)
        {
            comboName.Items.Add("None");
            comboName.Items.Add("Colorless");
            comboName.Items.Add("Fire");
            comboName.Items.Add("Grass");
            comboName.Items.Add("Water");
            comboName.Items.Add("Lightning");
            comboName.Items.Add("Psychic");
            comboName.Items.Add("Fighting");
            comboName.Items.Add("Steel");
            comboName.Items.Add("Dark");
            comboName.Items.Add("Fairy");
            comboName.SelectedIndex = 0;
        }
        private void ShowEnergyX(ComboBox combo, PictureBox pic)
        {
            if(BWChecked.Checked == true)
            {
                pic.Visible = true;
                if (combo.SelectedIndex == 0)
                {
                    pic.Visible = false;
                }
                else if (combo.SelectedIndex == 1)
                {
                    pic.ImageLocation = "..\\..\\Img\\colorless.jpg";
                }
                else if (combo.SelectedIndex == 2)
                {
                    pic.ImageLocation = "..\\..\\Img\\fire.jpg";
                }
                else if (combo.SelectedIndex == 3)
                {
                    pic.ImageLocation = "..\\..\\Img\\grass.jpg";
                }
                else if (combo.SelectedIndex == 4)
                {
                    pic.ImageLocation = "..\\..\\Img\\water.jpg";
                }
                else if (combo.SelectedIndex == 5)
                {
                    pic.ImageLocation = "..\\..\\Img\\lightning.jpg";
                }
                else if (combo.SelectedIndex == 6)
                {
                    pic.ImageLocation = "..\\..\\Img\\psychic.jpg";
                }
                else if (combo.SelectedIndex == 7)
                {
                    pic.ImageLocation = "..\\..\\Img\\fighting.jpg";
                }

                else if (combo.SelectedIndex == 8)
                {
                    pic.ImageLocation = "..\\..\\Img\\steel.jpg";
                }
                else if (combo.SelectedIndex == 9)
                {
                    pic.ImageLocation = "..\\..\\Img\\dark.jpg";

                }
                else if (combo.SelectedIndex == 10)
                {
                    pic.ImageLocation = "..\\..\\Img\\fairy.jpg";
                }
            }
            else
            {
                pic.Visible = true;
                if (combo.SelectedIndex == 0)
                {
                    pic.Visible = false;
                }
                else if (combo.SelectedIndex == 1)
                {
                    pic.ImageLocation = "..\\..\\Img\\colorless.png";
                }
                else if (combo.SelectedIndex == 2)
                {
                    pic.ImageLocation = "..\\..\\Img\\fire.png";
                }
                else if (combo.SelectedIndex == 3)
                {
                    pic.ImageLocation = "..\\..\\Img\\grass.png";
                }
                else if (combo.SelectedIndex == 4)
                {
                    pic.ImageLocation = "..\\..\\Img\\water.png";
                }
                else if (combo.SelectedIndex == 5)
                {
                    pic.ImageLocation = "..\\..\\Img\\lightning.png";
                }
                else if (combo.SelectedIndex == 6)
                {
                    pic.ImageLocation = "..\\..\\Img\\psychic.png";
                }
                else if (combo.SelectedIndex == 7)
                {
                    pic.ImageLocation = "..\\..\\Img\\fighting.png";
                }

                else if (combo.SelectedIndex == 8)
                {
                    pic.ImageLocation = "..\\..\\Img\\steel.png";
                }
                else if (combo.SelectedIndex == 9)
                {
                    pic.ImageLocation = "..\\..\\Img\\dark.png";
                }
                else if (combo.SelectedIndex == 10)
                {
                    pic.ImageLocation = "..\\..\\Img\\fairy.png";
                }
            }    
        }

        private void ChangeBackground(ComboBox combo)
        {
            LabelName.ForeColor = Color.Black;
            AttackName1.ForeColor = Color.Black;
            AttackName2.ForeColor = Color.Black;
            AttackName3.ForeColor = Color.Black;
            InfoLabel1.ForeColor = Color.Black;
            InfoLabel2.ForeColor = Color.Black;
            InfoLabel3.ForeColor = Color.Black;
            IllustratorLabel.ForeColor = Color.Black;
            FlavourLabel.ForeColor = Color.Black;
            NoLabel.ForeColor = Color.Black;
            BottomTxtLabel.ForeColor = Color.Black;
            AttackDamage1.ForeColor = Color.Black;
            AttackDamage2.ForeColor = Color.Black;
            AttackDamage3.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            hplabel.ForeColor = Color.Black;

            if (BWChecked.Checked == true)
            {
                panel3.BackColor = Color.White;
                StageLabel.BackColor = Color.White;
                EvolvesLabel.BackColor = Color.White;
                InfoLabel.BackColor = Color.White;
                label15.BackColor = Color.White;
                label16.BackColor = Color.White;
                pictureBox6.BackColor = Color.White;
                pictureBox5.BackColor = Color.White;
                pictureBox4.BackColor = Color.White;
                pictureBox3.BackColor = Color.White;
                WeaknessBox.BackColor = Color.White;
                ResistanceBox.BackColor = Color.White;
            }
            else
            {
                StageLabel.BackColor = Color.FromArgb(224, 224, 224);
                EvolvesLabel.BackColor = Color.FromArgb(224, 224, 224);
                InfoLabel.BackColor = Color.FromArgb(224, 224, 224);
                label15.BackColor = Color.FromArgb(224, 224, 224);
                label16.BackColor = Color.FromArgb(224, 224, 224);
                pictureBox6.BackColor = Color.FromArgb(224, 224, 224);
                pictureBox5.BackColor = Color.FromArgb(224, 224, 224);
                pictureBox4.BackColor = Color.FromArgb(224, 224, 224);
                pictureBox3.BackColor = Color.FromArgb(224, 224, 224);
                WeaknessBox.BackColor = Color.FromArgb(224, 224, 224);
                ResistanceBox.BackColor = Color.FromArgb(224, 224, 224);

                if (combo.SelectedIndex == 0)
                {
                    //Fire
                    panel3.BackColor = Color.FromArgb(247, 155, 85);
                }
                else if (combo.SelectedIndex == 1)
                {
                    //Grass
                    panel3.BackColor = Color.FromArgb(170, 209, 94);
                }
                else if (combo.SelectedIndex == 2)
                {
                    //Water
                    panel3.BackColor = Color.FromArgb(148, 219, 238);
                }
                else if (combo.SelectedIndex == 3)
                {
                    //Lightning
                    panel3.BackColor = Color.FromArgb(255, 238, 35);
                }
                else if (combo.SelectedIndex == 4)
                {
                    //Psychic
                    panel3.BackColor = Color.FromArgb(197, 150, 189);
                }
                else if (combo.SelectedIndex == 5)
                {
                    //Fighting
                    panel3.BackColor = Color.FromArgb(225, 160, 0);
                }
                else if (combo.SelectedIndex == 6)
                {
                    //Colorless
                    panel3.BackColor = Color.FromArgb(238, 228, 224);
                }
                else if (combo.SelectedIndex == 7)
                {
                    //Steel
                    panel3.BackColor = Color.FromArgb(235, 240, 244);
                }
                else if (combo.SelectedIndex == 8)
                {
                    //Dark
                    panel3.BackColor = panel3.BackColor = Color.FromArgb(3, 76, 82);
                    LabelName.ForeColor = Color.White;
                    AttackName1.ForeColor = Color.White;
                    AttackName2.ForeColor = Color.White;
                    AttackName3.ForeColor = Color.White;
                    InfoLabel1.ForeColor = Color.White;
                    InfoLabel2.ForeColor = Color.White;
                    InfoLabel3.ForeColor = Color.White;
                    IllustratorLabel.ForeColor = Color.White;
                    FlavourLabel.ForeColor = Color.White;
                    NoLabel.ForeColor = Color.White;
                    BottomTxtLabel.ForeColor = Color.White;
                    AttackDamage1.ForeColor = Color.White;
                    AttackDamage2.ForeColor = Color.White;
                    AttackDamage3.ForeColor = Color.White;
                    label7.ForeColor = Color.White;
                    hplabel.ForeColor = Color.White;     
                }
                else if (combo.SelectedIndex == 9)
                {
                    //Dragon
                    panel3.BackColor = Color.FromArgb(240, 217, 53);
                }
                else if (combo.SelectedIndex == 10)
                {
                    //Fairy
                    panel3.BackColor = Color.Pink;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LabelName.Text = textBox1.Text;
            TrainerCardName.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            hplabel.Text = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            InfoLabel.Text = "NO. " + textBox4.Text + "  " + textBox3.Text + "  HT:  " + textBox5.Text + " m  WT:  " + textBox6.Text + " kg";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            InfoLabel.Text = "NO. " + textBox4.Text + "  " + textBox3.Text + "  HT:  " + textBox5.Text + " m  WT:  " + textBox6.Text + " kg";
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            InfoLabel.Text = "NO. " + textBox4.Text + "  " + textBox3.Text + "  HT:  " + textBox5.Text + " m  WT:  " + textBox6.Text + " kg";
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            InfoLabel.Text = "NO. " + textBox4.Text + "  " + textBox3.Text + "  HT:  " + textBox5.Text + " m  WT:  " + textBox6.Text + " kg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string realPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\Saved\\");
            openFileDialog1.InitialDirectory = Path.GetFullPath(realPath);
            MainPicture.ImageLocation = openFileDialog1.FileName;
            TrainerPic.ImageLocation = openFileDialog1.FileName;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            string realPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\Saved\\");
            openFileDialog2.InitialDirectory = Path.GetFullPath(realPath);
            PreviousImg.ImageLocation = openFileDialog2.FileName;
        }

        private void EnergyTypeX(ComboBox combo, PictureBox energy)
        {
            string real_name = combo.SelectedItem.ToString().ToLower();
            if (BWChecked.Checked == true)
            {
                energy.ImageLocation = "..\\..\\Img\\" + real_name + ".jpg";
            }
            else
            {
                energy.ImageLocation = "..\\..\\Img\\" + real_name + ".png";
            }
            EnergyBoxE.ImageLocation = "..\\..\\Img\\" + real_name + ".png";
            EnergyBoxEBig.ImageLocation = "..\\..\\Img\\" + real_name + ".jpg";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnergyTypeX(comboBox1, EnergyType);
            ChangeBackground(comboBox1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                PreviousImg.Visible = false;
                StageLabel.Text = "BASIC";
                EvolvesLabel.Visible = false;
                EvolvesLabel.Text = "Evolves from " + textBox7.Text;
                MoreStagesPanel.Visible = false;
            }
            else if(comboBox2.SelectedIndex == 1)
            {
                PreviousImg.Visible = true;
                StageLabel.Text = "STAGE 1";
                EvolvesLabel.Visible = true;
                EvolvesLabel.Text = "Evolves from " + textBox7.Text;
                MoreStagesPanel.Visible = true;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                PreviousImg.Visible = true;
                StageLabel.Text = "STAGE 2";
                EvolvesLabel.Visible = true;
                EvolvesLabel.Text = "Evolves from ";
                MoreStagesPanel.Visible = true;
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            EvolvesLabel.Text = "Evolves from " + textBox7.Text;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            FlavourLabel.Text = richTextBox1.Text;
            TrainerAbiltyTxt.Text = richTextBox1.Text;
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            IllustratorLabel.Text = textBox9.Text;
            TrainerIllus.Text = textBox9.Text;
        }

        private void RetreatCostX()
        {
            if (BWChecked.Checked == true){
                pictureBox6.ImageLocation = "..\\..\\Img\\colorless.jpg";
                pictureBox5.ImageLocation = "..\\..\\Img\\colorless.jpg";
                pictureBox4.ImageLocation = "..\\..\\Img\\colorless.jpg";
                pictureBox3.ImageLocation = "..\\..\\Img\\colorless.jpg";
            }
            else
            {
                pictureBox6.ImageLocation = "..\\..\\Img\\colorless.png";
                pictureBox5.ImageLocation = "..\\..\\Img\\colorless.png";
                pictureBox4.ImageLocation = "..\\..\\Img\\colorless.png";
                pictureBox3.ImageLocation = "..\\..\\Img\\colorless.png";
            }

        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetreatCostX();

            if (comboBox5.SelectedIndex == 0)
            {
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                pictureBox6.Visible = true;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                pictureBox6.Visible = true;
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
            }
            else if (comboBox5.SelectedIndex == 3)
            {
                pictureBox6.Visible = true;
                pictureBox5.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
            }
            else if (comboBox5.SelectedIndex == 4)
            {
                pictureBox6.Visible = true;
                pictureBox5.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Visible = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeaknessBox.Visible = true;
            if (comboBox3.SelectedIndex == 0)
            {
                WeaknessBox.Visible = false;
            }
            else
            {
                EnergyTypeX(comboBox3, WeaknessBox);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResistanceBox.Visible = true;
            if (comboBox4.SelectedIndex == 0)
            {
                ResistanceBox.Visible = false;
            }
            else
            {
                EnergyTypeX(comboBox4, ResistanceBox);
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            weakness = comboBox7.SelectedItem.ToString();
            label15.Text = "Weakness       " + weakness + "    Resistance        " + resistance;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistance = comboBox8.SelectedItem.ToString();
            label15.Text = "Weakness       " + weakness + "    Resistance        " + resistance;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if(textBox12.Text.Length > 3)
            {
                textBox12.Text = NoLabel.Text.Substring(0,3);
                textBox12.Text = TrainerNoLabel.Text.Substring(0, 3);
            }
            else
            {
                no = textBox12.Text;
                NoLabel.Text = no + "/" + total;
                TrainerNoLabel.Text = no + "/" + total;
            }
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if(textBox11.Text.Length > 3)
            {
                textBox11.Text = NoLabel.Text.Substring(4, 3);
                textBox11.Text = TrainerNoLabel.Text.Substring(4, 3);
            }
            total = textBox11.Text;
            NoLabel.Text = no + "/" + total;
            TrainerNoLabel.Text = no + "/" + total;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            RarityBox.ImageLocation = "..\\..\\Img\\" + comboBox6.SelectedItem.ToString() + ".png";
            TrainerRarityBox.ImageLocation = "..\\..\\Img\\" + comboBox6.SelectedItem.ToString() + ".png";
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditionBox.ImageLocation = "..\\..\\Img\\" + comboBox9.SelectedItem.ToString() + ".png";
            TrainerEdition.ImageLocation = "..\\..\\Img\\" + comboBox9.SelectedItem.ToString() + ".png";
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            BottomTxtLabel.Text = textBox10.Text;
            TrainerBottomTxt.Text = textBox10.Text;
            EnergyBottomtxt.Text = textBox10.Text;
        }

        private void NumOfAttacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NumOfAttacks.SelectedIndex == 0)
            {
                groupBox2.Visible = false;
                Attack2Panel.Visible = false;
                groupBox3.Visible = false;
                Attack3Panel.Visible = false;
                InfoLabel1.TextAlign = ContentAlignment.MiddleLeft;
            }
            else if (NumOfAttacks.SelectedIndex == 1)
            {
                InfoLabel1.TextAlign = ContentAlignment.TopLeft;
                groupBox2.Visible = true;
                Attack2Panel.Visible = true;
                groupBox3.Visible = false;
                Attack3Panel.Visible = false;
                Attack1Size.SelectedIndex = 5;
                Attack2Panel.Location = new Point(21, 360);
                if (InfoLabel1.Text.Length > 140)
                {
                    Attack1Panel.Size = new Size(345, 119);
                    InfoLabel1.Size = new Size(333, 88);
                    Attack1Panel.Location = new Point(21, 266);
                    Attack2Panel.Location = new Point(21, 384);
                }
                else
                {
                    Attack1Panel.Size = new Size(345, 58);
                    InfoLabel1.Size = new Size(333, 33);
                    Attack1Panel.Location = new Point(21, 290);
                    Attack2Panel.Location = new Point(21, 360);
                }
            }
            else if (NumOfAttacks.SelectedIndex == 2)
            {
                InfoLabel1.TextAlign = ContentAlignment.TopLeft;
                groupBox2.Visible = true;
                Attack2Panel.Visible = true;
                groupBox3.Visible = true;
                Attack3Panel.Visible = true;
                Attack1Panel.Location = new Point(21, 266);
                Attack2Panel.Location = new Point(21, 324);
                Attack3Panel.Location = new Point(21, 384);
            }
        }
        private void Cost1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost1, Energy1);
        }

        private void Cost2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost2, Energy2);
        }

        private void Cost3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost3, Energy3);
        }

        private void Cost4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost4, Energy4);
        }

        private void Cost5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost5, Energy5);
        }

        private void Cost6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost6, Energy6);
        }

        private void Cost7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost7, Energy7);
        }

        private void Cost8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost8, Energy8);
        }

        private void Cost9_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost9, Energy9);
        }

        private void Cost10_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost10, Energy10);
        }

        private void Cost11_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost11, Energy11);
        }

        private void Cost12_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEnergyX(Cost12, Energy12);
        }

        private void HasAbility_CheckedChanged(object sender, EventArgs e)
        {
            if(HasAbility.Checked == true)
            {
                Cost1.Visible = false;
                Cost2.Visible = false;
                Cost3.Visible = false;
                Cost4.Visible = false;
                AttackName1.Visible = false;
                Energy1.Visible = false;
                Energy2.Visible = false;
                Energy3.Visible = false;
                Energy4.Visible = false;
                label34.Visible = false;
                AttackDamage1.Visible = false;
                AbilityLogo.Visible = true;
                AbilityName.Visible = true;
            }
            else
            {
                Cost1.Visible = true;
                Cost2.Visible = true;
                Cost3.Visible = true;
                Cost4.Visible = true;
                AttackName1.Visible = true;
                Energy1.Visible = true;
                Energy2.Visible = true;
                Energy3.Visible = true;
                Energy4.Visible = true;
                label34.Visible = true;
                AttackDamage1.Visible = true;
                AbilityLogo.Visible = false;
                AbilityName.Visible = false;
            }
        }

        private void Attack1_TextChanged(object sender, EventArgs e)
        {
            AbilityName.Text = Attack1.Text;
            AttackName1.Text = Attack1.Text;
        }

        private void Damage1_TextChanged(object sender, EventArgs e)
        {
            AttackDamage1.Text = Damage1.Text;
        }

        private void Info1_TextChanged(object sender, EventArgs e)
        {
            InfoLabel1.Text = Info1.Text;
        }
        private void Attack2_TextChanged(object sender, EventArgs e)
        {
            AttackName2.Text = Attack2.Text;
        }
        private void Damage2_TextChanged(object sender, EventArgs e)
        {
            AttackDamage2.Text = Damage2.Text;
        }

        private void Info2_TextChanged(object sender, EventArgs e)
        {
            InfoLabel2.Text = Info2.Text;
        }

        private void Attack3_TextChanged(object sender, EventArgs e)
        {
            AttackName3.Text = Attack3.Text;
        }

        private void Damage3_TextChanged(object sender, EventArgs e)
        {
            AttackDamage3.Text = Damage3.Text;
        }

        private void Info3_TextChanged(object sender, EventArgs e)
        {
            InfoLabel3.Text = Info3.Text;
        }

        private void BWChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (BWChecked.Checked == true){
                panel3.BackColor = Color.White;
            }
            if (comboBox1.SelectedIndex == 8)
            {
                //Dark
                LabelName.ForeColor = Color.Black;
                AttackName1.ForeColor = Color.Black;
                AttackName2.ForeColor = Color.Black;
                AttackName3.ForeColor = Color.Black;
                InfoLabel1.ForeColor = Color.Black;
                InfoLabel2.ForeColor = Color.Black;
                InfoLabel3.ForeColor = Color.Black;
                IllustratorLabel.ForeColor = Color.Black;
                FlavourLabel.ForeColor = Color.Black;
                NoLabel.ForeColor = Color.Black;
                BottomTxtLabel.ForeColor = Color.Black;
                AttackDamage1.ForeColor = Color.Black;
                AttackDamage2.ForeColor = Color.Black;
                AttackDamage3.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                hplabel.ForeColor = Color.Black;
            }         
        }
        private void FontSize1_SelectedItemChanged(object sender, EventArgs e)
        {
            int font_size = Int16.Parse(FontSize1.SelectedItem.ToString());
            InfoLabel1.Font = new Font(InfoLabel1.Font.FontFamily, font_size);
        }

        private void FontSize2_SelectedItemChanged(object sender, EventArgs e)
        {
            int font_size = Int16.Parse(FontSize2.SelectedItem.ToString());
            InfoLabel2.Font = new Font(FontSize2.Font.FontFamily, font_size);
        }

        private void FontSize3_SelectedItemChanged(object sender, EventArgs e)
        {
            int font_size = Int16.Parse(FontSize3.SelectedItem.ToString());
            InfoLabel3.Font = new Font(FontSize3.Font.FontFamily, font_size);
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BWChecked.Checked = false;
            textBox1.Text = "";
            comboBox1.SelectedIndex = 0;
            textBox2.Text = "";
            comboBox2.SelectedIndex = 0;
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox3.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            richTextBox1.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
            comboBox6.SelectedIndex = 0;
            comboBox9.SelectedIndex = 0;
            NumOfAttacks.SelectedIndex = 0;
            HasAbility.Checked = false;
            Attack1.Text = "";
            Damage1.Text = "";
            Info1.Text = "";
            FontSize1.SelectedIndex = 2;
            Cost1.SelectedIndex = 0;
            Cost2.SelectedIndex = 0;
            Cost3.SelectedIndex = 0;
            Cost4.SelectedIndex = 0;
            Attack2.Text = "";
            Damage2.Text = "";
            Info2.Text = "";
            FontSize2.SelectedIndex = 2;
            Cost5.SelectedIndex = 0;
            Cost6.SelectedIndex = 0;
            Cost7.SelectedIndex = 0;
            Cost8.SelectedIndex = 0;
            Attack3.Text = "";
            Damage3.Text = "";
            Info3.Text = "";
            FontSize3.SelectedIndex = 2;
            Cost9.SelectedIndex = 0;
            Cost10.SelectedIndex = 0;
            Cost11.SelectedIndex = 0;
            Cost12.SelectedIndex = 0;           
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            string realPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\Saved\\");
            openFile.InitialDirectory = Path.GetFullPath(realPath);
            openFile.Filter = "txt files (*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string file_name = openFile.FileName;
                StringBuilder sb = new StringBuilder();
                List<String> list = new List<String>();
                using (StreamReader sr = new StreamReader(file_name))
                {
                    while(sr.Peek() >= 0)
                    {
                        sb.Append(sr.ReadLine());
                        list.Add(sb.ToString());
                        sb.Clear();
                    }
                }
                textBox1.Text = list[0];
                comboBox1.SelectedItem = list[1];
                textBox2.Text = list[2];
                comboBox2.SelectedItem = list[3];
                textBox4.Text = list[4];
                textBox3.Text = list[5];
                textBox5.Text = list[6];
                textBox6.Text = list[7];
                textBox7.Text = list[8];
                comboBox3.SelectedItem = list[9];
                comboBox7.SelectedItem = list[10];
                comboBox4.SelectedItem = list[11];
                comboBox8.SelectedItem = list[12];
                comboBox5.SelectedItem = list[13];
                richTextBox1.Text = list[14];
                textBox9.Text = list[15];
                textBox10.Text = list[16];
                textBox12.Text = list[17];
                textBox11.Text = list[18];
                comboBox6.SelectedItem = list[19];
                comboBox9.SelectedItem = list[20];
                NumOfAttacks.SelectedItem = list[21];
                if(list[22] == "True")
                {
                    HasAbility.Checked = true;
                }
                else
                {
                    HasAbility.Checked = false;
                }
                Attack1.Text = list[23];
                Damage1.Text = list[24];
                Info1.Text = list[25];
                FontSize1.SelectedItem = list[26];
                Cost1.SelectedItem = list[27];
                Cost2.SelectedItem = list[28];
                Cost3.SelectedItem = list[29];
                Cost4.SelectedItem = list[30];
                Attack2.Text = list[31];
                Damage2.Text = list[32];
                Info2.Text = list[33];
                FontSize2.SelectedItem = list[34];
                Cost5.SelectedItem = list[35];
                Cost6.SelectedItem = list[36];
                Cost7.SelectedItem = list[37];
                Cost8.SelectedItem = list[38];
                Attack3.Text = list[39];
                Damage3.Text = list[40];
                Info3.Text = list[41];
                FontSize3.SelectedItem = list[42];
                Cost9.SelectedItem = list[43];
                Cost10.SelectedItem = list[44];
                Cost11.SelectedItem = list[45];
                Cost12.SelectedItem = list[46];
                Attack1Pos.SelectedItem = list[47];
                Attack1Size.SelectedItem = list[48];
                Attack2Pos.SelectedItem = list[49];
                Attack2Size.SelectedItem = list[50];
                Attack3Pos.SelectedItem = list[51];
                Attack3Size.SelectedItem = list[52];
                comboBox10.SelectedItem = list[53];

                openFileDialog1.FileName = list[54];
                openFileDialog2.FileName = list[55];
                MainPicture.ImageLocation = openFileDialog1.FileName;
                TrainerPic.ImageLocation = openFileDialog1.FileName;
                PreviousImg.ImageLocation = openFileDialog2.FileName;
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.OverwritePrompt = true;
            string realPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\Saved\\");
            saveFile.InitialDirectory = Path.GetFullPath(realPath);
            saveFile.Filter = "txt files (*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFile.FileName))
                {
                    File.Delete(saveFile.FileName);
                }
                using (Stream s = File.Open(saveFile.FileName, FileMode.CreateNew))
                using(StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(comboBox1.SelectedItem);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(comboBox2.SelectedItem);
                    sw.WriteLine(textBox4.Text);
                    sw.WriteLine(textBox3.Text);
                    sw.WriteLine(textBox5.Text);
                    sw.WriteLine(textBox6.Text);
                    sw.WriteLine(textBox7.Text);
                    sw.WriteLine(comboBox3.SelectedItem);
                    sw.WriteLine(comboBox7.SelectedItem);
                    sw.WriteLine(comboBox4.SelectedItem);
                    sw.WriteLine(comboBox8.SelectedItem);
                    sw.WriteLine(comboBox5.SelectedItem);
                    sw.WriteLine(richTextBox1.Text);
                    sw.WriteLine(textBox9.Text);
                    sw.WriteLine(textBox10.Text);
                    sw.WriteLine(textBox12.Text);
                    sw.WriteLine(textBox11.Text);
                    sw.WriteLine(comboBox6.SelectedItem);
                    sw.WriteLine(comboBox9.SelectedItem);

                    sw.WriteLine(NumOfAttacks.SelectedItem);
                    sw.WriteLine(HasAbility.Checked.ToString());
                    sw.WriteLine(Attack1.Text);
                    sw.WriteLine(Damage1.Text);
                    sw.WriteLine(Info1.Text);
                    sw.WriteLine(FontSize1.SelectedItem);
                    sw.WriteLine(Cost1.SelectedItem);
                    sw.WriteLine(Cost2.SelectedItem);
                    sw.WriteLine(Cost3.SelectedItem);
                    sw.WriteLine(Cost4.SelectedItem);

                    sw.WriteLine(Attack2.Text);
                    sw.WriteLine(Damage2.Text);
                    sw.WriteLine(Info2.Text);
                    sw.WriteLine(FontSize2.SelectedItem);
                    sw.WriteLine(Cost5.SelectedItem);
                    sw.WriteLine(Cost6.SelectedItem);
                    sw.WriteLine(Cost7.SelectedItem);
                    sw.WriteLine(Cost8.SelectedItem);

                    sw.WriteLine(Attack3.Text);
                    sw.WriteLine(Damage3.Text);
                    sw.WriteLine(Info3.Text);
                    sw.WriteLine(FontSize3.SelectedItem);
                    sw.WriteLine(Cost9.SelectedItem);
                    sw.WriteLine(Cost10.SelectedItem);
                    sw.WriteLine(Cost11.SelectedItem);
                    sw.WriteLine(Cost12.SelectedItem);
                    sw.WriteLine(Attack1Pos.SelectedItem);
                    sw.WriteLine(Attack1Size.SelectedItem);
                    sw.WriteLine(Attack2Pos.SelectedItem);
                    sw.WriteLine(Attack2Size.SelectedItem);
                    sw.WriteLine(Attack3Pos.SelectedItem);
                    sw.WriteLine(Attack3Size.SelectedItem);
                    sw.WriteLine(comboBox10.SelectedItem);
                    sw.WriteLine(openFileDialog1.FileName);
                    sw.WriteLine(openFileDialog2.FileName);
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SaveCard_Click(object sender, EventArgs e)
        {
            int width = panel3.Size.Width;
            int height = panel3.Size.Height;
            Point location = panel3.PointToScreen(Point.Empty);

            Bitmap bm = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(bm))
            {
                graphics.CopyFromScreen(location, new Point(1, 1), new Size(bm.Size.Width+1, bm.Size.Height+1));
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                bm.Save(saveFile.FileName, ImageFormat.Bmp);
            }          
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            int item = Int32.Parse(Attack1Pos.SelectedItem.ToString());
            Attack1Panel.Location = new Point(21, 266+item);
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {
            int item = Int32.Parse(Attack1Size.SelectedItem.ToString());
            Attack1Panel.Size = new Size(345, 58 + item);
            InfoLabel1.Size = new Size(333, 33 + item);
        }

        private void Attack2Pos_SelectedItemChanged(object sender, EventArgs e)
        {
            int item = Int32.Parse(Attack2Pos.SelectedItem.ToString());
            Attack2Panel.Location = new Point(21, 324 + item);
        }

        private void Attack2Size_SelectedItemChanged(object sender, EventArgs e)
        {
            int item = Int32.Parse(Attack2Size.SelectedItem.ToString());
            Attack2Panel.Size = new Size(345, 58 + item);
            InfoLabel2.Size = new Size(333, 33 + item);
        }

        private void Attack3Pos_SelectedItemChanged(object sender, EventArgs e)
        {
            int item = Int32.Parse(Attack3Pos.SelectedItem.ToString());
            Attack3Panel.Location = new Point(21, 384 - item);
        }

        private void Attack3Size_SelectedItemChanged(object sender, EventArgs e)
        {
            int item = Int32.Parse(Attack3Size.SelectedItem.ToString());
            Attack3Panel.Size = new Size(345, 58 + item);
            InfoLabel3.Size = new Size(333, 33 + item);
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox10.SelectedIndex == 0)
            {
                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = true;
                panel8.Visible = true;
                panel9.Visible = true;
                label20.Text = "Flavour:";
            }
            else if (comboBox10.SelectedIndex == 1)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                panel6.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                label42.Text = "Trainer";
                label20.Text = "Trainer Ability:";
                TrainerTypeLbl.Text = "Supporter";
                TrainerTypeLbl.ForeColor = Color.FromArgb(227, 91, 48);
                TrainerInfoLbl.Text = "You may play only 1 Supporter card during your turn.";
                TrainerInfoLbl.BackColor = Color.FromArgb(246, 214, 150);
                
            }
            else if (comboBox10.SelectedIndex == 2)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                panel6.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                label42.Text = "Trainer";
                label20.Text = "Trainer Ability:";
                TrainerTypeLbl.Text = "Item";
                TrainerTypeLbl.ForeColor = Color.FromArgb(33, 93, 152);
                TrainerInfoLbl.Text = "You may play any number of Item cards during your turn.";                
                TrainerInfoLbl.BackColor = Color.FromArgb(175, 222, 241);
            }
            else if (comboBox10.SelectedIndex == 3)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                panel6.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                label42.Text = "Trainer";
                label20.Text = "Trainer Ability:";
                TrainerTypeLbl.Text = "Stadium";
                TrainerTypeLbl.ForeColor = Color.FromArgb(64, 174, 59);
                TrainerInfoLbl.Text = "This Stadium stays in play when you play it. Discard it if another Stadium comes into play. If a Stadium with the same name is in play, you can't play this card.";
                TrainerInfoLbl.BackColor = Color.FromArgb(210, 225, 164);
            }
            else if (comboBox10.SelectedIndex == 4)
            {
                panel3.Visible = false;
                panel4.Visible = true;
                panel5.Visible = false;
                panel6.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
            }
            else if (comboBox10.SelectedIndex == 5)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                panel6.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                label20.Text = "Effect:";
                TrainerTypeLbl.Text = "Energy";
                label42.Text = "Special Energy";
                TrainerTypeLbl.ForeColor = Color.LightGray;
                TrainerInfoLbl.Text = "Doesn't count as a basic Energy card.";
                TrainerInfoLbl.BackColor = Color.LightGray;
            }
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void TrainerStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (TrainerStyle.Checked)
            {
                PictureStyle.Visible = true;
            }
            else
            {
                PictureStyle.Visible = false;
            }
        }
    }
}
