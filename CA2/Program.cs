using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2_Thiago_Braz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //objects to gather teams info 3 times
            Team team1 = GetTeamInfo();
            Team team2 = GetTeamInfo();
            Team team3 = GetTeamInfo();

            Console.Clear();

            //display table
            DisplayTable(team1, team2, team3);

            


        }

        public static Team GetTeamInfo()
        {
            Console.WriteLine("Enter Team Name >> ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter number of Wins >> ");
            int won = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of Draws >> ");
            int draw = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of Losses >> ");
            int lost = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Goals Scored >> ");
            int goalsFor = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Goals Conceded >> ");
            int goalsAgainst = int.Parse(Console.ReadLine());

            return new Team (name, won, draw, lost, goalsFor, goalsAgainst);

        }

        public static void DisplayTable(Team team1, Team team2, Team team3) 
        {
           List<Team> teamList = new List<Team>();

            teamList.Add(team1);
            teamList.Add(team2);
            teamList.Add(team3);

            teamList.Sort();



        }


/*
        public static void DisplayTable(Team team1, Team team2, Team team3)

        {
            //formatting
            Console.WriteLine("{0,-20}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}{7,10}", "Team", "Played", "Won", "Drawn", "Lost", "Goals For", "Goals Against", "Points");

            Team temp;
            if (team1.GetPoints() < team2.GetPoints())
            {
                temp = team1;
                team1 = team2;
                team2 = temp;
            }

            if (team2.GetPoints() < team3.GetPoints())
            {
                temp = team2;
                team2 = team3;
                team3 = temp;
            }
            if (team1.GetPoints() < team2.GetPoints())
            {
                temp = team1;
                team1 = team2;
                team2 = temp;
            }

            Console.WriteLine(team1);
            Console.WriteLine(team2);
            Console.WriteLine(team3);
        }
        */

        public static Team GetWinner(Team team1, Team team2, Team team3)
        {
            Team winner = team1;

            if(team2.GetPoints() > winner.GetPoints())
                winner = team2;

            if(team3.GetPoints() > winner.GetPoints())
                winner = team3;

            return winner;
        }

        public static Team GetLoser(Team team1, Team team2, Team team3)
        {
            Team loser = team1;

            if (team2.GetPoints() > loser.GetPoints())
                loser = team2;

            if (team3.GetPoints() > loser.GetPoints())
                loser = team3;

            return loser;
        }

    }
}
