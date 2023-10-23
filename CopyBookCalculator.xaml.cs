using System;
using System.Windows;

namespace LB_2 {
    public partial class CopyBookCalculator {
        private bool _cover;

        public CopyBookCalculator() {
            InitializeComponent();
        }

        private static readonly string[] AvailableNames = {
            "В клітинку", "В лінію", "В лінію", "В кругляшок", "Для малювання", "Для дітей", 
            "Крутий", "Повсякденний"
        };

        public static string RandName() {
            Random random = new Random();
            var index = random.Next(AvailableNames.Length);
            return AvailableNames[index];
        }

        private void WithCover(object sender, RoutedEventArgs e) => _cover = true;
        private void WithoutCover(object sender, RoutedEventArgs e) => _cover = false;

        private void CountPrice(object sender, RoutedEventArgs e) {
            try {
                var cpBook = new CopyBook(RandName(), uint.Parse(Pages_box.Text));
                if (_cover) {
                    cpBook = new SuperBook(RandName(), uint.Parse(Pages_box.Text));
                }

                name_field.Content = cpBook.Name;
                price_field.Content = cpBook.Price() + "\u20b4";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}