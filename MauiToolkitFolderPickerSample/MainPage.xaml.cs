using CommunityToolkit.Maui.Storage;

namespace MauiToolkitFolderPickerSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		try
		{
			var folder = await FolderPicker.PickAsync(default);

			folderPath.Text = $"Name: {folder.Name} Path: {folder.Path}";
		}
		catch
		{
			// TODO Implement
		}
	}
}

