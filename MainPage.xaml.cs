using static System.Net.Mime.MediaTypeNames;

namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        double total;

        public MainPage()
        {
            InitializeComponent();
            porcentagemSlider.Value = 17;
        }

        private void quinzePorcento_Clicked(object sender, EventArgs e)
        {
            porcentagemSlider.Value = 15;


        }
        private void vinteporcento_Clicked(object sender, EventArgs e)
        {
            porcentagemSlider.Value = 20;

        }


        private void roundDown_Clicked(object sender, EventArgs e)
        {
            double baixo = Math.Floor(total);
            GorjetaFinal.Text = $"R$ {baixo:F2}";
        }

        private void RoundUp_Clicked(object sender, EventArgs e)
        {
            
            double cima = Math.Ceiling(total);
            GorjetaFinal.Text = $"R$ {cima:F2}";
          

        }

        private void porcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            try
            {
                double porcentagem = porcentagemSlider.Value;
                string Texto = ValorGorjetaEntry.Text;
                double num = Double.Parse(Texto);
                double porcento = num * (porcentagemSlider.Value / 100);
                total = porcento + num;
                                

                ValorGorjetaLabel.Text = porcento.ToString("c");
                GorjetaFinal.Text = total.ToString("c");
                

                GorjetaFinal.Text = $"R$ {total:F2}";
                Porcentagem.Text = $"{porcentagemSlider.Value:F0}%";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                DisplayAlert("Erro","Digite um valor valido","ok");
            }

        }
    }

}
