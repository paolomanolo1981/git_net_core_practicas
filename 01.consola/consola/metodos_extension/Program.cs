using System;

namespace metodos_extension
{
    class   Program
    {
        static void Main(string[] args)
        {
            string s = "Hello Extension Method";
            int i = s.WordCount();
            Console.WriteLine($"Metodo de extensión devolvío {i}");
            Persona p = new Persona();
            p.Nombre = "Paolo";
            var a = p.Edad.EsNull();
            var valor= p.NoTieneNombre();
            Console.Write(valor);

        }

    }


    public class Persona
{
    public string Nombre { get; set; }
    public int? Edad { get; set; }
}

    public class Comprobaciones
{
    public bool esCorrecto(Persona persona)
    {
        return !persona.NoTieneNombre();
    }
}

    public static class Extensores
{
    public static Boolean EsNull(this Object objeto)
    {
        return objeto == null;
    }

    public static Boolean NoTieneNombre(this Persona persona)
    {
        return string.IsNullOrEmpty(persona.Nombre) && string.IsNullOrWhiteSpace(persona.Nombre);
    }
}
}
