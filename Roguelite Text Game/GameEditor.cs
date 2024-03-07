using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelite_Text_Game
{
    public partial class GameEditor : Form
    {
        private List<List<String>> events; // a list of lists where we gonna store the events, each entry will represent the data from an event
        private List<List<String>> stages; // a list of lsits where we gonna store the stages, each entru will represent the data from a stage
        // the data is stored in the following order:
        /* Title
         * Description
         * Effect on talent
         * Effect on progress to goal
         * Effect on age
         * Effect on lifespan
         * maxroll to trigger event
         * minimum roll to trigger event
         * name of stages the event will fire for
         * tags the event will fire for
         * tags the event will add to the player
        */
        public GameEditor()
        {
            InitializeComponent();
            events = new List<List<String>>();
            stages = new List<List<String>>();
        }

        // when this button gets clicked it will load the events.
        private void EventSelectButton_Click(object sender, EventArgs e)
        {
            //set initial opening folder and show the dialog to select events file.
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory; 
            openFileDialog1.ShowDialog();
            //Read all the events in the events file.
            StreamReader reader = new StreamReader(openFileDialog1.FileName);
            for(int i=0; !reader.EndOfStream;i++)
            {
                events.Add(new List<String>());
                for (int j = 0; j < 11; j++)
                    events[i].Add(reader.ReadLine());
            }
            
            //add the events to the listbox.
            foreach(List<string> list in events)
            {
                EventListBox.Items.Add(list[0]);
            }
        }

        //Whenever another item is select in the listbox, change the textboxes to the appropriate events.
        private void EventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ugly solution to fix dumb exception, TODO:find better way sometime
            try
            {
                TitleTextBox.Text = events[EventListBox.SelectedIndex][0];
                EventDescriptionTextBox.Text = events[EventListBox.SelectedIndex][1];
                TalentEffectTextBox.Text = events[EventListBox.SelectedIndex][2];
                ProgressEffectTextBox.Text = events[EventListBox.SelectedIndex][3];
                AgeEffectTextBox.Text = events[EventListBox.SelectedIndex][4];
                LifespanEffectTextBox.Text = events[EventListBox.SelectedIndex][5];
                MaxRollTextBox.Text = events[EventListBox.SelectedIndex][6];
                MinRollTextBox.Text = events[EventListBox.SelectedIndex][7];
                ValidStagesTextBox.Text = events[EventListBox.SelectedIndex][8];
                ValidTagsTextBox.Text = events[EventListBox.SelectedIndex][9];
                TagsToAddTextBox.Text = events[EventListBox.SelectedIndex][10];
            }
            catch
            {

            }
        }

        private void SaveEventFileButton_Click(object sender, EventArgs e)
        {
            //select a file, write whats needed then save there.
            saveFileDialog1.ShowDialog();
            StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
            foreach(List<String> list in events)
            {
                foreach(String s in list)
                {
                    streamWriter.WriteLine(s);
                    Console.WriteLine(s);
                }
            }
            streamWriter.Close();
        }
        //this adds a RandomEvent to the events list.
        private void addEvent(RandomEvent revent)
        {
            //add the revent as the last element,for this we gotta convert it to strings.
            events.Add(new List<String>());
            events[events.Count - 1].Add(revent.Title);
            events[events.Count - 1].Add(revent.Description);
            events[events.Count - 1].Add(Convert.ToString(revent.talenteffect));
            events[events.Count - 1].Add(Convert.ToString(revent.goaleffect));
            events[events.Count - 1].Add(Convert.ToString(revent.ageeffect));
            events[events.Count - 1].Add(Convert.ToString(revent.lifespaneffect));
            events[events.Count - 1].Add(Convert.ToString(revent.maxroll));
            events[events.Count - 1].Add(Convert.ToString(revent.minroll));
            events[events.Count - 1].Add("");
            events[events.Count - 1].Add("");
            events[events.Count - 1].Add("");
            foreach (String s in revent.stagenames)
                events[events.Count - 1][8] = events[events.Count][8] + s;
            foreach (String s in revent.tags)
                events[events.Count - 1][9] = events[events.Count - 1][9] + s;
            foreach (String s in revent.tagstoadd)
                events[events.Count - 1][10]= events[events.Count - 1][10] + s;
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            //add in a random event to the list, clear the listbox then read all the events.
            EventListBox.Items.Clear();
            addEvent(new RandomEvent());
            //add the events to the listbox.
            foreach (List<string> list in events)
            {
                EventListBox.Items.Add(list[0]);
            }
        }

        //theese are the methods to save changes done in the textboxes to the events list, this is gonna look ugly so brace yourself :)

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][0] = TitleTextBox.Text;
            EventListBox.Items[EventListBox.SelectedIndex] = TitleTextBox.Text;
        }

        private void TalentEffectTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][2] = TalentEffectTextBox.Text;
        }

        private void ProgressEffectTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][3] = ProgressEffectTextBox.Text;
        }

        private void AgeEffectTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][4] = AgeEffectTextBox.Text;
        }

        private void LifespanEffectTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][5] = LifespanEffectTextBox.Text;
        }

        private void MaxRollTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][6] = MaxRollTextBox.Text;
        }

        private void MinRollTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][7] = MinRollTextBox.Text;
        }

        private void ValidStagesTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][8] = ValidStagesTextBox.Text;
        }

        private void ValidTagsTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][9] = ValidTagsTextBox.Text;
        }

        private void TagsToAddTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][10] = TagsToAddTextBox.Text;
        }

        private void EventDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            events[EventListBox.SelectedIndex][1] = EventDescriptionTextBox.Text;
        }

        //remove the selected item from the listbox
        private void RemoveEventButton_Click(object sender, EventArgs e)
        {
            try //there probably is a better way to avoid dumb exceptions... oh well.
            {
                int index = EventListBox.SelectedIndex;//get the index we need to remove
                EventListBox.Items.RemoveAt(index);// remove it from the eventlistbox
                events.Remove(events[index]);// remove it from the events array
                EventListBox.Items.Clear();// clear the eventlistbox
                //add the events to the listbox.
                foreach (List<string> list in events)
                {
                    EventListBox.Items.Add(list[0]);
                }
            }
            catch
            {

            }
        }

        //select a stage file,load it into the stages array and change the Stagelistbox
        private void StageFileSelectButton_Click(object sender, EventArgs e)
        {
            //set initial opening folder and show the dialog to select stages file.
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.ShowDialog();
            //Read all the events in the stages file.
            StreamReader reader = new StreamReader(openFileDialog1.FileName);
            for (int i = 0; !reader.EndOfStream; i++)
            {
                stages.Add(new List<String>());
                reader.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    stages[i].Add(reader.ReadLine());
                }
            }

            //add the stages to the listbox.
            foreach (List<string> list in stages)
            {
                StagesListBox.Items.Add(list[0]);
            }
        }

        //these will change the data in the stages list when the textbox text changes.
        private void StageNameTextBox_TextChanged(object sender, EventArgs e)
        {
            stages[StagesListBox.SelectedIndex][0] = StageNameTextBox.Text;
            StagesListBox.Items[StagesListBox.SelectedIndex] = StageNameTextBox.Text;
        }

        private void LifeSpanTextBox_TextChanged(object sender, EventArgs e)
        {
            stages[StagesListBox.SelectedIndex][1] = LifeSpanTextBox.Text;
        }

        private void GoalTextBox_TextChanged(object sender, EventArgs e)
        {
            stages[StagesListBox.SelectedIndex][2] = GoalTextBox.Text;
        }
        //change textboxes depending on changes to listbox selection
        private void StagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try // do this to avoid dumb exceptions, TODO: catch specific ones i need
            {
                StageNameTextBox.Text = stages[StagesListBox.SelectedIndex][0];
                Console.WriteLine(stages[StagesListBox.SelectedIndex][1]);
                LifeSpanTextBox.Text = stages[StagesListBox.SelectedIndex][1];
                GoalTextBox.Text = stages[StagesListBox.SelectedIndex][2];
            }
            catch
            {

            }
        }

        //Save the stages into a file.
        private void SaveStageFileButton_Click(object sender, EventArgs e)
        {
            //select a file, write whats needed then save there.
            saveFileDialog1.ShowDialog();
            StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
            foreach (List<String> list in stages)
            {
                streamWriter.WriteLine("-|-");
                foreach (String s in list)
                {
                    streamWriter.WriteLine(s);
                }
            }
            streamWriter.Close();
        }

        //add a new stage to the list and listbox
        private void AddStageButton_Click(object sender, EventArgs e)
        {
            //add in a stage to the list, clear the listbox then read all the events.
            StagesListBox.Items.Clear();
            addStage(new Stage("New Stage",0,0));
            //add the stages to the listbox.
            foreach (List<string> list in stages)
            {
                StagesListBox.Items.Add(list[0]);
            }
        }

        //this adds a stage.
        private void addStage(Stage stage)
        {
            //add a stage to the list
            stages.Add(new List<String>());
            //populate the stage with data.
            stages[stages.Count - 1].Add(stage.getName());
            stages[stages.Count - 1].Add(Convert.ToString(stage.getLifespan()));
            stages[stages.Count - 1].Add(Convert.ToString(stage.getGoal()));
        }

        //remove the selected item from the listbox
        private void RemoveStageButton_Click(object sender, EventArgs e)
        {
            try //there probably is a better way to avoid dumb exceptions... oh well.
            {
                int index = StagesListBox.SelectedIndex;//get the index we need to remove
                StagesListBox.Items.RemoveAt(index);// remove it from the StageListBox
                stages.Remove(events[index]);// remove it from the stages array
                StagesListBox.Items.Clear();// clear the StageListBox
                //add the stages to the listbox.
                foreach (List<string> list in events)
                {
                    StagesListBox.Items.Add(list[0]);
                }
            }
            catch
            {

            }
        }

        /*
         * This will move the stage up or down on the list,
         * This also makes it be either an earlier or later stage.
         */
        private void StageUpButton_Click(object sender, EventArgs e)
        {
            //get the index we gotta swap with the one above it.
            int indexselected = StagesListBox.SelectedIndex;
            if (indexselected != 0)//if its already the first stage then do nothing
            {
                //swap the two between eachother.
                List<String> Selected = stages[indexselected];
                stages[indexselected] = stages[indexselected - 1];
                stages[indexselected - 1] = Selected;
                //Update the entries for the listbox
                StagesListBox.Items[indexselected] = stages[indexselected][0];
                StagesListBox.Items[indexselected - 1] = stages[indexselected - 1][0];
                StagesListBox.SelectedIndex = indexselected - 1;//change the selected index for good feelings
            }
        }

        private void StageDownButton_Click(object sender, EventArgs e)
        {
            //get the index we gotta swap with the one under it.
            int indexselected = StagesListBox.SelectedIndex;
            if (indexselected != StagesListBox.Items.Count-1)//if its already the last stage then do nothing
            {
                //swap the two between eachother.
                List<String> Selected = stages[indexselected];
                stages[indexselected] = stages[indexselected + 1];
                stages[indexselected + 1] = Selected;
                //Update the entries for the listbox
                StagesListBox.Items[indexselected] = stages[indexselected][0];
                StagesListBox.Items[indexselected + 1] = stages[indexselected + 1][0];
                StagesListBox.SelectedIndex = indexselected + 1;//change the selected index for good feelings
            }
        }
    }
}
