using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Ability
    {
        public AbilityName Move { get; set; }
        public List<MoveDetails> Version_group_details { get; set; }
    }
    public class AbilityName
    {
        public string Name { get; set; }
    }

    public class MoveDetails
    {
        public int Level_learned_at { get; set; }
        public LearnMethod Move_learn_method { get; set; }
    }

    public class LearnMethod
    {
        public string Name { get; set; }

    }

}
