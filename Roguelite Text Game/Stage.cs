using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelite_Text_Game
{
    internal class Stage
    {
        static public List<Stage> Stages = new List<Stage>(); // the stages currently in the game
        private String name;
        private int lifespan;
        private int goal;
        public Stage(string name,int lifespan,int goal)
        {
            this.name = name;
            this.lifespan = lifespan;
            this.goal = goal;
        }

        public String getName()
        {
            return name; 
        }
        public int getLifespan()
        {
            return lifespan;
        }
        public int getGoal()
        {
            return goal;
        }
    }
}
