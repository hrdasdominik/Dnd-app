using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnd.Models
{
    public class CharacterSheet
    {
        public class Root
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Class { get; set; }
            public int Level { get; set; }
            public string Background { get; set; }
            public string Race { get; set; }
            public string Alignment { get; set; }
            public int Exp { get; set; }
            public int Inspiration { get; set; }
            public int ArmorClass { get; set; }
            public int Initiative { get; set; }
            public int Speed { get; set; }
            public int HitPoints { get; set; }
            public int HitPointsMax { get; set; }
            public string HitDice { get; set; }
            public string HitDiceMax { get; set; }
            public int ProficiencyBonus { get; set; }
            public int PassivePerception { get; set; }
            [ForeignKey("Id")]
            public AbilityScores abilityScores { get; set; }
            [ForeignKey("Id")]
            public AbilityModifiers abilityModifiers { get; set; }
            [ForeignKey("Id")]
            public SavingThrows savingThrows { get; set; }
            [ForeignKey("Id")]
            public Skills skills { get; set; }

            public string PersonalityTraits { get; set; }
            public string Ideals { get; set; }
            public string Bonds { get; set; }
            public string Flaws { get; set; }
        }

        public class AbilityScores
        {
            [Key]
            public int Id { get; set; }
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
        }

        public class AbilityModifiers
        {
            [Key]
            public int Id { get; set; }
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
        }

        public class SavingThrows
        {
            [Key]
            public int Id { get; set; }
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
        }

        public class Skills
        {
            [Key]
            public int Id { get; set; }
            public int Acrobatics { get; set; }
            public int AnimalHandling { get; set; }
            public int Arcana { get; set; }
            public int Athletics { get; set; }
            public int Deception { get; set; }
            public int History { get; set; }
            public int Insight { get; set; }
            public int Intimidation { get; set; }
            public int Investigation { get; set; }
            public int Medicine { get; set; }
            public int Nature { get; set; }
            public int Perception { get; set; }
            public int Performance { get; set; }
            public int Persuasion { get; set; }
            public int Religion { get; set; }
            public int SleightOfHand { get; set; }
            public int Stealth { get; set; }
            public int Survival { get; set; }
        }
    }
}
