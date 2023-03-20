using System.Diagnostics;

namespace MauiKurs230320;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage beinhaltet die jeweils angezeigte Seite. Zuweisungen hier definieren die Startpage der App.
        MainPage = new Grundlagen();
	}

    //Override der CreateWindow() um Zugriff auf globale shared Lifecycle-Events zu haben (für OS-spezifische LC-Events siehe MauiProgram.cs)
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window wnd = base.CreateWindow(activationState);

		wnd.Created += (s, e) => Debug.Print("OnStart");
		wnd.Stopped += (s, e) => Debug.Print("OnStop");

		return wnd;
    }
}
