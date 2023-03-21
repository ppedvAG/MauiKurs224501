namespace MauiKurs230320;

public partial class Layouts : ContentPage
{
	public Layouts()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Grid.SetRow(Lbl_Gelb, 3);
    }
}