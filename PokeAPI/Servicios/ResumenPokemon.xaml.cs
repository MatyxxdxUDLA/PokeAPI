using PokeAPI.Models;

namespace PokeAPI.Servicios;

public partial class ResumenPokemon : ContentPage
{
	CaracterisitcasPokemon caracteristicas = new CaracterisitcasPokemon();
	public ResumenPokemon(string url)
	{
		InitializeComponent();
		CargaPokemon(url);

	}
	public async void CargaPokemon(string url)
	{
		PokemonAPIs poke_services = new PokemonAPIs();
		caracteristicas = await poke_services.DevuelveCaracteristicasPokemon(url);
		ImagePokemon.Source = caracteristicas.Sprites.front_default;

		string hablidades = "";
		foreach (var ability in caracteristicas.abilities)
		{
			hablidades += ability.ability.name + " | ";
		}
		Habilidades.Text = hablidades;
	}
}