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

namespace Касса1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///
    //класс чек
    class Chek
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }

    //класс меню со списком блюд и их ценами
    public partial class MainWindow : Window
    {
        string[] menu = { "Маргарита", "Пепперони", "Неаполитанская", "Сицилийская",
            "Маникотти","Букатини","Джемелли","Феттуччини",
        "Грибной суп","Минестроне","Каччукко","Риболлита",
        "Капрезе","Панцанелла","Цезарь","Тосканский",
        "Поркетта","Фрико","Борджиа","Сальтимбокка",
        "Лимонад","Сок","Вино", "Вода"};
        int[] cena = { 400, 500, 450,550,
            400,300,350,500,
            310,380,330,450,
            250,290,250,500,
        150,350,200,300,
         220, 270,2000,150};
        public MainWindow()
        {
            InitializeComponent();
        }

        //обработчик клика на один из подпунктов меню, поля с блюдами, ценами и их кол-вом становятся видимыми, а другие подпункты скрыты
        private void SubMenuClick(object sender, RoutedEventArgs e)
        {
            h1.Visibility = Visibility.Visible;
            h2.Visibility = Visibility.Visible;
            h3.Visibility = Visibility.Visible;
            h4.Visibility = Visibility.Visible;
            h5.Visibility = Visibility.Visible;
            h6.Visibility = Visibility.Visible;
            back.Visibility = Visibility.Visible;
            sup.Visibility = Visibility.Hidden;
            pizza.Visibility = Visibility.Hidden;
            pasta.Visibility = Visibility.Hidden;
            second_meal.Visibility = Visibility.Hidden;
            salad.Visibility = Visibility.Hidden;
            drinks.Visibility = Visibility.Hidden;
        }

        //обработчики клика для каждой из категории блюд
        private void pizza_Click(object sender, RoutedEventArgs e)
        {
            name1.Text = "Маргарита";
            price1.Text = "400";
            img1.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Маргарита.jpg"));

            name2.Text = "Пепперони";
            price2.Text = "500";
            img2.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Пепперони.jpg"));

            name3.Text = "Неаполитанская";
            price3.Text = "450";
            img3.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Неаполитанская.jpg"));

            name4.Text = "Сицилийская";
            price4.Text = "550";
            img4.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Сицилийская.jpg"));
            SubMenuClick(sender, e);
        }

        private void pasta_Click(object sender, RoutedEventArgs e)
        {
            name1.Text = "Маникотти";
            price1.Text = "400";
            img1.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Маникотти.jpg"));

            name2.Text = "Букатини";
            price2.Text = "300";
            img2.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Букатини.jpg"));

            name3.Text = "Джемелли";
            price3.Text = "350";
            img3.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Джемели.jpg"));

            name4.Text = "Феттуччини";
            price4.Text = "500";
            img4.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Фетуччини.jpg"));
            SubMenuClick(sender, e);
        }

        private void sup_Click(object sender, RoutedEventArgs e)
        {
            name1.Text = "Грибной суп";
            price1.Text = "310";
            img1.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Грибной суп.jpg"));

            name2.Text = "Минестроне";
            price2.Text = "380";
            img2.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Минестроне.jpg"));

            name3.Text = "Каччукко";
            price3.Text = "330";
            img3.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Качукко.jpg"));

            name4.Text = "Риболлита";
            price4.Text = "450";
            img4.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Риболитта.jpg"));
            SubMenuClick(sender, e);
        }

        private void salad_Click(object sender, RoutedEventArgs e)
        {
            name1.Text = "Капрезе";
            price1.Text = "250";
            img1.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Капрезе.jpg"));

            name2.Text = "Панцанелла";
            price2.Text = "290";
            img2.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Панцанелла.jpg"));

            name3.Text = "Цезарь";
            price3.Text = "250";
            img3.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Цезарь.jpg"));

            name4.Text = "Тосканский";
            price4.Text = "500";
            img4.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Тосканский.jpg"));
            SubMenuClick(sender, e);
        }

        private void second_meal_Click(object sender, RoutedEventArgs e)
        {
            name1.Text = "Поркетта";
            price1.Text = "150";
            img1.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Поркетта.jpg"));

            name2.Text = "Фрико";
            price2.Text = "350";
            img2.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Фрико.jpg"));

            name3.Text = "Борджиа";
            price3.Text = "200";
            img3.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Борджиа.jpg"));

            name4.Text = "Сальтимбокка";
            price4.Text = "300";
            img4.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Сальтимбокка.jpg"));
            SubMenuClick(sender, e);
        }

        private void drinks_Click(object sender, RoutedEventArgs e)
        {
            name1.Text = "Вода";
            price1.Text = "150";
            img1.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Вода.jpg"));

            name2.Text = "Вино";
            price2.Text = "2000";
            img2.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Вино.jpg"));

            name3.Text = "Лимонад";
            price3.Text = "220";
            img3.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Лимонад.jpg"));

            name4.Text = "Сок";
            price4.Text = "270";
            img4.Source = BitmapFrame.Create(new Uri("D:/Учеба/Касса/Сок.jpg"));
            SubMenuClick(sender, e);
        }


        //обработчик добавления блюда в определенном количестве в чек
        private void addd_Click(TextBlock names, TextBlock prices, TextBox counts)
        {
            Chek c = new Chek();
            int price = 0;
            int it = Convert.ToInt32(itog.Text);
            //проверяем введенное количество блюд, добавляем в чек
            if (counts.Text != "0")
            {
                if (!IsNumber(counts.Text) || counts.Text == "")
                {
                    counts.Text = "1";

                }

                try
                {
                    price = Convert.ToInt32(prices.Text) * Convert.ToInt32(counts.Text);
                }
                catch
                {
                    price = Convert.ToInt32(prices.Text);
                }

                c.Price = Convert.ToInt32(price);
                c.Title = names.Text;
                if (ContainsTitle(names.Text))
                {
                    it = Convert.ToInt32(itog.Text) - Containscena(names.Text);
                    string[] l = count.Text.Split('\n');
                    count.Text = "";
                    for (int i = 0; i < l.Length - 1; i++)
                    {
                        if (i != Containsind(names.Text))
                            count.Text += l[i] + "\n";

                    }
                    count.Text += l[l.Length - 1];
                    Cheks.Items.RemoveAt(Containsind(names.Text));
                }
                count.Text += counts.Text + "\n";
                Cheks.Items.Add(c);
                itog.Text = Convert.ToString(it + price);
            }
            else
                if (count3.Text == "0" && ContainsTitle(names.Text))
            {
                it = Convert.ToInt32(itog.Text) - Containscena(names.Text);
                string[] l = count.Text.Split('\n');
                count.Text = "";
                for (int i = 0; i < l.Length - 1; i++)
                {
                    if (i != Containsind(names.Text))
                        count.Text += l[i] + "\n";

                }
                count.Text += l[l.Length - 1];
                Cheks.Items.RemoveAt(Containsind(names.Text));
                itog.Text = Convert.ToString(it);
            }
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            addd_Click(name2, price2, count2);
        }

        private void add1_Click(object sender, RoutedEventArgs e)
        {
            addd_Click(name1, price1, count1);

        }



        private void add3_Click(object sender, RoutedEventArgs e)
        {
            addd_Click(name3, price3, count3);
        }

        private void add4_Click(object sender, RoutedEventArgs e)
        {
            addd_Click(name4, price4, count4);
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            Chek c = new Chek();
            int price = 0;
            count.Text = delNotNum(count.Text);
            string[] l = count.Text.Split('\n');
            int i = 0;
            string titles = "";
            foreach (var listBoxItem in Cheks.Items)
            {
                var item = (Chek)listBoxItem;
                if (l[i] != "0")
                {
                    item.Price = Convert.ToInt32(l[i]) * cena[Array.IndexOf(menu, item.Title)];
                    price += item.Price;
                }
                else
                {
                    titles += (item.Title + "\n");

                }
                Cheks.Items.Refresh();
                i++;

            }
            string[] tits = titles.Split('\n');
            for (int j = 0; j < tits.Length; j++)
            {
                if (Containsind(tits[j]) != -1)
                {
                    Cheks.Items.RemoveAt(Containsind(tits[j]));

                    count.Text = count.Text.Replace("\n0\n", "\n");
                    if (count.Text[0] == '0')
                    {
                        count.Text = count.Text.Substring(1, count.Text.Length - 1);
                    }
                    if (count.Text[0] == '\n')
                    {
                        count.Text = count.Text.Substring(1, count.Text.Length - 1);
                    }
                    Cheks.Items.Refresh();
                }
            }

            itog.Text = Convert.ToString(price);
        }
        private bool ContainsTitle(string nameOfItem)
        {
            foreach (var listBoxItem in Cheks.Items)
            {
                var item = (Chek)listBoxItem;
                if (item.Title == nameOfItem)
                {
                    return true;
                }
            }

            return false;

        }
        private int Containsind(string nameOfItem)
        {
            int i = -1;
            foreach (var listBoxItem in Cheks.Items)
            {
                i++;
                var item = (Chek)listBoxItem;
                if (item.Title == nameOfItem)
                {
                    return i;
                }
            }

            return -1;

        }
        private int Containscena(string nameOfItem)
        {
            foreach (var listBoxItem in Cheks.Items)
            {
                var item = (Chek)listBoxItem;
                if (item.Title == nameOfItem)
                {
                    return item.Price;
                }
            }

            return 0;

        }
        private string delNotNum(string num)
        {
            string s = "";
            foreach (char a in num)
            {
                if (Char.IsNumber(a) || a == '\n')
                {
                    s += a;
                }
            }
            return s;
        }
        private bool IsNumber(string num)
        {
            foreach (char a in num)
            {
                if (!Char.IsNumber(a))
                {
                    return false;
                }
            }
            return true;
        }

        private void count2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            count2.Text = "";
        }

        private void count4_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            count4.Text = "";
        }

        private void count3_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            count3.Text = "";
        }

        private void count1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            count1.Text = "";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            h1.Visibility = Visibility.Hidden;
            h2.Visibility = Visibility.Hidden;
            h3.Visibility = Visibility.Hidden;
            h4.Visibility = Visibility.Hidden;
            h5.Visibility = Visibility.Hidden;
            h6.Visibility = Visibility.Hidden;
            count1.Text = "Количество";
            count2.Text = "Количество";
            count3.Text = "Количество";
            count4.Text = "Количество";    
            back.Visibility = Visibility.Hidden;
            sup.Visibility = Visibility.Visible;
            pizza.Visibility = Visibility.Visible;
            pasta.Visibility = Visibility.Visible;
            second_meal.Visibility = Visibility.Visible;
            sup.Visibility = Visibility.Visible;
            salad.Visibility = Visibility.Visible;
            drinks.Visibility = Visibility.Visible;
            
        }
    }
}
