

namespace TipTime
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            PercentageSlider.Value = 15;
            double percent = PercentageSlider.Value;
            TipPercentage.Text = percent.ToString("F") + "%";
        }


        private void PercentageSliderChanged(object sender, ValueChangedEventArgs e)
        {
            try
            {
                double percent = PercentageSlider.Value;
                double valorTotal = (double.Parse(Bill.Text));

                double gorjeta = valorTotal * (percent / 100);
                Tip.Text = "R$ " + gorjeta.ToString("F");
                TipPercentage.Text = percent.ToString("F") + "%";

                double totalFinal = valorTotal + gorjeta;
                Total.Text = "R$ " + totalFinal.ToString("F");
                Warning.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Warning.Text = "Por favor, insira um valor válido.";
            }
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
            double percent = PercentageSlider.Value;
            double valorTotal = (double.Parse(Bill.Text));

            double gorjeta = valorTotal * (percent / 100);
            double totalFinal = valorTotal + gorjeta;

            Total.Text = "R$ " + Math.Ceiling(totalFinal);
        }
        private void RoundDownButtonClicked(object sender, EventArgs e)
        {
            double percent = PercentageSlider.Value;
            double valorTotal = (double.Parse(Bill.Text));

            double gorjeta = valorTotal * (percent / 100);
            double totalFinal = valorTotal + gorjeta;

            Total.Text = "R$ " + Math.Floor(totalFinal);
        }

    }

}
