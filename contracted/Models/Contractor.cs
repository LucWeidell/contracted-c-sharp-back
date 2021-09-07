using System.ComponentModel.DataAnnotations;

namespace contracted.Models
{
    public class Contractor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        public bool? IsMale { get; set; }
        public string SkillSet { get; set; }

    public Contractor(string name, int age, bool? isMale, string skillSet)
    {
      Name = name;
      Age = age;
      IsMale = isMale;
      SkillSet = skillSet;
    }

    }
}