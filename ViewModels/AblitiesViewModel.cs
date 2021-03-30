using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex.Models;

namespace Pokedex.ViewModels
{
    public class AblitiesViewModel : BindableBase
    {
        private Pokemon _curDisplayingPokemon;
        public Pokemon CurPokemonDisplaying
        {
            get
            {
                return _curDisplayingPokemon;
            }
            set
            {
                SetProperty(ref _curDisplayingPokemon, value);
            }
        }
    }
}
