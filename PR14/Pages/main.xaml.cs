using PR14.Elements;
using System;
using System.Collections.Generic;
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

namespace PR14.Pages
{
    /// <summary>
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Item> items = new List<Item>();

        public Main()
        {
            InitializeComponent();

            items.Add(new Item("Шкаф", 20000, "placeholder.jpg"));
            items.Add(new Item("Диван", 15000, "divan.jpg"));
            items.Add(new Item("Кровать", 13000, "bed.jpg"));
            items.Add(new Item("Стул", 3000, "styl.jpg"));
            items.Add(new Item("Полки", 3400, "polki.jpg"));

            LoadItems();
        }

        public void LoadItems()
        {
            parent.Children.Clear();

            foreach (Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }

    }
}
