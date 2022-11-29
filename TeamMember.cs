using System;

namespace PlanYourHeist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }


        public string Stringify()
        {
            return ($"Name: {Name} Skill Level: {SkillLevel} Courage Factor: {CourageFactor}");
        }
    }
}