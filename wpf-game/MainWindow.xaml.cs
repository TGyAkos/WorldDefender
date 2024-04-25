using System.Windows;

namespace WorldDefender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool goLeft, goRight, goUp, goDown;
        int speed = 10;
        int positionX;
        int positionY;
        int height;
        int width;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeApp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void minimizeApp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KeyIsDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }
    }
}