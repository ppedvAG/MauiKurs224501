namespace MauiKurs230320;

public partial class Resources_Styles : ContentPage
{
	public Resources_Styles()
	{
		InitializeComponent();
	}

    private void Btn_ChangeColor_Clicked(object sender, EventArgs e)
    {
        //Codeseitiger Zugriff auf Ressource
        this.Resources["Primary"] = Colors.Red;
    }
}