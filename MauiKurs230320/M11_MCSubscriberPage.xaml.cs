namespace MauiKurs230320;

public partial class MCSubscriberPage : ContentPage
{
	public MCSubscriberPage()
    { 
		//Einstellen der aktuellen Sprache -> Definiert zu ladende resx-Dateien
        M11_Loc.Strings.Culture = new System.Globalization.CultureInfo("en-US");

		InitializeComponent();

        //Anmeldung am Messaging-Center -> Callback wird aufgerufen bei Empfang der Sendung
        MessagingCenter.Subscribe<Navi.NavPageBsp, string>(this, "nachricht", (s,e) => Lbl_Main.Text = e);
	}
}