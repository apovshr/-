using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Controls.Shapes;
using Avalonia.Collections;

namespace MyDrawingApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Пензлик для штрихування Cross, колір DeepPink
            var drawingGroup = new DrawingGroup();
            var penCross = new Pen(Brushes.DeepPink, 1);

            // Горизонтальна лінія
            drawingGroup.Children.Add(new GeometryDrawing
            {
                Geometry = new LineGeometry(new Point(0, 5), new Point(10, 5)),
                Pen = penCross
            });

            // Вертикальна лінія
            drawingGroup.Children.Add(new GeometryDrawing
            {
                Geometry = new LineGeometry(new Point(5, 0), new Point(5, 10)),
                Pen = penCross
            });

            var hatchBrush = new DrawingBrush
            {
                Drawing = drawingGroup,
                TileMode = TileMode.Tile,
                Stretch = Stretch.None,
                SourceRect = new RelativeRect(0, 0, 10, 10, RelativeUnit.Absolute),
                DestinationRect = new RelativeRect(0, 0, 10, 10, RelativeUnit.Absolute)
            };

            // Створюємо прямокутник
            var rect = new Rectangle
            {
                Width = 200,
                Height = 120,
                Fill = hatchBrush,
                Stroke = Brushes.BlueViolet,
                StrokeThickness = 2,
                StrokeDashArray = new AvaloniaList<double> { 4, 2, 1, 2 }
            };

            Canvas.SetLeft(rect, 50);
            Canvas.SetTop(rect, 50);
            MyCanvas.Children.Add(rect);

            // Додаємо текст
            var text = new TextBlock
            {
                Text = "Мій прямокутник",
                FontFamily = new FontFamily("Arial Black"),
                FontSize = 14,
                Foreground = Brushes.Black
            };

            Canvas.SetLeft(text, 70);
            Canvas.SetTop(text, 100);

            MyCanvas.Children.Add(text);
        }
    }
}
