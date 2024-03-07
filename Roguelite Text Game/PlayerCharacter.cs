using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelite_Text_Game
{

    internal class PlayerCharacter
    {
        private int age;
        private string name;
        private Stage PlayerStage;
        private int progresstogoal;
        private int talent;
        private List<String> tags;
        private int lifespanbonus;
        public PlayerCharacter(Stage stage,int talent)
        {
            age = 0;
            name = "Johnny";
            PlayerStage = stage;
            lifespanbonus = 0;
            progresstogoal = 0;
            this.talent = talent;
            tags = new List<String>();
            tags.Add("test tag"); //testing tag, remove later
        }

        public int getAge()
        {
            return age;
        }
        //age the player character
        //returns true if alive or false if dead
        //TODO: get some formulas to age faster when older.
        public Boolean incrementAge()
        {
            if (age < PlayerStage.getLifespan() + lifespanbonus)
            {
                if (age < 25)
                    age++;
                else if (age < 50)
                    age = age + 5;
                else if (age < 150)
                    age = age + 25;
                else if (age < 500)
                    age = age + 50;

                progressProgression();
                return true; //return true cuz player still lives
            }
            else
                return false;//return false cuz player ded

        }

        public string getName()
        {
            return name;
        }

        public Stage getStage()
        {
            return PlayerStage;
        }

        //progress towards the goal for current stage.
        public int progressProgression()
        {
            progresstogoal = progresstogoal + talent;
            if (progresstogoal >= PlayerStage.getGoal())
            {
                PlayerStage = Stage.Stages[Stage.Stages.IndexOf(PlayerStage) + 1]; 
                progresstogoal = 0;
            }
            return progresstogoal;
        }

        public int getTalent()
        {
            return talent;
        }
        public int getProgessToGoal()
        {
            return progresstogoal;
        }

        public void addTag(String tag)
        {
            tags.Add(tag);
        }

        public void removeTag(String tag)
        {
            tags.Remove(tag);
        }

        public List<String> getTags()
        {
            return tags;
        }

        //this applies the effects of the event.
        public void applyEventEffects(RandomEvent revent)
        {
            //apply effects of event.
            talent = talent + revent.talenteffect;
            progresstogoal = progresstogoal + revent.goaleffect;
            lifespanbonus = lifespanbonus + revent.lifespaneffect;
            age = age + revent.ageeffect;
            foreach(string tag in revent.tagstoadd) // add each valid tag to the taglist
            {
                if(!tags.Contains(tag))
                    tags.Add(tag);
            }

        }
    }
}
