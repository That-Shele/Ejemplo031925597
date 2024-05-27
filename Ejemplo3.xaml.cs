namespace Ejemplo031925597;

public partial class Ejemplo3 : ContentPage
{
    /// <summary>
    /// Inicializa la página
    /// </summary>
	public Ejemplo3()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Recibe los valores de la última modificacion del texto y el texto actual
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string pasado = e.OldTextValue;
        string nuevo = e.NewTextValue;
    }

    /// <summary>
    /// Recibe el valor del texto del entry al ser llenado
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Entry_Completed(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}