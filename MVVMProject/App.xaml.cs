using System.Windows;

namespace MVVMProject
{
    public partial class App
    {
        public static object? FocusedWindow => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsFocused);
        public static object? ActivedWindow => Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsActive);
    }

}
