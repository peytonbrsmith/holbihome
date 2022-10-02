namespace holbihome.Controls
{
    public partial class CardView : ContentView
    {
        public static readonly BindableProperty CardIconProperty = BindableProperty.Create(nameof(CardIcon), typeof(Image), typeof(CardView), null);
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);

        public CardView()
        {
            InitializeComponent();
        }

        public Image CardIcon
        {
            get => (Image)GetValue(CardIconProperty);
            set => SetValue(CardIconProperty, value);
        }

        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }

        public string CardDescription
        {
            get => (string)GetValue(CardDescriptionProperty);
            set => SetValue(CardDescriptionProperty, value);
        }
    }
}
