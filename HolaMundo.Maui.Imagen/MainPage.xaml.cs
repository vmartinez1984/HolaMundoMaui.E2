namespace HolaMundo.Maui.Imagen
{
    public partial class MainPage : ContentPage
    {
        string[] urlDeIamgenes = new string[4];
        int numero = 0;
        public MainPage()
        {
            InitializeComponent();
            urlDeIamgenes[0] = "https://images.pexels.com/photos/28751650/pexels-photo-28751650.jpeg";
            urlDeIamgenes[1] = "https://images.pexels.com/photos/33650774/pexels-photo-33650774.jpeg";
            urlDeIamgenes[2] = "https://images.pexels.com/photos/16840106/pexels-photo-16840106.jpeg";
            urlDeIamgenes[3] = "https://images.pexels.com/photos/11571052/pexels-photo-11571052.jpeg";
        }

        private void ClickedMostrarImagenes(object sender, EventArgs e)
        {
            Image.Source = urlDeIamgenes[numero];
            if (numero == 3)
                numero = 0;
            else
                numero++;
        }
    }
}
