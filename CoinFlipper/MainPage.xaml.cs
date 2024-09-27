using Microsoft.Graphics.Canvas.Brushes;
using System.Diagnostics;

namespace CoinFlipper
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                Coin moeda = new Coin();
                moeda.Sortear();

                if (moeda.Sortear() == 0 && CoinPicker.SelectedIndex == 0)
                {
                    ResultLabel.Text = "Você venceu! \nEscolheu cara!";
                    ImageCoin.Source = "cara.png";
                }
                else if (moeda.Sortear() == 1 && CoinPicker.SelectedIndex == 1)
                {
                    ResultLabel.Text = "Você venceu! \nEscolheu coroa!";
                    ImageCoin.Source = "coroa.png";
                }
                else if (moeda.Sortear() == 0 && CoinPicker.SelectedIndex == 1)
                {
                    ResultLabel.Text = "Você perdeu! \nEscolheu coroa e deu cara!";
                    ImageCoin.Source = "cara.png";
                }
                else if (moeda.Sortear() == 1 && CoinPicker.SelectedIndex == 0)
                {
                    ResultLabel.Text = "Você perdeu! \nEscolheu cara e deu coroa!";
                    ImageCoin.Source = "coroa.png";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}