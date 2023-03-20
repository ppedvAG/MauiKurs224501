using System.Diagnostics;

namespace MauiKurs230320;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window wnd = base.CreateWindow(activationState);

		wnd.Created += (s, e) => Debug.Print("OnStart");
		wnd.Stopped += (s, e) => Debug.Print("OnStop");

		return wnd;
    }
}
