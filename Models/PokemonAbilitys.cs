using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class PokemonAbilitys
    {
        private List<Ability> _moves;
        public List<Ability> Moves
        {
            get
            {
                return _moves;
            }
            set
            {
                _moves = value;
                //Construct observable collections after getting moves data
                GetLevelUpAbilities();
                GetOtherAbilities();
            }
        }
        public ObservableCollection<Ability> LvlUpAbilities { get; set; }
        public ObservableCollection<Ability> OtherAbilities { get; set; }
        public void GetLevelUpAbilities()
        {
            var newList = new List<Ability>(Moves);
            var tempList = newList.Where(ability => ability.Version_group_details[0].Move_learn_method.Name.Equals("level-up")).ToList();
            LvlUpAbilities = new ObservableCollection<Ability>(tempList);
        }

        public void GetOtherAbilities()
        {
            var newList = new List<Ability>(Moves);
            var tempList = newList.Where(ability => !ability.Version_group_details[0].Move_learn_method.Name.Equals("level-up")).ToList();
            OtherAbilities = new ObservableCollection<Ability>(tempList);
        }

    }
}
