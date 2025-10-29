using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace MyMauiApp.PageModels;

//public abstract class BasePageModel : INotifyPropertyChanged
//{
//    public event PropertyChangedEventHandler? PropertyChanged;

//    protected void OnPropertyChanged(string propertyName)
//    {
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//    }
//}


// dotnet add package CommunityToolkit.Mvvm
public abstract partial class BasePageModel : ObservableObject
{
}