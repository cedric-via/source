using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPAppTest
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Exemple d'authentification simple (à remplacer par une vérification réelle)
            if (username == "admin" && password == "password")
            {
                // Redirection vers le tableau de bord
                Frame.Navigate(typeof(DashboardPage));
            }
            else
            {
                // Afficher un message d'erreur
                ErrorMessage.Visibility = Visibility.Visible;
            }
        }
    }
}
