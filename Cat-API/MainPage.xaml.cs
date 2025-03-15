namespace Cat_API
{
    public partial class MainPage : ContentPage
    {

        private readonly HttpClient _httpClient = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGenerateCarClicked(object sender, EventArgs e)
        {
            string text = txtInput.Text?.Trim();
            if (string.IsNullOrEmpty(text))
            {
                DisplayAlert("Miau", "Write Something!", "OK");
                return;
            }

            string apiUrl = $"https://cataas.com/cat/says/{Uri.EscapeDataString(text)}";
            imgCat.Source = ImageSource.FromUri(new Uri(apiUrl));
        }

    }
}