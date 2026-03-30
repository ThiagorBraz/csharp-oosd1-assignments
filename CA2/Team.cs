using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2_Thiago_Braz
{
    internal class Team
    {
        //properties
        public string Name { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int Draw {  get; set; }
        public int Lost { get; set; }
        public int GoalFor { get; set; }
        public int GoalsAgainst { get; set; }

        //contructors
        public Team(string name, int won, int draw, int lost, int goalFor, int goalsAgainst)
        {
            Name = name;
            Played = won + draw + lost;
            Won = won;
            Draw = draw;
            Lost = lost;
            GoalFor = goalFor;
            GoalsAgainst = goalsAgainst;
        }

        //methods

        // to calculate points
        public int GetPoints()
        {
            int points = 0;

            if (Won > 0)
            {
                points += Won * 3;
            }

            if (Draw > 0)
            {
                points += Draw * 1;
            }
            return points;
        }

        // to calculate Goals Diferrence

        public int GetGoalDifference()
        {
            int goalDifference = GoalFor - GoalsAgainst;

            return goalDifference;
        }
        // table format to be displayed
        public override string ToString()
        {
            string formatter = "{0,-20}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}{7,10}{8,10}";

            string output = string.Format(formatter, Name, Played, Won, Draw, Lost, GoalFor, GoalsAgainst, GetGoalDifference(), GetPoints());

            return output;
        }
    }
}
