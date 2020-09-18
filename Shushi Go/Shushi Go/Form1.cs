using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shushi_Go
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Card> Deck;

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deck.Add(new SetCard("tempura"));
            foreach(Card c in Deck)
            {
                if(c is SetCard)
                {
                    string name = ((SetCard)c).CardName;
                }
            }
        }
    }
}
