namespace MauiKurs230320;

public partial class Controls : ContentPage
{
	public Controls()
	{
		InitializeComponent();
    }

    //Eventhandler des Button.Clicked-Event
    private void Button_Clicked(object sender, EventArgs e)
    {
        //Verwendung des sender-Parameters (enth�lt Event-ausl�sendes Objekt; hier Button)
        (sender as Button).Text = "Clicked";
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        //Beispiele f�r DisplayAlert-Aufrufe (mit zwei bzw. einem Button)-->
        bool result = await DisplayAlert
            (
                "L�schen",
                "Soll dieser Eintrag wirklich gel�scht werden?",
                "Ja",
                "Nein"
            );

        if (result)
            await DisplayAlert("Cool", "Du hast auf ja geklickt", "ok");
    }
}