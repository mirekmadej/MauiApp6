namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        private static string ml = "abcdefghijklmnopqrstuvwxyz";
        private static string dl = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string cy = "01234567890";
        private static string zs = "!@#$%^&*()_+-=,.<>?;:";
        private static string s = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGenerujClicked(object sender, EventArgs e)
        {
            s = "";
            if (chkMale.IsChecked)
                s += ml;
            if(chkDuze.IsChecked)
                s += dl;
            if(chkCyfry.IsChecked)
                s += cy;
            if(chkZnaki.IsChecked)
                s += zs;
            

            lblHaslo.Text = s;


        }
    }

}
