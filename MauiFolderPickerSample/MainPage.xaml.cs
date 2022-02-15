namespace MauiFolderPickerSample;

public partial class MainPage : ContentPage
{
	private readonly IFolderPicker _folderPicker;

	public MainPage(IFolderPicker folderPicker)
	{
		InitializeComponent();
		_folderPicker = folderPicker;
	}

	private async void OnPickFolderClicked(object sender, EventArgs e)
	{
		var pickedFolder = await _folderPicker.PickFolder();

		FolderLabel.Text = pickedFolder;

		SemanticScreenReader.Announce(FolderLabel.Text);
	}
}

