using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyMauiApp.Behaviors;

public class LogBehavior : Behavior<Button>
{
    public string Color { get; set; }

    protected override void OnAttachedTo(Button bindable)
    {
        bindable.Clicked += Bindable_Clicked;
    }

    private void Bindable_Clicked(object? sender, EventArgs e)
    {
        Button button = (Button)sender;
        button.Background = new SolidColorBrush(Colors.Red);
    }
}
