using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private BindableBase _pokemonInfoViewModel = new PokemonViewModel();
        private BindableBase _pokemonAblilitiesViewModel = new AblitiesViewModel();
        private BindableBase _curViewModel;
        private bool _curPage = false;

        public bool CurPage
        {
            get
            {
                return _curPage;
            }
            set
            {
                SetProperty(ref _curPage, value);
            }
        }
        public CommandImpl NavToAbilities { get; set; }
        public MainViewModel()
        {
            NavToAbilities = new CommandImpl(OnNavRequest, CanNav);
        }

        private bool CanNav()
        {
            return ((PokemonViewModel)_pokemonInfoViewModel).CurPokemonDisplaying != null;
        }

        public BindableBase CurViewModel
        {
            get
            {
                if(_curViewModel == null)
                {
                    SetProperty(ref _curViewModel, _pokemonInfoViewModel);
                }
                return _curViewModel;
            }
            set
            {
                SetProperty(ref _curViewModel, value);
            }
        }

        public void OnNavRequest()
        {
            if (!CurPage)
            {
                ((AblitiesViewModel)_pokemonAblilitiesViewModel).CurPokemonDisplaying = ((PokemonViewModel)_pokemonInfoViewModel).CurPokemonDisplaying;
                CurViewModel = _pokemonAblilitiesViewModel;
                CurPage = true;
            }
            else
            { 
                CurViewModel = _pokemonInfoViewModel;
                CurPage = false;
            }

        }
    }
}
