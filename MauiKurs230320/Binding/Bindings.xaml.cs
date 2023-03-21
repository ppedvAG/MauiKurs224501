using Microsoft.Maui.Controls.Xaml;

namespace MauiKurs230320.Binding;

public partial class Bindings : ContentPage
{
	public Bindings()
	{
		InitializeComponent();
	}

    private async void Btn_Show_Clicked(object sender, EventArgs e)
    {
		Person person = Sly_DataBinding.BindingContext as Person;

		await DisplayAlert("Person", $"{person.Name}: {person.Alter}", "ok");
    }

    private void Btn_Altern_Clicked(object sender, EventArgs e)
    {
        Person person = Sly_DataBinding.BindingContext as Person;
        person.Alter++;
        person.AktualisiereGUI();
    }

    private void Btn_New_Clicked(object sender, EventArgs e)
    {
        Person person = Sly_DataBinding.BindingContext as Person;
        person.WichtigeTage.Add(new DateTime(2023, 1, 1));
    }

    private void Btn_Delete_Clicked(object sender, EventArgs e)
    {
        Person person = Sly_DataBinding.BindingContext as Person;

        if (LstV_Tage.SelectedItem != null)
            person.WichtigeTage.Remove((DateTime)LstV_Tage.SelectedItem);
    }

   
}

enum TestEnum { Eins, Zwei, Drei }

[ContentProperty("Type")]
public class EnumBindingSourceExtension : IMarkupExtension
{
    public Type Type { get; set; }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        if (Type is null || !Type.IsEnum)
            throw new Exception("Du musst einen Enum einfügen");

        return Enum.GetValues(Type);
    }
}