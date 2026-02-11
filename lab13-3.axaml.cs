using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Task3;

public partial class MainWindow : Window
{
    //Назви страв та їх ціни
    string[] names = {"Борщ", "Грибний суп", "Вермішелевий суп", "Пампушки", "Салат"};
    int[] prices = {180, 140, 120, 20, 30};

    //опції для вибору
    int[][] options =
    {
        new[] {0, 3, 4},
        new[] {1, 3, 4},
        new[] {2, 3, 4}
    };

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Show_Click(object? sender, RoutedEventArgs e)
    {
        //початковий індекс вибору
        int index = -1;

        //в залежності від кнопки обираємо
        if (v1.IsChecked == true) index = 0;
        else if (v2.IsChecked == true) index = 1;
        else if (v3.IsChecked == true) index = 2;

        //якщо кнопка не обрана, то пишемо обрати якусь опцію
        if (index == -1)
        {
            list.Text = "Оберіть варіант обіду!";
            sum.Text = "";
            return;
        }

        //проходимося по індексам
        var o = options[index];

        //загальна сума для сплати
        int total = 0;
        list.Text = "";

        //вивід назв страв з цінами + додавання їх у загальну суму для сплати
        foreach (var i in o)
        {
            list.Text += $"{names[i]} - {prices[i]} грн\n";
            total += prices[i];
        }

        //вивід суми
        sum.Text = $"Разом {total} грн";
    }
}
