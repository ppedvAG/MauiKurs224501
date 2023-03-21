namespace MauiKurs230320;

public partial class Layouts : ContentPage
{
	public Layouts()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Zugriff auf AttachedProperty
        Grid.SetColumn(Btn_Move, 1);
    }
}