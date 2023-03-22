namespace MauiKurs230320.Plattformspezifika;

public partial class Plattformspezifika : ContentPage
{
	public Plattformspezifika()
	{
		InitializeComponent();

		Lbl_Orientation.Text = new DeviceOrientationService().GetOrientation().ToString();

		Lbl_Batterie.Text = Battery.ChargeLevel.ToString() + " | " + Battery.State.ToString();

		Lbl_Pref.Text = Preferences.Get("OnStop", "Nothing");
	}
}