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
            while(true)
            {           
                TeamMember person1 = new TeamMember();
                Console.WriteLine("Enter team member's name");
                person1.Name = Console.ReadLine();
                if (person1.Name == "")
                {
                    break;
                }
                Console.WriteLine("Enter team member's Skill Level between 1-10: ");
                person1.SkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter team member's courage factor between 0.0-2.0: ");
                person1.CourageFactor = decimal.Parse(Console.ReadLine());
                teamMembers.Add(person1);                 
            };
            Console.WriteLine($"{teamMembers.Count} team members in team.");
            foreach (TeamMember teamMember in teamMembers)
            {
                Console.WriteLine($"{teamMember.Stringify()}");
            }
        }
    }
}
