using Microsoft.Maui.Controls;

namespace MauiKurs230320.Navi;

//Attribut, welches definiert, dass bei Routing-Navigation ein String über den Identifikator 'RouteItem1'
//an die Property Item1 übergeben wird (vgl. RoutingBsp.xaml.cs)
[QueryProperty(nameof(Item1), "RouteItem1")]
public partial class RouteTargetPage : ContentPage
{
	public string Item1 { set => Lbl_Main.Text = value; }

	public RouteTargetPage()
	{
		InitializeComponent();
	}
}