namespace MauiKurs230320.Navi;

public partial class RoutingBsp : ContentPage
{
	public RoutingBsp()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Mittels des GoToAsync-Befehls k�nnen in der Shell angemeldete Routen angesteuert werden
        Shell.Current.GoToAsync("//grundlagen/layouts");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        //Wenn die Ziel-Page es erlaubt (vgl. RouteTargetPage.xaml.cs) k�nnen Objekte �bertragen werden
        Shell.Current.GoToAsync($"navi/routeTarget?RouteItem1={Ent_Input.Text}");
    }
}