using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPAppTest
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class DashboardPage : Page
    {
        private DispatcherTimer _timer;

        public DashboardPage()
        {
            this.InitializeComponent();

            // Créer et configurer le DispatcherTimer
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)  // Met à jour toutes les secondes
            };
            _timer.Tick += OnTimerTick;
            _timer.Start();
        }

        // Événement déclenché lors de la sélection d'un élément dans le volet de navigation
        private void NavView_SelectionChanged(Windows.UI.Xaml.Controls.NavigationView sender, Windows.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is Windows.UI.Xaml.Controls.NavigationViewItem selectedItem)
            {
                string selectedTag = selectedItem.Tag?.ToString();

                // Navigation vers la page correspondante
                switch (selectedTag)
                {
                    case "Home":
                        Frame.Navigate(typeof(DashboardPage));  // Créez une page HomePage.xaml
                        break;
                    case "Statistics":
                        Frame.Navigate(typeof(DashboardPage));  // Créez une page StatisticsPage.xaml
                        break;
                    case "Settings":
                        Frame.Navigate(typeof(DashboardPage));  // Créez une page SettingsPage.xaml
                        break;
                }
            }
        }

        // Méthode qui se déclenche à chaque tic du timer
        private void OnTimerTick(object sender, object e)
        {
            // Simuler des données dynamiques
            var random = new Random();

            // Mettre à jour l'usage CPU
            CpuUsageText.Text = $"{random.Next(50, 100)}%";  // Valeur aléatoire entre 50% et 100%

            // Mettre à jour l'usage mémoire
            MemoryUsageText.Text = $"{random.Next(40, 80)}%";  // Valeur aléatoire entre 40% et 80%

            // Mettre à jour l'espace disque
            DiskUsageText.Text = $"{random.Next(50, 500)} GB";  // Valeur aléatoire entre 50 et 500 GB

            // Mettre à jour l'utilisation réseau
            NetworkUsageText.Text = $"{random.Next(100, 1000)} Mbps";  // Valeur aléatoire entre 100 et 1000 Mbps

            // Mettre à jour le nombre d'utilisateurs actifs
            ActiveUsersText.Text = $"{random.Next(100, 200)}";  // Valeur aléatoire entre 100 et 200 utilisateurs
        }
    }
}
