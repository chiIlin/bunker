using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace bunker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

#if DEBUG
            // Enables DevTools (press F12 to open) in debug mode
            this.AttachDevTools();
#endif

            // If you have a ViewModel:
            // DataContext = new MainWindowViewModel();

            // Wire up button click events
            var startGameButton = this.FindControl<Button>("StartGameButton");
            startGameButton.Click += OnStartGameClick;

            var settingsButton = this.FindControl<Button>("SettingsButton");
            settingsButton.Click += OnSettingsClick;

            var friendsButton = this.FindControl<Button>("FriendsButton");
            friendsButton.Click += OnFriendsClick;

            var rulesButton = this.FindControl<Button>("RulesButton");
            rulesButton.Click += OnRulesClick;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        // Simple handlers - you can do anything you like here
        private void OnStartGameClick(object? sender, RoutedEventArgs e)
        {
            ShowMessage("Start Game clicked!");
        }

        private void OnSettingsClick(object? sender, RoutedEventArgs e)
        {
            ShowMessage("Settings clicked!");
        }

        private void OnFriendsClick(object? sender, RoutedEventArgs e)
        {
            ShowMessage("Friends clicked!");
        }

        private void OnRulesClick(object? sender, RoutedEventArgs e)
        {
            ShowMessage("Rules clicked!");
        }

        // A quick method to show a message
        // There's no default "MessageBox" in Avalonia, so let's just open a plain window:
        private void ShowMessage(string message)
        {
            var msgWindow = new Window
            {
                Title = "Info",
                Width = 300,
                Height = 150,
                Content = new TextBlock
                {
                    Text = message,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center
                }
            };

            // Show it as a dialog:
            msgWindow.ShowDialog(this);
        }
    }
}
