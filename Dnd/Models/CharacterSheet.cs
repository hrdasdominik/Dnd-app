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
            public Root()
            {
                AbilityScores = new HashSet<AbilityScore>();
            }

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
            public ICollection<AbilityScore> AbilityScores { get; set; }
            public int PassivePerception { get; set; }
            public string PersonalityTraits { get; set; }
            public string Ideals { get; set; }
            public string Bonds { get; set; }
            public string Flaws { get; set; }
        }

        public class AbilityScore
        {
            [Key]
            public int Id { get; set; }
            [ForeignKey("Id")]
            public int IdChar { get; set; }
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
        }

        public class AbilityMod
        {
            public int ModStrength { get; set; }
            public int ModDexterity { get; set; }
            public int ModConstitution { get; set; }
            public int ModIntelligence { get; set; }
            public int ModWisdom { get; set; }
            public int ModCharisma { get; set; }
        }

        public class SavingThrow
        {
            public int SavingStrength { get; set; }
            public int SavingDexterity { get; set; }
            public int SavingConstitution { get; set; }
            public int SavingIntelligence { get; set; }
            public int SavingWisdom { get; set; }
            public int SavingCharisma { get; set; }
        }

        [Keyless]
        public class Skill
        {
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
