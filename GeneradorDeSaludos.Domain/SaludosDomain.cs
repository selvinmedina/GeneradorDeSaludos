namespace GeneradorDeSaludos.Domain
{
    public class SaludosDomain
    {
        public string Saludar(string? nombre, DateTime hora)
        {
            if (nombre == "Director")
            {
                return $"¿Cómo está hoy, {nombre}?";
            }

            if (nombre != null && hora.Hour < 12)
            {
                return $"Buenos días, {nombre}";
            }

            if (nombre != null && hora.Hour >= 12 && hora.Hour <= 18)
            {
                return $"Buenas tardes, {nombre}";
            }

            if (nombre != null && hora.Hour >= 19)
            {
                return $"Buenas noches, {nombre}";
            }

            return "Hola, mundo";
        }
    }
}
