using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class PokemonInfo
    {
        private Sprite _sprites;
        public Sprite Sprites
        {
            get
            {
                return _sprites;
            }
            set
            {
                if (_sprites != value)
                {
                    _sprites = value;
                }
            }
        }
        public ObservableCollection<TypeContainer> Types { get; set; }
        public ObservableCollection<StatComplete> Stats { get; set; }

    }
}
