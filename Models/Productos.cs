namespace ProductosApi.Models;

public class Producto
{

    private int _id;
    public int Id { get { return _id; } set { _id = value; } }
    private string _nombre;

    public string Nombre
    {
        get { return _nombre; }
        set
        {
            _nombre = checkAtributoString(value);
        }
    }
    private string _marca;

    public string Marca
    {
        get
        {
            return _marca;
        }
        set
        {
            _marca = checkAtributoString(value);
        }
    }
    private double _alto;

    public double Alto { get { return _alto; } set { _alto = checkAtributoDouble(value); } }

    private double _ancho;
    public double Ancho { get { return _ancho; } set { _ancho = checkAtributoDouble(value); } }
    private double _profundidad;
    public double Profundidad { get { return _profundidad; } set { _profundidad = checkAtributoDouble(value); } }

    private double _peso;
    public double Peso { get { return _peso; } set { _peso = value; } }

    private double checkAtributoDouble(double dato)
    {
        if (dato < 0) throw new ArgumentException("Error, el valor no debe ser negativo");
        return dato;
    }

    private string checkAtributoString(string dato)
    {
        if (string.IsNullOrEmpty(dato)) throw new ArgumentException("Error, el valor es nulo o vacio");
        return dato;
    }

}