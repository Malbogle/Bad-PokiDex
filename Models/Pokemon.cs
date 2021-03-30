using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Pokemon
    {
        private Sprite _sprites;
        private List<Ability> _moves;
        public int Weight { get; set; }
        public int Height { get; set; }
        public Sprite Sprites
        {
            get
            {
                return _sprites;
            }
            set
            {
                if(_sprites != value)
                {
                    _sprites = value;
                    //OnPropertyChanged("Sprite");
                }
            }
        }
        public ObservableCollection<TypeContainer> Types { get; set; }
        public ObservableCollection<StatComplete> Stats { get; set; }
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

        public Pokemon()
        {
            Types = new ObservableCollection<TypeContainer>();
            Stats = new ObservableCollection<StatComplete>(); 
        }

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
