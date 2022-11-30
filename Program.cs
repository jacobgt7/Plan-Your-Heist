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

            Console.WriteLine("Enter difficulty level for the bank 1-100: ");
            int bankDifficultyLevel = int.Parse(Console.ReadLine());

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

            Console.WriteLine("How many attemps would you like?");
            int numberOfAttempts = int.Parse(Console.ReadLine());

            int successfulAttempts = 0;
            int failedAttempts = 0;

            for (int i = 0; i < numberOfAttempts; i++)
            {


                int luckValue = new Random().Next(-10, 11);

                int modifiedDifficultyLevel = bankDifficultyLevel + luckValue;

                int teamSkill = 0;
                foreach (TeamMember teamMember in teamMembers)
                {
                    teamSkill += teamMember.SkillLevel;
                }

                if (teamSkill >= modifiedDifficultyLevel)
                {
                    successfulAttempts++;
                }
                else
                {
                    failedAttempts++;
                }

                Console.WriteLine($"Team Skill Level: {teamSkill}. Bank's Difficulty Level: {modifiedDifficultyLevel}.");

                Console.WriteLine((teamSkill > modifiedDifficultyLevel) ? "You succesfully robbed the bank!" : "You failed and now you're in prison.");
            }

            Console.WriteLine($"The team was successful {successfulAttempts} times");
            Console.WriteLine($"The team failed {failedAttempts} times");
        }
    }
}
