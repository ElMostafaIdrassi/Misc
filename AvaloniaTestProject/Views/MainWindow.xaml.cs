using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;

namespace AvaloniaTestProject.Views
{
	public class MainWindow : Window
    {
        private TextBlock Text => this.FindControl<TextBlock>("FilePath");

        public MainWindow()
		{
			InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}

		private async void ShowSaveFileDialogAsync(object sender, RoutedEventArgs e)
		{
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Title = "Save file to",
                InitialFileName = "InitialFileName",
                DefaultExtension = "txt",
                Filters = new List<FileDialogFilter>
                {
                    new FileDialogFilter
                    {
                        Name = "Text File (.txt)",
                        Extensions = new List<string> { "txt" }
                    },
                    new FileDialogFilter
                    {
                        Name = "All files",
                        Extensions = new List<string> {"*"}
                    }
                }
            };

            Text.Text = string.Join(" ", await dialog.ShowAsync(this));
        }

    }
}
