using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelite_Text_Game
{
    internal class RandomEvent
    {
        static public List<RandomEvent> RandomEvents = new List<RandomEvent>();
        public readonly string Title;
        public readonly string Description;
        public readonly int talenteffect;
        public readonly int goaleffect;
        public readonly int ageeffect;
        public readonly int lifespaneffect;
        public readonly int maxroll;
        public readonly int minroll;
        public readonly List<String> stagenames;
        public readonly List<String> tags;
        public readonly List<String> tagstoadd;
        //this creates a custom random event and asks for and fills in all the details needed for it
        public RandomEvent(String Title,String Description, int talenteffect, int goaleffect, int ageeffect, int lifespaneffect,
            int maxroll, int minroll, List<String> stagenames, List<string> tags, List<string> tagstoadd)
        {
            this.Title = Title;
            this.Description = Description;
            this.talenteffect = talenteffect;
            this.goaleffect = goaleffect;
            this.ageeffect = ageeffect;
            this.lifespaneffect = lifespaneffect;
            this.maxroll = maxroll;
            this.minroll = minroll;
            this.stagenames = stagenames;
            this.tags = tags;
            this.tagstoadd = tagstoadd;
        }

        //this creates a generic random event that is empty
        public RandomEvent()
        {
            this.Title = "Title";
            this.Description = "Description";
            this.talenteffect = 0;
            this.goaleffect = 0;
            this.ageeffect = 0;
            this.lifespaneffect = 0;
            this.maxroll = 0;
            this.minroll = 0;
            this.stagenames = new List<String>();
            this.tags = new List<String>();
            this.tagstoadd = new List<String>();
        }

        //return a random event depending on PC and roll
        static public RandomEvent throwEvent(int roll,PlayerCharacter PC)
        {
            //check each event wether or not it qualifies, if it does add it to the list, if it does not then dont(duh)
            List<RandomEvent> eventlist= new List<RandomEvent>();
            foreach(RandomEvent randomevent in RandomEvents)
            {
                //first we check the roll
                if (!(randomevent.minroll < roll && roll < randomevent.maxroll)) // if it is not in the range, then break
                    break;
                if (!randomevent.stagenames.Contains(PC.getStage().getName())) // if the stage is not applicable, then break
                    break;
                Boolean hastag = false;
                // there probably is a better way of checking wether the tag is good, but this is what we got for now
                foreach (String tag in PC.getTags())
                {
                    if(randomevent.tags.Contains(tag))
                    {
                        hastag = true;
                        break;
                    }
                }
                if (!hastag) // if it does not have the tag, then break
                    break;
                eventlist.Add(randomevent); //if everything is ok, we add the random event to the list.
            }
            //return a random valid event, if none is applicable then return a nothing happened event that effects nothing.
            if(eventlist.Count<1)
            {
                return new RandomEvent("Nothing", "Nothing happened", 0, 0, 0, 0, 0, 0, new List<String>(), new List<String>(),new List<String>());
            }
            else
            {
                //there probably is a better way to implement this, oh well
                Random rand = new Random();
                return eventlist[rand.Next(eventlist.Count-1)];
            }
        }

        //returns the string that the event is supposed to display
        public String getDisplayString()
        {
            String displaytext = "\n" + Title + "\n" + Description+ "\n";
            return displaytext;
        }
    }
}
