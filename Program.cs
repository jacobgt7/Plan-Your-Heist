using System;
using System.Collections.Generic;
namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> teamMembers = new List<TeamMember>();
            Console.WriteLine("Plan Your Heist B)");
            while (true)
            {
                TeamMember person1 = new TeamMember();

                Console.WriteLine("Enter team member's name");
                person1.Name = Console.ReadLine();
                if (person1.Name == "")
                {
                    break;
                }
                Console.WriteLine("Enter team member's Skill Level");
                person1.SkillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter team member's courage factor between 0.0-2.0: ");
                person1.CourageFactor = decimal.Parse(Console.ReadLine());

                teamMembers.Add(person1);
            };
            Console.WriteLine($"{teamMembers.Count} team members in team.");

            int bankDifficultyLevel = 100;

            int teamSkill = 0;
            foreach (TeamMember teamMember in teamMembers)
            {
                teamSkill += teamMember.SkillLevel;
            }

            Console.WriteLine((teamSkill > bankDifficultyLevel) ? "You succesfully robbed the bank!" : "You failed and now you're in prison.");
        }
    }
}
