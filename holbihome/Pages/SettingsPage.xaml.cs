namespace holbihome;

public partial class SettingsPage : ContentPage
{
	public List<string> themes = new List<string>() { 
		"Light",
		"Dark",
		"System"
	};

    public SettingsPage()
	{
		InitializeComponent();
	}

	
}


