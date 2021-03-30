using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Pokedex.Models;
using Pokedex.Services;

namespace Pokedex.ViewModels
{
    class PokemonViewModel : BindableBase
    {
        private Pokemon _curDisplayingPokemon;
        private string _pokemonSearchName;
        private bool _displayingElements;
        private bool _onValidSearch;

        public bool OnValidSearch
        {
            get
            {
                return _onValidSearch;
            }
            set
            {
                SetProperty(ref _onValidSearch, value);
                
            }
        }
        public bool DisplayElements 
        {
            get
            {
                return _displayingElements;
            }
            set
            {
                SetProperty(ref _displayingElements, value);
            }
                 
        }
   
        public CommandImpl SearchCommand { get; set; }
        public CommandImpl NavToAbilitiesViewCommand { get; set; }
        public CommandImpl NavToHomeCommand { get; set; }

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
        public string PokemonSearchName {
            get
            {
                return _pokemonSearchName;
            }
            set
            {
                if (!String.IsNullOrEmpty(_pokemonSearchName))
                {
                    if (_pokemonSearchName != value)
                    {
                        _pokemonSearchName = value;
                        SearchCommand.RaiseCanExecuteChanged();
                    }
                }
                else
                {
                    _pokemonSearchName = value;
                }
            } 
        
        }
        public PokemonViewModel()
        {
            SearchCommand = new CommandImpl(OnSearch, CanSearch);
            DisplayElements = false;
            OnValidSearch = true;
        }


        private bool CanSearch()
        {
            return !String.IsNullOrEmpty(PokemonSearchName);   
        }

        private async void OnSearch()
        {
            if (!ApiHelper.HasInitialized)
            {
                ApiHelper.InitClient();
            }
            try
            {
                CurPokemonDisplaying = await PokemonProcessor.LoadPokemonInfo(PokemonSearchName);
                DisplayElements = true;
                OnValidSearch = true;
            }
            catch(Exception ex)
            {
                OnValidSearch = false;
            }
        }

    }
}
