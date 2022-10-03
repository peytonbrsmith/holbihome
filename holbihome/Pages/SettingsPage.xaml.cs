using static Android.Content.Res.Resources;

namespace holbihome;

public partial class SettingsPage : ContentPage
{
	public List<string> themes = new List<string>() { 
		"Light",
		"Dark",
		"System"
	};

    void OnPickerSelectionChanged(object sender, EventArgs e)
    {
        Picker picker = sender as Picker;
        Theme theme = (Theme)picker.SelectedItem;

        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();

            switch (theme)
            {
                case Theme.Dark:
                    mergedDictionaries.Add(new DarkTheme());
                    break;
                case Theme.Light:
                default:
                    mergedDictionaries.Add(new LightTheme());
                    break;
            }
            statusLabel.Text = $"{theme.ToString()} theme loaded. Close this page.";
        }
    }

    public SettingsPage()
	{
		InitializeComponent();
	}

	
}


