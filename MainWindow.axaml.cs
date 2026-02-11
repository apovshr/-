using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MyDrawingApp
{
    public partial class MainWindow : Window
    {
        // Імена та ціни
        string[] names = { "Іваненко", "Петренко", "Сидоренко", "Коваль", "Шевченко", "Гончар", "Мельник", "Бондар", "Ткаченко", "Романенко" };
        int[] prices = { 1000, 1200, 900, 1100, 1000, 950, 1150, 1300, 1050, 980 };

        // Бригади по 5 осіб (варіанти вибору)
        int[][] brigades =
        {
            new[] { 0, 1, 2, 3, 4 },
            new[] { 5, 6, 7, 8, 9 },
            new[] { 0, 2, 5, 7, 9 }
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        // Кнопка, яка буде показувати робітників та загальну суму платні за роботу
        private void Show_Click(object? sender, RoutedEventArgs e)
        {
            //початковий індекс вибору
            int index = -1;

            //в залежності від обраної кнопки надаємо індекс бригади
            if (v1.IsChecked == true) index = 0;
            else if (v2.IsChecked == true) index = 1;
            else if (v3.IsChecked == true) index = 2;

            //якщо не обрав жодного варіанту, просимо обрати варіант
            if (index == -1)
            {
                list.Text = "Оберіть варіант!";
                sum.Text = "";
                return;
            }

            //виклик бригади в залежності від індексу
            var b = brigades[index];

            //сума зарплат
            int total = 0;
            list.Text = "";

            // Для кожного індексу додаємо рядок і додаємо до суми
            foreach (var i in b)
            {
                list.Text += $"{names[i]} - {prices[i]} грн\n";
                total += prices[i];
            }

            sum.Text = $"Разом: {total} грн";
        }
    }
}
