namespace holbihome.Controls
{
    public partial class CardView : ContentView
    {
        public static readonly BindableProperty CardIconProperty = BindableProperty.Create(nameof(CardIcon), typeof(string), typeof(CardView), null);
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty CardContentProperty = BindableProperty.Create(nameof(CardContent), typeof(ContentView), typeof(CardView), null);

        public CardView()
        {
            InitializeComponent();
        }

        public string CardIcon
        {
            get => (string)GetValue(CardIconProperty);
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

        public ContentView CardContent
        {
            get => (ContentView)GetValue(CardContentProperty);
            set => SetValue(CardContentProperty, value);
        }

       
    }
}
