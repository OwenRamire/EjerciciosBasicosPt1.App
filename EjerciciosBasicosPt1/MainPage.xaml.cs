namespace EjerciciosBasicosPt1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try {
			float firstValue = float.Parse(primerValor.Text);
			float secondValue = float.Parse(segundoValor.Text);
			float result = firstValue + secondValue;
            resultado.Text = firstValue + " + " + secondValue +  " = " + result;

        } catch {
			resultado.Text = "Error al obtener los datos! :c";
		}
    }
}

