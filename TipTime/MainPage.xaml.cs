

namespace TipTime
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void PercentageSliderChanged(object sender, EventArgs e)
        {
            float percent = (float)PercentageSlider.Value;
            float valorTotal = (float.Parse(Bill.Text));

            float gorjeta = valorTotal * (percent / 100);
            Tip.Text = gorjeta.ToString();
            TipPercentage.Text = gorjeta.ToString() + "%";

            float totalFinal = valorTotal + gorjeta;
            Total.Text = totalFinal.ToString();

        }

        private void Percentage15ButtonClicked(object sender, EventArgs e)
        {
            PercentageSlider.Value = 15;
        }
        private void Percentage20ButtonClicked(object sender, EventArgs e)
        {
            PercentageSlider.Value = 20;
        }
        private void RoundUpButtonClicked(object sender, EventArgs e)
        {

        }
        private void RoundDownButtonClicked(object sender, EventArgs e)
        {

        }

    }

}
