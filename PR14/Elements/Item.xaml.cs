using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace PR14.Elements
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(Classes.Item item)
        {
            InitializeComponent();

            if (item != null)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "/Images/Items/" + item.src))
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/Items/" + item.src));
                else
                    image.Source = new BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "/Images/Items/placeholder.jpg"));

                price.Content = item.price;
                name.Content = item.name;
            }
        }
    }
}
