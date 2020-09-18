using Practice.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Product> Products;

        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icon>();
            Icons.Add(new Icon { ImagePath = "Assets/air-force-1-07-shoe-AKTdww3y.jpg" }); ;
            Icons.Add(new Icon { ImagePath = "Assets/air-jordan-1-mid-older-shoe-g5qTCp.jpg" });
            Icons.Add(new Icon { ImagePath = "Assets/air-jordan-1-mid-shoe-BpARGV.jpg" });
            Icons.Add(new Icon { ImagePath = "Assets/air-max-270-react-se-shoe-CWMfWr.jpg" });
            Icons.Add(new Icon { ImagePath = "Assets/air-max-95-shoe-8pVwjT.jpg" });
            Icons.Add(new Icon { ImagePath = "Assets/air-max-verona-shoe-b3F7NZ.jpg" });
            ImageComboBox.ItemsSource = Icons;
            ImageComboBox.SelectedIndex = 0;

            Products = new ObservableCollection<Product>();
        }
        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Icon)ImageComboBox.SelectedValue).ImagePath;
            Products.Add(new Product { ProductName = ProductNameTextBox.Text, Description = DescriptionTextBox.Text, Image = image });

            ProductNameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            ProductNameTextBox.Focus(FocusState.Programmatic);
        }
    }
}
