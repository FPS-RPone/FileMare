using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    List<String> listFullPath = new List<String>();
    public MainWindow()
    {
        InitializeComponent();
        foreach (var d in Directory.GetDirectories(Directory.GetCurrentDirectory()))
        {
            listFullPath.Add(d);
            //Path.GetFileName(d);
            
        }
        foreach (var f in Directory.GetFiles(Directory.GetCurrentDirectory()))
        {
            listFullPath.Add(f);
            lboxLeft.Items.Add(f.
                );
        }
    }

    private void lboxLeft_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        
    }

    private void lboxRight_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {

    }

    private void lboxLeft_KeyDown(object sender, KeyEventArgs e)
    {

    }
}