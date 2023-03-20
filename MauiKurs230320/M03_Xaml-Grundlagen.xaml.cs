namespace MauiKurs230320;

public partial class Grundlagen : ContentPage
{
	public Grundlagen()
	{
        //Dies verweist auf eine Methode in der (versteckten) automatisch generierten zweiten Klassen-Datei (*.g.i.cs),
        //welche für das Rendering des XAML-Codes verantwortlich ist. InitializeComponent() erstellt die
        //Steuerelement-Objekte und muss daher als erste Methode des Konstruktors bestehen bleiben
        InitializeComponent();

		Btn_KlickMich.BackgroundColor = Colors.Red;
	}

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
        //Mittels eines DisplayAlerts können kleine (asynkrone) Aussagen und Abfragen an den Benutzer ausgegeben
        if (await DisplayAlert("FRAGE", "Soll was passieren?", "Ja", "Nein"))
		{
            //Verändern der Text-Eigenschaft (angezeigter Text) des Buttons
            (sender as Button).Text = "Button wurde geklickt";
			Btn_KlickMich.BackgroundColor = Colors.Blue;

			Lbl_Output.Text = "Ciao";
		}
    }
}

