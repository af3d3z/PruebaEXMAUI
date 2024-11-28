using PruebaEXMAUI.Models;

namespace PruebaEXMAUI.Views;

public partial class Detalles : ContentPage
{
	public Detalles(CandidatoConEdad cand)
	{
		InitializeComponent();
		this.BindingContext = cand;
	}

}