
using System.Windows;

namespace StatePickerDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    // The MainWindow class is the main window of the application.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string SelectedAbbreviation { get => (string)statePickerAbbreviation.SelectedValue; }

        public string SelectedName { get => (string)statePickerFullName.SelectedValue; }
    }
}