namespace Ejercicio1._1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sumar_Clicked(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numero1.Text);
            double num2 = Convert.ToDouble(numero2.Text);
            double resultado = num1 + num2;
            resultadoLabel.Text = "Resultado: " + resultado.ToString();
        }

        private void Restar_Clicked(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numero1.Text);
            double num2 = Convert.ToDouble(numero2.Text);
            double resultado = num1 - num2;
            resultadoLabel.Text = "Resultado: " + resultado.ToString();
        }

        private void Multiplicar_Clicked(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numero1.Text);
            double num2 = Convert.ToDouble(numero2.Text);
            double resultado = num1 * num2;
            resultadoLabel.Text = "Resultado: " + resultado.ToString();
        }

        private void Dividir_Clicked(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(numero1.Text);
            double num2 = Convert.ToDouble(numero2.Text);

            if (num2 != 0)
            {
                double resultado = num1 / num2;
                resultadoLabel.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                resultadoLabel.Text = "No se puede dividir por cero.";
            }
        }
    }
}
