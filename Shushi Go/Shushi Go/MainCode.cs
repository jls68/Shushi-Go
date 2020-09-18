using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shushi_Go
{
    public partial class MainCode : Form
    {
        //James Sheaf-Morrison
        //1314151

        public MainCode()
        {
            InitializeComponent();
        }

        //Constant for wait time for opponent to show cards to player
        private const int WAIT = 400;

        //A list of all pre entered names of opponents
        public static readonly string[] CodedNames = { "Todd the Blind", "Spez the Quick", "Makky the Bull",
                "Emily the Gambler", "Sophie the Wise", "Ypoc the Cat", "Frank the Fisher", "David the Meak"};

        //#################### Global Variables ######################


        /// <summary>
        /// Random number generator
        /// </summary>
        private Random rand = new Random();

        /// <summary>
        /// Holds a list of cards in the deck
        /// </summary>
        private List<Card> deck = new List<Card>();

        /// <summary>
        /// Holds a list of players in the game
        /// </summary>
        private List<Player> players = new List<Player>();

        /// <summary>
        /// Determines if a card has been selected by user to be highlighted
        /// </summary>
        private Card selected = null;

        /// <summary>
        /// Holds the chopsticks after they are used
        /// </summary>
        private Card usedChopstick = null;


        private string playerName = "You the Player";

        //#################### Buttons ######################


        /// <summary>
        /// Makes visible the listbox to choose opponents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickOpponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxPickOp.Visible = true;
            //Update the combo boxes for any changes to the coded names
            int i = 2;
            foreach (string name in CodedNames)
            {
                comboBoxOp1.Items[i - 1] = name;
                comboBoxOp2.Items[i] = name;
                comboBoxOp3.Items[i] = name;
                comboBoxOp4.Items[i] = name;
                i++;
            }
            textBoxInfo.Text = "Pick up to four opponents to face. You must have at least the top most opponent selected."
                + " Just click the button marked 'Start' to begin with the selected opponnets, or go back into 'File'"
                + " and click 'Quick Start' to face off with a random opponent. /n If you want a challenge pick Emily the Gambler"
                + "as your opponent. If you want someone easy try Spez the Quick";
        }

        /// <summary>
        /// Starts a new game with selected opponents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (groupBoxPickOp.Visible == true)
            {
                //Clear past players
                players.Clear();
                //Add You the Player player to list of players
                players.Add(new Player(playerName));
                //Add selected opponents
                if (comboBoxOp1.Text != "Random")
                {
                    players.Add(new Player(comboBoxOp1.Text));
                }
                else
                {
                    players.Add(new Player(CodedNames[rand.Next(CodedNames.Length)]));
                }

                if (comboBoxOp2.Text != "No Opponent" && comboBoxOp2.Text != "Random")
                {
                    players.Add(new Player(comboBoxOp2.Text));
                }
                else if (comboBoxOp2.Text == "Random")
                {
                    players.Add(new Player(CodedNames[rand.Next(CodedNames.Length)]));
                }

                if (comboBoxOp3.Text != "No Opponent" && comboBoxOp3.Text != "Random")
                {
                    players.Add(new Player(comboBoxOp3.Text));
                }
                else if (comboBoxOp3.Text == "Random")
                {
                    players.Add(new Player(CodedNames[rand.Next(CodedNames.Length)]));
                }

                if (comboBoxOp4.Text != "No Opponent" && comboBoxOp4.Text != "Random")
                {
                    players.Add(new Player(comboBoxOp4.Text));
                }
                else if (comboBoxOp4.Text == "Random")
                {
                    players.Add(new Player(CodedNames[rand.Next(CodedNames.Length)]));
                }
                //Check that none of the names match the user's name
                foreach(Player p in players)
                {
                    if (p.Name == playerName && p != players[0])
                    {
                        p.Name += " ";
                    }
                    //while (p.Name == playerName && p != players[0])
                    //{
                    //    p.Name = CodedNames[rand.Next(CodedNames.Length)];
                    //}
                }

                //Create the game
                NewGame();
            }
        }

        /// <summary>
        /// Starts a new game with a random opponent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuickStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear past players
            players.Clear();
            //Add user player to list of players
            players.Add(new Player(playerName));
            //Add a random opponent
            players.Add(new Player(CodedNames[rand.Next(CodedNames.Length)]));

            //Create a new game
            NewGame();
        }
        
        /// <summary>
        /// Creates a new game with the same opponents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        /// <summary>
        /// Makes it possible to set the name for the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameYourselfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxNamer.Enabled = true;
            groupBoxNamer.Visible = true;
        }

        /// <summary>
        /// Changes player name to the entered name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnteredName_Click(object sender, EventArgs e)
        {
            bool error = false;
            string newName;

            try
            {
                newName = textBoxPlayerName.Text;
                foreach (Player p in players)
                {
                    if (newName == p.Name && p != players[0])
                    {
                        error = true;
                        break;
                    }
                }
                if (!error)
                {
                    playerName = newName;
                    if (players.Count > 0)
                    {
                        players[0].Name = playerName;
                    }
                    groupBoxNamer.Enabled = false;
                    groupBoxNamer.Visible = false;
                    DisplayGame();
                    listBoxScores.Items[5] = (playerName + ": ");
                }
                else
                {
                    MessageBox.Show("A player already has this name");
                }
            }
            catch
            { 
                //Just ignore the errors
            }
        }

        /// <summary>
        /// Hides the naming self controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelName_Click(object sender, EventArgs e)
        {
            groupBoxNamer.Enabled = false;
            groupBoxNamer.Visible = false;
        }

        /// <summary>
        /// Check if a card in You the Player hand has been clicked on and if so mark as selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPlayArea_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics paper = pictureBoxPlayArea.CreateGraphics();

            //Check that a game has been started by checking for players
            if (players.Count > 0)
            {
                bool matchFound = false;

                //Check if mouse clicked on a card in You the Player's hand (Player[0])
                foreach (Card c in players[0].Hand)
                {
                    if (c.IsMouseOn(e.X, e.Y))
                    {
                        selected = c;
                        matchFound = true;
                        break;
                    }
                }
                
                //IF a match was found display highlighted card with info
                if (matchFound)
                {
                    DisplayUser();
                    textBoxInfo.Text = selected.Information();
                }
                //ELSE make selecetd null if need to and see if a card in front was clicked
                else
                {
                    if (selected != null)
                    {
                        selected = null;
                        DisplayUser();
                    }
                    //Check if the mouse clicked on a card in front of a player
                    foreach (Player p in players)
                    {
                        foreach (Card c in p.InFront)
                        {
                            if (c.IsMouseOn(e.X, e.Y))
                            {
                                c.Highlight(paper, p == players[0], players.Count - 1);
                                textBoxInfo.Text = c.Information();
                                System.Threading.Thread.Sleep(WAIT * 2);
                                matchFound = true;
                                break;
                            }
                        }
                    }
                    //If a mtach was found then redisplay play area
                    if (matchFound)
                    {
                        DisplayGame();
                    }
                }
            }
        }

        /// <summary>
        /// Play selected card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayCard_Click(object sender, EventArgs e)
        {
            //IF a card is selected
            if (selected != null)
            {
                //User plays his selected card

                //IF it is a chopstick card make the Chopsticks button visible
                if (selected is Chopsticks)
                {
                    buttonChopsticks.Visible = true;
                }
                players[0].PlayCard(selected);
                selected = null;

                //Add any used chopstick cards back to the You the Player's hand before swapping
                if (usedChopstick != null)
                {
                    players[0].Hand.Add(usedChopstick);
                    usedChopstick = null;
                }

                //Redisplay player's cards
                DisplayUser();

                //Now opponents play their cards
                foreach (Player p in players)
                {
                    if (p.Name != playerName)
                    {
                        OpponentTurn(p);
                    }
                }

                //IF there is a card left in player's hand then go to the next turn
                if (players[0].Hand.Count > 0)
                {
                    NextTurn();
                }
                //ELSE go to the next round
                else
                {
                    NewRound();
                }

            }
            //ELSE IF a game has not be started (No players created), then quick start a new game
            else if (players.Count < 1)
            {
                //Clear past players
                players.Clear();
                //Add user player to list of players
                players.Add(new Player(playerName));
                //Add a random opponent
                players.Add(new Player(CodedNames[rand.Next(CodedNames.Length)]));

                //Create a new game
                NewGame();
            }
            //ELSE inform user they need to select a card in hand
            else
            {
                textBoxInfo.Text = "You need to click on a card in your hand to selected it before you can play that card.";
            }
        }

        /// <summary>
        /// Button activates a user played chopstick card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChopsticks_Click(object sender, EventArgs e)
        {
            if (buttonChopsticks.Visible == true)
            {
                //If only one card left in hand remove chopstick button
                if (players[0].Hand.Count <= 1)
                {
                    buttonChopsticks.Visible = false;
                    textBoxInfo.Text = "Chopstick card can't be activated as you only have one card left in hand. Just play that card as normal";
                }
                else if (selected != null)
                {
                    //IF second time through change the colour to something less distracting
                    if (buttonChopsticks.Text == "Sushi Go! Activate Chopsticks")
                    {
                        buttonChopsticks.BackColor = Color.Salmon;
                    }
                    foreach (Card c in players[0].InFront)
                    {
                        if (c is Chopsticks)
                        {
                            selected = UseChopsticks(players[0], selected, c);
                            //buttonChopsticks.Visible = false;
                            DisplayUser();
                            break;
                        }
                    }
                    buttonChopsticks.Text = "Sushi Go! Activate Chopsticks";
                }
                else
                {
                    textBoxInfo.Text = "Are you trying to use your chopsticks without first selecting a card? How stupid, you make me laugh hahaha!";
                }
            }
        }

        /// <summary>
        /// If a resize occurs the game need to be redrawn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPlayArea_Resize(object sender, EventArgs e)
        {
            DisplayGame();
        }

        /// <summary>
        /// Closes application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing");
            this.Close();
        }

        /// <summary>
        /// Opens a pdf containing the rules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ruleBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"..\..\..\Card_Images\SushiGoTM-RULES.pdf");
            }
            catch
            {
                MessageBox.Show("The pdf was unable to open");
            }
        }


        //#################### Methods ######################


        /// <summary>
        /// Creates a new game
        /// </summary>
        private void NewGame()
        {
            //Give info on who opponents are
            textBoxInfo.Text = "Welcome " + playerName + " to Sushi Go! You will playing against";
            buttonPlayCard.Text = "Play Selected Card";

            foreach(Player p in players)
            {
                p.Hand.Clear();
                p.InFront.Clear();
            }

            //Make the restart button visible
            restartToolStripMenuItem.Visible = true;
            //Make sure the pick opponent list and button are not visible
            groupBoxPickOp.Visible = false;

            //Recreate scoreboard
            listBoxScores.Items.Clear();
            listBoxScores.Items.Add("Round");
            listBoxScores.Items.Add("0");
            listBoxScores.Items.Add("");
            listBoxScores.Items.Add("Scoreboard");
            listBoxScores.Items.Add("");
            foreach (Player p in players)
            {
                int n = 1;

                p.InFront.Clear();

                listBoxScores.Items.Add(p.Name + ": ");
                listBoxScores.Items.Add("");
                if(p.Name != playerName)
                {
                    if (n > 2)
                    {
                        textBoxInfo.Text += " ,";
                    }
                    if(n == players.Count)
                    {
                        textBoxInfo.Text += "and";
                    }
                    textBoxInfo.Text += " " + p.Name;
                }
                n++;
            }
            textBoxInfo.Text += ". You will get three rounds to get the highest score. A round goes until all cards in your"
                + " hand have been played. Each time you play a card you will swap hands in a clockwise direction, so keep"
                + " track of what cards you are giving to your opponent and when you might get those cards back. Good Luck.";
            
            //Create the deck of cards
            NewDeck();
            //Each player draws a new hand
            NewRound();
            //Show hands
            DisplayGame();
        }

        /// <summary>
        /// Creates a new deck of cards
        /// </summary>
        private void NewDeck()
        {
            deck.Clear();

            for (int n = 0; n < 14; n++)
            {
                //Add 14x Tempura, 14x Sashimi, and 14x Dumpling 
                deck.Add(new SetCard("tempura"));
                deck.Add(new SetCard("sashimi"));
                deck.Add(new SetCard("dumpling"));
                if (n < 12)
                {
                    //Add 12x 2 Maki rolls 
                    deck.Add(new Maki_rolls(2));
                    if (n < 10)
                    {
                        //Add 10x Salmon (2) Nigiri and 10x Pudding
                        deck.Add(new Nigiri(2));
                        deck.Add(new Pudding());
                        if (n < 8)
                        {
                            //Add 8x 3 Maki rolls
                            deck.Add(new Maki_rolls(3));
                            if (n < 6)
                            {
                                //Add 6x 1 Maki roll and 6x Wasabi
                                deck.Add(new Maki_rolls(1));
                                deck.Add(new Wasabi());
                                if (n < 5)
                                {
                                    //Add 5x Squid (3) Nigiri and 5x Egg (1) Nigiri
                                    deck.Add(new Nigiri(3));
                                    deck.Add(new Nigiri(1));
                                    if (n < 4)
                                    {
                                        //Add 4x Chopsticks
                                        deck.Add(new Chopsticks());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Gives each player a new hand and clears all non pudding cards played
        /// </summary>
        private void NextTurn()
        {
            List<Card> tempHand1 = players[0].Hand;
            List<Card> tempHand2;

            //FOREACH player in this game give their hand to the next player
            for (int i = 1; i <= players.Count; i++)
            {
                if (i < players.Count)
                {
                    tempHand2 = players[i].Hand;
                    players[i].Hand = tempHand1;
                    tempHand1 = tempHand2;
                }
                else
                {
                    players[0].Hand = tempHand1;
                }
            }
            //Redisplay with new hands
            DisplayGame();
            textBoxInfo.Text = "New hand. Remember " + players[players.Count - 1].Name
                + " just had these cards.";
        }

        /// <summary>
        /// Gives each player a new hand
        /// </summary>
        private void NewRound()
        {
            //Get round number
            int roundNum = int.Parse(listBoxScores.Items[1].ToString());
            int[] scores = new int[players.Count];
            int winner = 0;

            //Make chopstick button invisible
            buttonChopsticks.Visible = false;

            //If round number is greater than 0 Calculate the round scores
            if (roundNum > 0)
            {
                scores = RoundScore();
            }

            //Add 1 to the round number in the listbox
            listBoxScores.Items[1] = (roundNum + 1).ToString();

            //FOREACH player in this game get their score and give them a new hand of cards
            foreach (Player p in players)
            {
                //FOREACH card played in front of player
                for (int n = p.InFront.Count - 1; n >= 0; n--)
                {
                    //Remove all non pudding cards from the played area / in front
                    if (!(p.InFront[n] is Pudding))
                    {
                        p.InFront.Remove(p.InFront[n]);
                    }
                }

                //If not the 3rd and final round prepare for next round
                if (roundNum < 3)
                {
                    //Draw cards equal to 12 minus the number of players from the deck
                    for (int n = 0; n < 12 - players.Count; n++)
                    {
                        //Add a random card from the deck then remove that card from the deck
                        int i = rand.Next(deck.Count);
                        p.Hand.Add(deck[i]);
                        deck.RemoveAt(i);
                    }
                }
            }

            for (int i = 0; i < players.Count; i++)
            {
                //Display scores
                listBoxScores.Items[6 + (i * 2)] = scores[i].ToString();
            }

            if (roundNum == 3)
            {
                scores = PuddingScore(scores);
                //Find index for player with the highest score
                for (int i = 1; i < players.Count; i++)
                {
                    if (scores[winner] < scores[i])
                    {
                        winner = i;
                    }
                }
                DisplayGame();
                MessageBox.Show("Winner is " + players[winner].Name + " with a grand total of " + scores[winner] + " points.");
                NewGame();
            }
            DisplayGame();
        }

        /// <summary>
        /// Displays the cards in hands and play area
        /// </summary>
        private void DisplayGame()
        {
            Graphics paper = pictureBoxPlayArea.CreateGraphics();

            pictureBoxPlayArea.Refresh();

            foreach (Player p in players)
            {
                //You the Player has its own method 
                if (p.Name == playerName)
                {
                    DisplayUser();
                }
                else
                {
                    DisplayOpponent(p);
                }
            }
        }

        /// <summary>
        /// Displays the hand and what is infornt of the user
        /// </summary>
        private void DisplayUser()
        {
            Graphics paper = pictureBoxPlayArea.CreateGraphics();
            Brush br = new SolidBrush(pictureBoxPlayArea.BackColor);
            int width = pictureBoxPlayArea.Width / 12;
            int height = pictureBoxPlayArea.Height / 4;

            //Basically refreshes back of You the Player's area
            paper.FillRectangle(br, 0, pictureBoxPlayArea.Height / 2, pictureBoxPlayArea.Width, pictureBoxPlayArea.Height);


            //Set for You the Player's hand and play area first
            Rectangle areaHand = new Rectangle(width, pictureBoxPlayArea.Height - height, width, height);
            Rectangle areaPlayed = new Rectangle(width, pictureBoxPlayArea.Height - (height * 2) + (height / 4), width / 2, height / 2);

            foreach (Card c in players[0].Hand)
            {
                c.Display(paper, areaHand, true);
                areaHand.X += width;
            }

            foreach (Card c in players[0].InFront)
            {
                c.Display(paper, areaPlayed, true);
                areaPlayed.X += width / 2;
                //IF played cards are about to start going off  the side of the play area then start a new row
                if(areaPlayed.X > pictureBoxPlayArea.Width - width)
                {
                    areaPlayed.X = width;
                    areaPlayed.Y += height / 2;
                }
            }

            //Display any Selected card as (highlighted) double in size
            if (selected != null)
            {
                selected.Highlight(paper, true, 1);
            }
        }

        /// <summary>
        /// Displays the opponent's hand and played cards
        /// </summary>
        /// <param name="p">The Opponent to have cards displayed</param>
        private void DisplayOpponent(Player p)
        {
            //Declare and calculate variables
            Graphics paper = pictureBoxPlayArea.CreateGraphics();
            SolidBrush br = new SolidBrush(pictureBoxPlayArea.BackColor);
            Font font = new System.Drawing.Font("Arial", 16);
            int opNum = players.Count - 1;
            int width = (int)(((pictureBoxPlayArea.Width / 12) / opNum) * (10.0 / (11 - opNum)));
            int height = pictureBoxPlayArea.Height / 4;
            int moveRight = 0;
            int index = 0;

            //Find the index indicating which region the opponent is in
            foreach (Player player in players)
            {
                if (p == player)
                {
                    break;
                }
                index++;
            }
            moveRight = (pictureBoxPlayArea.Width / opNum) * (index - 1);
            //Refresh opponents area of the play area
            paper.FillRectangle(br, 0 + moveRight, 0, pictureBoxPlayArea.Width / opNum, pictureBoxPlayArea.Height / 2);

            //Set for opponents hand and play area
            Rectangle areaHand = new Rectangle(width + moveRight, 0, width, height);
            Rectangle areaPlayed = new Rectangle(width + moveRight, (2 * height) - (height / 2) - (height / 4), width / 2, height / 2);
            foreach (Card c in p.Hand)
            {
                c.Display(paper, areaHand, false);
                areaHand.X += width;
            }

            foreach (Card c in p.InFront)
            {
                c.Display(paper, areaPlayed, true);
                areaPlayed.X += width / 2;
                //IF played cards are about to start going off the side of their play area then start a new row
                if (areaPlayed.X > (pictureBoxPlayArea.Width / opNum) * index - width)
                {
                    areaPlayed.X = width;
                    areaPlayed.Y -= height / 2;
                }
            }
            //Display name
            br.Color = Color.Black;
            paper.DrawString(p.Name, font, br, width + moveRight, height);
        }

        /// <summary>
        /// Does the opponent's turn
        /// </summary>
        /// <param name="opt">Opponent</param>
        private void OpponentTurn(Player opt)
        {
            Graphics paper = pictureBoxPlayArea.CreateGraphics();
            Card pick = null;
            string tempStr = opt.Name;
            bool noMatch = true;

            foreach(String name in CodedNames)
            {
                if (opt.Name == name)
                {
                    noMatch = false;
                    break;
                }
            }
            if (noMatch)
            {
                tempStr = opt.Name;
                opt.Name = CodedNames[rand.Next(CodedNames.Length)] ;
            }

            //Call method to pick a card
            pick = PickCard(opt);

            //IF a chopstick card is in front, and a chopstick was not already used, and it is not Todd then use it
            if (usedChopstick == null && opt.Hand.Count >= 2)
            {
                foreach (Card c in opt.InFront)
                //Only needs to check last two played cards
                //for (int c = opt.InFront.Count - 1; c < opt.InFront.Count - 2 && c >= 0; c--)
                {
                    //if (opt.InFront[c] is Chopsticks)
                    if (c is Chopsticks)
                    {
                        System.Threading.Thread.Sleep(WAIT);
                        pick.Highlight(paper, false, 1);
                        textBoxInfo.Text = "Sushi Go! Yells " + tempStr;
                        System.Threading.Thread.Sleep(WAIT);
                        //pick = UseChopsticks(opt, pick, opt.InFront[c]);
                        pick = UseChopsticks(opt, pick, c);
                        break;
                    }
                }
            }

            //IF chopstick card was used then pick another card to play
            if (pick == null)
            {
                pick = PickCard(opt); ;
            }

            //Return name to what it was entered as
            opt.Name = tempStr;
            //Wait then show picked card
            System.Threading.Thread.Sleep(WAIT);
            pick.Highlight(paper, false, 1);
            //Wait then play picked card
            System.Threading.Thread.Sleep(WAIT);
            opt.PlayCard(pick);
            //Add any used chopstick cards back to the players hand before swapping
            if (usedChopstick != null)
            {
                opt.Hand.Add(usedChopstick);
                usedChopstick = null;
            }
            DisplayOpponent(opt);
        }

        /// <summary>
        /// Picks a card for opponent to play
        /// </summary>
        /// <param name="opt">The opponent</param>
        /// <returns></returns>
        private Card PickCard(Player opt)
        {
            //Declare variables
            Card pick = null;
            //0 = maki, 1 = nigiri, 2 = tempura, 3 = sashimi, 4 = dumpling, 5 = pudding, 6 = chopsticks, 7 = wasabi
            int[,] handCont = new int[8, 2];
            int[] frontCont = new int[8];

            //Get an easily read collection of what cards are in hand
            handCont = GetHandList(handCont, opt.Hand);

            //Get an easily read collection of what cards are in front of player
            frontCont = GetInFrontList(frontCont, opt);

            //Check who opponent is and act accordingly
            if (opt.Name == "Todd the Blind")
            {
                //Picks at random
                pick = opt.Hand[rand.Next(opt.Hand.Count)];
            }
            else if (opt.Name == "Spez the Quick")
            {
                //Always picks the first card in hand
                pick = opt.Hand[0];
            }
            else if (opt.Name == "Makky the Bull")
            {
                //ELSE IF there is a sashimi and you need one more for a trio play that
                if (handCont[3, 0] > 0 && frontCont[3] % 3 == 2)
                {
                    pick = opt.Hand[handCont[3, 0] - 1];
                }
                //IF a wasabi is in front and a nigiri is in hand play that nigiri
                else if (frontCont[7] > 0 && handCont[1, 0] > 0)
                {
                    pick = opt.Hand[handCont[1, 0] - 1];
                }
                //ELSE IF there is a tempura and you have an odd numbe of tempura play that
                else if (handCont[2, 0] > 0 && frontCont[2] % 2 == 1)
                {
                    pick = opt.Hand[handCont[2, 0] - 1];
                }
                //ELSE IF you have no more than 4 more maki icons than the next highest person then pick the highest maki card if able
                else if (handCont[0, 0] > 0 && frontCont[1] > -4)
                {
                    pick = opt.Hand[handCont[0, 0] - 1];
                }
                //ELSE IF no maki cards then pick any chopstick cards
                else if (handCont[6, 0] > 0)
                {
                    pick = opt.Hand[handCont[6, 0] - 1];
                }
                //ELSE IF no chopstick cards then pick any wasabi cards
                else if (handCont[7, 0] > 0)
                {
                    pick = opt.Hand[handCont[7, 0] - 1];
                }

            }
            //0 = maki, 1 = nigiri, 2 = tempura, 3 = sashimi, 4 = dumpling, 5 = pudding, 6 = chopsticks, 7 = wasabi
            else if (opt.Name == "Emily the Gambler")
            {
                //IF there is a sashimi and you need one more for a trio play that
                if (handCont[3, 0] > 0 && frontCont[3] % 3 == 2)
                {
                    pick = opt.Hand[handCont[3, 0] - 1];
                }
                //ELSE IF there is a tempura and you have an odd numbe of tempura play that
                else if (handCont[2, 0] > 0 && frontCont[2] % 2 == 1)
                {
                    pick = opt.Hand[handCont[2, 0] - 1];
                }
                //ELSE IF a wasabi is in front and a nigiri is in hand play that nigiri if that nigiri is worth more than 1
                else if (frontCont[7] > 0 && handCont[1, 0] > 0 && handCont[1, 1] > 1)
                {
                    pick = opt.Hand[handCont[1, 0] - 1];
                }
                //ELSE IF pick any chopstick cards if you have more than 2 cards in hand
                else if (handCont[6, 0] > 0 && opt.Hand.Count > 2)
                {
                    pick = opt.Hand[handCont[6, 0] - 1];
                }
                //ELSE IF no chopstick cards then pick any wasabi cards
                else if (handCont[7, 0] > 0)
                {
                    pick = opt.Hand[handCont[7, 0] - 1];
                }
                //ELSE IF there is a dumpling play that and don't already have 5
                else if (handCont[4, 0] > 0 && frontCont[4] < 5)
                {
                    pick = opt.Hand[handCont[4, 0] - 1];
                }
                //ELSE IF there is a sashimi play that and don't already have 3
                else if (handCont[3, 0] > 0 && frontCont[3] < 3)
                {
                    pick = opt.Hand[handCont[3, 0] - 1];
                }
                //ELSE IF there is a tempura play that and don't already have 2
                else if (handCont[2, 0] > 0 && frontCont[2] < 2)
                {
                    pick = opt.Hand[handCont[2, 0] - 1];
                }
                //ELSE IF you have no more than 1 more maki icons than the next highest person then pick the highest maki card if able
                else if (handCont[0, 0] > 0 && frontCont[1] > -1)
                {
                    pick = opt.Hand[handCont[0, 0] - 1];
                }

            }
            //0 = maki, 1 = nigiri, 2 = tempura, 3 = sashimi, 4 = dumpling, 5 = pudding, 6 = chopsticks, 7 = wasabi
            else if (opt.Name == "Sophie the Wise")
            {
                //IF there is a sashimi and you need one more for a trio play that
                if (handCont[3, 0] > 0 && frontCont[3] % 3 == 2)
                {
                    pick = opt.Hand[handCont[3, 0] - 1];
                }
                //ELSE IF a wasabi is in front and a nigiri is in hand play that nigiri if that nigiri is worth 3
                else if (frontCont[7] > 0 && handCont[1, 0] > 0 && handCont[1, 1] == 3)
                {
                    pick = opt.Hand[handCont[1, 0] - 1];
                }
                //ELSE IF there is a tempura and you have an odd numbe of tempura play that
                else if (handCont[2, 0] > 0 && frontCont[2] % 2 == 1)
                {
                    pick = opt.Hand[handCont[2, 0] - 1];
                }
                //ELSE IF pick any chopstick cards if no more than one chopstick card is in front and you have at least 3 cards in hand
                else if (handCont[6, 0] > 0 && opt.Hand.Count > 2 && frontCont[6] < 2)
                {
                    pick = opt.Hand[handCont[6, 0] - 1];
                }
                //ELSE IF no chopstick cards then pick any wasabi cards
                else if (handCont[7, 0] > 0)
                {
                    pick = opt.Hand[handCont[7, 0] - 1];
                }
                //ELSE IF there is a dumpling play that and don't already have 5
                else if (handCont[4, 0] > 0 && frontCont[4] < 5)
                {
                    pick = opt.Hand[handCont[4, 0] - 1];
                }
                //ELSE IF a wasabi is in front and a nigiri is in hand play that nigiri if that nigiri is worth 2
                else if (frontCont[7] > 0 && handCont[1, 0] > 0 && handCont[1, 1] == 2)
                {
                    pick = opt.Hand[handCont[1, 0] - 1];
                }
                //ELSE IF there is a sashimi play that and don't already have 3
                else if (handCont[3, 0] > 0 && frontCont[3] < 3)
                {
                    pick = opt.Hand[handCont[3, 0] - 1];
                }
                //ELSE IF there is a tempura play that and don't already have 2
                else if (handCont[2, 0] > 0 && frontCont[2] < 2)
                {
                    pick = opt.Hand[handCont[2, 0] - 1];
                }
                //ELSE IF you have no more than 1 more maki icons than the next highest person then pick the highest maki card if able
                else if (handCont[0, 0] > 0 && frontCont[1] > -1)
                {
                    pick = opt.Hand[handCont[0, 0] - 1];
                }
            }
            else if (opt.Name == "Ypoc the Cat")
            {
                //Attempt to mimic the player
                foreach (Card c in opt.Hand)
                {
                    if (players[0].InFront[players[0].InFront.Count - 1] == c)
                    {
                        pick = c;
                        break;
                    }
                }
                //IF there is a sashimi and you need one more for a trio play that
                if (handCont[3, 0] > 0 && frontCont[3] % 3 == 2)
                {
                    pick = opt.Hand[handCont[3, 0] - 1];
                }
                //ELSE IF there is a tempura and you have an odd numbe of tempura play that
                else if (handCont[2, 0] > 0 && frontCont[2] % 2 == 1)
                {
                    pick = opt.Hand[handCont[2, 0] - 1];
                }
            }
            //0 = maki, 1 = nigiri, 2 = tempura, 3 = sashimi, 4 = dumpling, 5 = pudding, 6 = chopsticks, 7 = wasabi
            else if (opt.Name == "Frank the Fisher")
            {
                //IF there is a sashimi and you need one more for a trio play that
                if (handCont[3, 0] > 0 && frontCont[3] % 3 == 2)
                {
                    pick = opt.Hand[handCont[3, 0] - 1];
                }
                //ELSE IF a wasabi is in front and a nigiri is in hand play that nigiri if that nigiri is worth 3
                else if (frontCont[7] > 0 && handCont[1, 0] > 0 && handCont[1, 1] == 3)
                {
                    pick = opt.Hand[handCont[1, 0] - 1];
                }
                //ELSE IF there is a tempura and you have an odd numbe of tempura play that
                else if (handCont[2, 0] > 0 && frontCont[2] % 2 == 1)
                {
                    pick = opt.Hand[handCont[2, 0] - 1];
                }
                //ELSE IF pick any chopstick cards if no more than one chopstick card is in front and you have at least 3 cards in hand
                else if (handCont[6, 0] > 0 && opt.Hand.Count > 2 && frontCont[6] < 2)
                {
                    pick = opt.Hand[handCont[6, 0] - 1];
                }
                //ELSE IF no chopstick cards then pick any wasabi cards
                else if (handCont[7, 0] > 0)
                {
                    pick = opt.Hand[handCont[7, 0] - 1];
                }
                //ELSE IF there is a nigiri worth 3 play
                else if (handCont[1, 0] > 0 && handCont[1, 1] == 3)
                {
                    pick = opt.Hand[handCont[1, 0] - 1];
                }
                //ELSE IF a wasabi is in front and a nigiri is in hand play that nigiri if that nigiri is worth 2
                else if (frontCont[7] > 0 && handCont[1, 0] > 0 && handCont[1, 1] == 2)
                {
                    pick = opt.Hand[handCont[1, 0] - 1];
                }
                //ELSE IF there is a tempura play that if either it is early in the game
                else if (handCont[2, 0] > 0  && opt.Hand.Count > 6)
                {
                    pick = opt.Hand[handCont[2, 0] - 1];
                }
                //ELSE IF there is a nigiri just play that
                else if (handCont[1, 0] > 0)
                {
                    pick = opt.Hand[handCont[1, 0] - 1];
                }
                //ELSE IF you have no more than 1 more maki icons than the next highest person then pick the highest maki card if able
                else if (handCont[0, 0] > 0 && frontCont[1] > -1)
                {
                    pick = opt.Hand[handCont[0, 0] - 1];
                }
            }
            //IF no card was pick then choose a random card in hand
            if (pick == null)
            {
                pick = opt.Hand[rand.Next(opt.Hand.Count)];
            }
            return pick;
        }

        /// <summary>
        /// Converts a list of cards into an int array to help with opponent decision making
        /// </summary>
        /// <param name="handCont"></param>
        /// <param name="hand"></param>
        /// <returns></returns>
        private int[,] GetHandList(int[,] handCont, List<Card> hand)
        {
            //Remember to minus one later, this is so a zero means no card was found
            int i = 1;

            //0 = maki, 1 = nigiri, 2 = tempura, 3 = sashimi, 4 = dumpling, 5 = pudding, 6 = chopsticks, 7 = wasabi
            foreach (Card c in hand)
            {
                if (c is Maki_rolls)
                {
                    if (handCont[0, 1] < ((Maki_rolls)c).Icons)
                    {
                        handCont[0, 0] = i;
                        handCont[0, 1] = ((Maki_rolls)c).Icons;
                    }
                }
                else if (c is Nigiri)
                {
                    if (handCont[1, 1] < ((Nigiri)c).Amount)
                    {
                        handCont[1, 0] = i;
                        handCont[1, 1] = ((Nigiri)c).Amount;
                    }
                }
                else if (c is SetCard)
                {
                    if (((SetCard)c).CardName == "tempura")
                    {
                        handCont[2, 0] = i;
                        handCont[2, 1] += 1;
                    }
                    else if (((SetCard)c).CardName == "sashimi")
                    {
                        handCont[3, 0] = i;
                        handCont[3, 1] += 1;
                    }
                    else if (((SetCard)c).CardName == "dumpling")
                    {
                        handCont[4, 0] = i;
                        handCont[4, 1] += 1;
                    }
                }
                else if (c is Pudding)
                {
                    handCont[5, 0] = i;
                    handCont[5, 1] += 1;
                }
                else if (c is Chopsticks)
                {
                    handCont[6, 0] = i;
                }
                else if (c is Wasabi)
                {
                    handCont[7, 0] = i;
                }
                else
                {
                    MessageBox.Show("Error finding what type of card is " + c.ToString());
                }
                i++;
            }

            return handCont;
        }

        /// <summary>
        /// Converts a list of cards in front of opponent to be more easily read
        /// </summary>
        /// <param name="frontCont"></param>
        /// <param name="front"></param>
        /// <returns></returns>
        private int[] GetInFrontList(int[] frontCont, Player opt)
        {
            //0 = maki, 1 = nigiri, 2 = tempura, 3 = sashimi, 4 = dumpling, 5 = pudding, 6 = chopsticks, 7 = wasabi
            foreach (Card c in opt.InFront)
            {
                if (c is Maki_rolls)
                {
                    frontCont[0] += ((Maki_rolls)c).Icons;
                }
                //Can't see a reason why the score amount from played nigiri matter
                else if (c is Nigiri)
                {
                //    frontCont[1] += ((Nigiri)c).Amount;
                }
                else if (c is SetCard)
                {
                    if (((SetCard)c).CardName == "tempura")
                    {
                        frontCont[2] += 1;
                    }
                    else if (((SetCard)c).CardName == "sashimi")
                    {
                        frontCont[3] += 1;
                    }
                    else if (((SetCard)c).CardName == "dumpling")
                    {
                        frontCont[4] += 1;
                    }
                }
                else if (c is Pudding)
                {
                    frontCont[5] += 1;
                }
                else if (c is Chopsticks)
                {
                    frontCont[6] += 1;
                }
                else if (c is Wasabi)
                {
                    frontCont[7] += 1;
                }
                else
                {
                    MessageBox.Show("Error finding what type of card is " + c.ToString());
                }
            }
            //Maki icons are more useful compared to other players
            //So using the empty spot nigiri would take we can put the difference between this maki count and the highest
            foreach (Player p in players)
            {
                if (frontCont[1] < p.MakiIconCount() && p != opt)
                {
                    frontCont[1] = p.MakiIconCount();
                }
            }
            frontCont[1] -= frontCont[0];

            return frontCont;
        }

        /// <summary>
        /// Uses a chopstick card to swap with a card in hand
        /// </summary>
        /// <param name="p">The current player</param>
        /// <param name="pick">Card to be swapped with</param>
        /// <param name="chopsticks">The chopstick card being activated</param>
        /// <returns></returns>
        private Card UseChopsticks(Player p, Card pick, Card chopsticks)
        {
            //Move chopstick card to hand
            usedChopstick = chopsticks;
            p.InFront.Remove(chopsticks);
            //Play selected card
            p.PlayCard(pick);
            pick = null;
            return pick;
        }

        /// <summary>
        /// Calculates the score earned in that round
        /// </summary>
        /// <returns></returns>
        private int[] RoundScore()
        {
            int i = 0;
            int[] makiCount = new int[players.Count];
            int[] scores = new int[players.Count];
            //Second number indicates those with the same amount in this position
            int[,] position = new int[2,2];

            foreach (Player p in players)
            {
                //Get old scores
                int.TryParse(listBoxScores.Items[6 + (i * 2)].ToString(), out scores[i]);

                //Gets the score of cards except for maki rolls and pudding
                //Which require to be compared to the other players
                scores[i] += p.PartialScore();
                //Count how many maki roll icons each player has
                makiCount[i] = p.MakiIconCount(); 
                i++;
            }
            //Go through twice to make sure second spot is correct
            for (int n = 0; n < 2; n++)
            {
                i = 0;
                position[0, 1] = 1;
                position[1, 1] = 1;
                foreach (Player p in players)
                {
                    if (makiCount[i] > position[0, 0])
                    {
                        position[0, 0] = makiCount[i];
                        position[0, 1] = 1;
                    }
                    else if (makiCount[i] == position[0, 0])
                    {
                        position[0, 1] += 1;
                    }
                    else if (makiCount[i] == position[1, 0])
                    {
                        position[1, 1] += 1;
                    }
                    else
                    {
                        position[1, 0] = makiCount[i];
                        position[1, 1] = 1;
                    }
                    i++;
                }
            }
            i = 0;
            //Add 6 point split between the players with the highest maki count and 3 to second if there was no tie for first
            foreach(Player p in players)
            {
                if (makiCount[i] == position[0, 0])
                {
                    scores[i] += 6 / position[0, 1];
                }
                else if (makiCount[i] == position[1, 0] && position[0, 1] == 1)
                {
                    scores[i] += 3 / position[1, 1];
                }
                i++;
            }

            return scores;
        }

        /// <summary>
        /// Calculates how much each player gets from their pudding
        /// </summary>
        /// <param name="scores"></param>
        /// <returns></returns>
        private int[] PuddingScore(int[] scores)
        {
            int[] puddingCount = new int[players.Count];
            int[] highestCount = new int[2];
            int[] lowestCount = new int[2];

            for (int i = 0; i < players.Count; i++)
            {
                foreach (Card c in players[i].InFront)
                {
                    //All cards left in front should be pudding but it is better to be safe
                    if (c is Pudding)
                    {
                        puddingCount[i]++;
                    }
                }
                //Find highest and lowest amounts of pudding and how many have that many
                if (i == 0)
                {
                    highestCount[0] = puddingCount[0];
                    highestCount[1] = 1;
                    lowestCount[0] = puddingCount[0];
                    lowestCount[1] = 1;
                }
                else
                {
                    if (highestCount[0] < puddingCount[i])
                    {
                        highestCount[0] = puddingCount[i];
                        highestCount[1] = 1;
                    }
                    else if (highestCount[0] == puddingCount[i])
                    {
                        highestCount[1]++;
                    }
                    //Has to be if not else if as first couple players could have the same lowest amount
                    if (lowestCount[0] > puddingCount[i])
                    {
                        lowestCount[0] = puddingCount[i];
                        lowestCount[1] = 1;
                    }
                    else if (lowestCount[0] == puddingCount[i])
                    {
                        lowestCount[1]++;
                    }
                }
            }
            //IF lowest count does not equal the highest count, hence every player will not have the same amount
            if (highestCount[0] != lowestCount[0])
            {
                //alter scores with those with lowest pudding losing their split of 6 
                //and those with the most their split of gaining 6 points
                for (int i = 0; i < players.Count; i++)
                {
                    if (scores[i] == highestCount[0])
                    {
                        scores[i] += 6 / highestCount[1];
                    }
                    else if (scores[i] == lowestCount[0])
                    {
                        scores[i] -= 6 / lowestCount[1];
                    }
                }
            }

            return scores;
        }
    }
}
