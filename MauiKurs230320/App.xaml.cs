﻿using System.Diagnostics;

namespace MauiKurs230320;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();


        //MainPage beinhaltet die jeweils angezeigte Seite. Zuweisungen hier definieren die Startpage der App.
        //MainPage = new Bindings.Bindings();

        //Stack-Navigation per Navigation-Page (vgl. Navi\NavPageBsp.cs)
        //In ContentPages innerhalb von NavigationPages können bestimmte Navigations-Befehle verwendet werden
        //MainPage = new NavigationPage(new Navi.NavPageBsp());

        //Alternative Navigation per Tabbed-Page (vgl. Navi\TabbedPageBsp.cs)
        //MainPage = new Navi.TabbedPageBsp();

        //Alternative Navigation per Flyout-Page (vgl. Navi\FlyoutBsp\*)
        //MainPage = new Navi.FlyoutBsp.FlyoutPage1();

        //AppShell beinhaltet die Shell-Navigation dieser App (vgl. Navi.AppShell.cs)
        MainPage = new Navi.AppShell();
    }

    //Override der CreateWindow() um Zugriff auf globale shared Lifecycle-Events zu haben (für OS-spezifische LC-Events siehe MauiProgram.cs)
    protected override Window CreateWindow(IActivationState activationState)
    {
        Window wnd = base.CreateWindow(activationState);

		wnd.Created += (s, e) => Debug.Print("OnStart");
        wnd.Stopped += (s, e) => { Debug.Print("OnStop"); Preferences.Set("onStop", "CIAO"); };

		return wnd;
    }
}
