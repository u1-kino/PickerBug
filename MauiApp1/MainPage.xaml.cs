namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	List<string> items = new List<string>
	{
		"1: First", "2: Second", "3: Third", "4: Fourth", "5: Fifth" , 
		"6: Sixth", "7: Seventh", "8: Eighth", "9: Ninth", "10: Tenth"
	};

    public List<string> PickerItems { get; set; }
	public string? SelectedItem { get; set; }

	public MainPage()
	{
		InitializeComponent();
		
        PickerItems = items;

		SelectedItem = items[4]; // "Fifth" Selected

        BindingContext = this;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        SelectedItem = (string)picker.SelectedItem;
        // Add other processing based on the selected item as needed
    }
}

