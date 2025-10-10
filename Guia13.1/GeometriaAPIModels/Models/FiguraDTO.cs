namespace GeometriaAPIModels.Models;

public class FiguraDTO
{
    public int? Id { get; set; }
    public double? Area { get; set; }

    public double? Ancho { get; set; }
    public double? Largo { get; set; }

    public double? Radio { get; set; }

    public double? Tipo { get; set; }

    override public string ToString()
    {
        if (Tipo == 1)
            return $"Rectangulo: #{Id}, Area: {Area:f2}, Ancho: {Ancho:f2}, Largo: {Largo:f2}";
        else if (Tipo == 2)
            return $"Circulo: #{Id}, Area: {Area:f2}, Radio: {Radio:f2}";
        else
            return $"Figura desconocida: #{Id}, Area: {Area:f2}";
    }
}
