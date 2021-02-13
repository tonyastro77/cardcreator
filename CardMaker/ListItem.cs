using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardMaker
{
    public partial class ListItem : UserControl
    {
        Items item = new Items();
        public ListItem()
        {
            InitializeComponent();
        }

        private void ListItem_Load(object sender, EventArgs e)
        {
            item.Add(new Class1(1, "Felicia", "Oh my, what a lovely chick in my hut!", "Stop it. I carry a missive from the King", false));
            item.Add(new Class1(2, "Felicia", "You've found him! But who are you, my Lady?", "My name is Felicia, a royal page. The King sent me to find you", true));
            item.Add(new Class1(3, "Felicia", "You bitch! Can't you see I am sleeping!?", "Hey! Calm down, I'm here on royal business!", false));
            item.Add(new Class1(4, "Felicia", "Is the old bastard still alive?", "Hey! Calm down, I'm here on royal business!", false));
            item.Add(new Class1(5, "Felicia", "I can tell you are in season, want to breed?", "Hold your tongue!", false));
            item.Add(new Class1(6, "Felicia", "What does he need of me?", "Hey! Calm down, I'm here on royal business!", true));

        }
    }
}
