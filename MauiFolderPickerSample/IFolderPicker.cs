namespace MauiFolderPickerSample
{
    public interface IFolderPicker
    {
        Task<string> PickFolder();
    }
}
