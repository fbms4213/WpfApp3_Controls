using System.Windows;
using System.Windows.Controls;

namespace Source;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // listBox.Items.Add(new Button { Content = "Dyn" });

        // frame.Source = new Uri(@"https://www.google.com/");
    }

    private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = sender as ListBox;

        if (item?.SelectedItem is Label lbl)
            MessageBox.Show(lbl.Content.ToString());
        else if (item?.SelectedItem is Button btn)
            MessageBox.Show(btn.Content.ToString());
    }


    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {

    }

    private void RepeatBtn_Click(object sender, RoutedEventArgs e)
    {
        // if(sender is RepeatButton btn)
        // {
        //     if(btn.Content.ToString() == "Up")
        //         progressBar.Value += 10;
        //     else
        //         progressBar.Value -= 10;
        // }
    }



    private void ToggleButton_Checked(object sender, RoutedEventArgs e)
    {
        //MessageBox.Show((sender as ToggleButton)?.IsChecked.ToString());
    }

    private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
    {
        //MessageBox.Show((sender as ToggleButton)?.IsChecked.ToString());
    }

    private void CheckBox_Checked(object sender, RoutedEventArgs e)
    {

    }
}
