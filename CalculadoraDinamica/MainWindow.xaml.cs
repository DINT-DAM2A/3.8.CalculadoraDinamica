using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Contador de numero del boton
            int count = 1;

            //Fila
            for (int i = 2; i < 5; i++)
            {
                //Columna
                for (int j = 0; j < 3; j++)
                {
                    TextBlock caja = new TextBlock();
                    caja.Text = Convert.ToString(count);

                    Viewbox vBox = new Viewbox();
                    vBox.Child = caja;

                    Button btn = new Button();
                    btn.Tag = count;
                    btn.SetValue(Grid.ColumnProperty, j);
                    btn.SetValue(Grid.RowProperty, i);
                    btn.Content = vBox;

                    GridMain.Children.Add(btn);
                    count++;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlockPrincipal.Text = TextBlockPrincipal.Text + (sender as Button).Tag.ToString();
        }
    }
}
