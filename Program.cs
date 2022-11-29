using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamMember person1 = new TeamMember();
            Console.WriteLine("Plan Your Heist B)");
            Console.WriteLine("Enter team member's name");
            person1.Name = Console.ReadLine();
            Console.WriteLine("Enter team member's Skill Level between 1-10: ");
            person1.SkillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter team member's courage factor between 0.0-2.0: ");
            person1.CourageFactor = decimal.Parse(Console.ReadLine());
            Console.WriteLine(person1.Stringify());
        }
    }
}
