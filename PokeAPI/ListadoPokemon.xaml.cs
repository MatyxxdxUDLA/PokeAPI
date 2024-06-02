using Newtonsoft.Json;
using PokeAPI.Models;
using PokeAPI.Servicios;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace PokeAPI;

public partial class ListadoPokemon : ContentPage
{
	public List<PokemonInfo> listadoPokemones;
	public ListadoPokemon()
	{
        InitializeComponent();
		LoadData();
    }

	public async void LoadData()
	{
		PokemonAPIs _poke_apis = new PokemonAPIs();
        listadoPokemones = await _poke_apis.DevuelveListadoPokemones();
		PokemonList.ItemsSource = listadoPokemones;
    }
    public void MuestraResumenPokemon(object sender, SelectedItemChangedEventArgs e)
    {
		PokemonInfo poke_info = (PokemonInfo)e.SelectedItem;
		Navigation.PushAsync(new ResumenPokemon(poke_info.Url));
    }

}