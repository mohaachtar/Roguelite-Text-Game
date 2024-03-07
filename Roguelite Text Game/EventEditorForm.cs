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
    public partial class EventEditorForm : Form
    {
        private List<List<String>> events; // a list of lists where we gonna store the events, each entry will represent the data from an event
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
        public EventEditorForm()
        {
            InitializeComponent();
            events = new List<List<String>>(); 
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
    }
}
