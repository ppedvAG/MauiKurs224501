namespace MauiKurs230320.Navi;

public partial class NavPageBsp : ContentPage
{
	public NavPageBsp()
	{
		InitializeComponent();
	}

    private void Btn_Grundlagen_Clicked(object sender, EventArgs e)
    {
        //Mittels PushAsync kann innerhalb einer NavigatinPage zu der nächsten Seite navigiert werden.
        //Vorherige Pages werden für die Back-Navigation auf den NavigationStack gelegt.
        Navigation.PushAsync(new Grundlagen());
    }

    private void Btn_Controls_Clicked(object sender, EventArgs e)
    {
        //Modal-Pushes verhindern die Anzeige von Titelleiste und Software-Back-Button bei der nächsten Seite und kann auch ohne NavigationPage verwendet werden
        Navigation.PushModalAsync(new Controls());
    }


    //M11: Button zur Verwendung des Messaging-Centers, vgl. M11_McSubscriberPage.xaml
    private void Button_Clicked(object sender, EventArgs e)
    {
        //Instanzierung des Empfänger-Objekts (dies aboniert im Konstruktor)
        Page subscriber = new MCSubscriberPage();

        //Senden einer Nachricht mit Titel und Inhalt
        MessagingCenter.Send(this, "nachricht", "Hallo, ich bin eine Nachricht");

        //Navigation zu Empfänger-Objekt
        Navigation.PushModalAsync(subscriber);
    }
}