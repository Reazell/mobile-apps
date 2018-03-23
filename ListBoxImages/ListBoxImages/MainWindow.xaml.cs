using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Collections.ObjectModel;

namespace ListBoxImages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AvailableItems = new ObservableCollection<CustomItem>();
            AvailableItems.Add(new CustomItem("/ListBoxImages;component/Images/B1.png"));
            AvailableItems.Add(new CustomItem("/ListBoxImages;component/Images/B2.png"));
            AvailableItems.Add(new CustomItem("/ListBoxImages;component/Images/C1.png"));
            AvailableItems.Add(new CustomItem("/ListBoxImages;component/Images/C2.png"));
            this.DataContext = this;
        }
        public ObservableCollection<CustomItem> AvailableItems
        {
            get;
            set;
        } 
    }
}
