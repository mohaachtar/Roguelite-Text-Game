using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Roguelite_Text_Game
{
    public partial class GameForm : Form
    {
        PlayerCharacter PC; // the player character.
        Random roller; // the Random for the dice rolls.
        //initialize the game from here.
        public GameForm()
        {
            InitializeComponent();
            LoadModule("Xianxia"); //Load the selected module
            PC = new PlayerCharacter(Stage.Stages[0], 1); //Create a player character

                PC.addTag("test tag"); // this is here just for testing, remove later

            roller = new Random(); // initialize a Random object for dice rolls
            MainTextBox.Text = "You are born!, your name is " + PC.getName() + ", You are a peasant peasanting!";

        }

        // Process the next turn, ideally this should only call multiple methods to do everything needed.
        // 
        private void NextTurnButton_Click(object sender, EventArgs e)
        {
            if (PC.incrementAge())
            {
                //Progress towards the goal
                MainTextBox.Text = MainTextBox.Text + "\n";
                MainTextBox.Text = MainTextBox.Text + "You are now " + PC.getAge().ToString() + " years old!\n";
                MainTextBox.Text = MainTextBox.Text + "You have progressed " + PC.getProgessToGoal().ToString() + " towards finishing "
                    + PC.getStage().getName() + "!";
                MainTextBox.Text = MainTextBox.Text + "\n------------";
                //Roll for random event
                int roll = roller.Next(100) + 1;
                RandomEvent revent = RandomEvent.throwEvent(roll, PC);
                //show event text now!
                MainTextBox.Text = MainTextBox.Text + revent.getDisplayString();
                //apply effects of the random event!
                PC.applyEventEffects(revent);
                Console.WriteLine(roll);
            }
            else
            {
                MainTextBox.Text = MainTextBox.Text + "\n" + "You died from old age!";
            }
        }

        //Load the Module, ideally this should only call multiple methods to do everything needed.
        private void LoadModule(String modulename)
        {
            String stagesfilename = modulename + "Stages.txt";
            String eventsfilename = modulename + "Events.txt";
            loadStages(stagesfilename);
            loadEvents(eventsfilename);
            
        }

        // load the stages from the text file into an array of stages.
        // The text file has the following format:
        //-|-
        //stage name
        //lifespan in years
        //goal for advancing
        // the -|- there is for separating stages and working easier
        // TODO: make tool for creating and editing stages.
        private void loadStages(String stagesfilename)
        {
            StreamReader streamReader= new StreamReader(stagesfilename);
            String line = "assinged"; // otherwise this is gonna throw a bitchfit cuz y no assign?
            String name;
            int lifespan;
            int goal;
            while (line != null)
            {
                line = streamReader.ReadLine(); // skip the -|-
                line = streamReader.ReadLine();
                name = line;
                line = streamReader.ReadLine();
                lifespan = Convert.ToInt32(line);
                line = streamReader.ReadLine();
                goal = Convert.ToInt32(line);
                Stage stage = new Stage(name,lifespan,goal);
                Stage.Stages.Add(stage);
            }
        }

        //Load the events from the events file into the events list.
        private void loadEvents(String eventsfilename)
        {
            StreamReader streamReader = new StreamReader(eventsfilename);

            string Title = streamReader.ReadLine();
            string Description = streamReader.ReadLine();
            int talenteffect = Convert.ToInt32(streamReader.ReadLine());
            int goaleffect = Convert.ToInt32(streamReader.ReadLine());
            int ageeffect = Convert.ToInt32(streamReader.ReadLine());
            int lifespaneffect = Convert.ToInt32(streamReader.ReadLine());
            int maxroll = Convert.ToInt32(streamReader.ReadLine());
            int minroll = Convert.ToInt32(streamReader.ReadLine());
            List<String> stagenames = streamReader.ReadLine().Split(',').ToList();
            List<String> tags = streamReader.ReadLine().Split(',').ToList();
            List<String> tagstoadd = streamReader.ReadLine().Split(',').ToList();
            RandomEvent.RandomEvents.Add(new RandomEvent(Title, Description, talenteffect, goaleffect, ageeffect,
                lifespaneffect, maxroll, minroll, stagenames, tags,tagstoadd));

    }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            MainTextBox.SelectionStart = MainTextBox.Text.Length;
            MainTextBox.ScrollToCaret();
        }
    }
}
