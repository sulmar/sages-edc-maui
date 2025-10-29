using System.ComponentModel;

namespace Models;

public abstract class BaseEntity : INotifyPropertyChanged
{
    public int Id { get; set; }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
