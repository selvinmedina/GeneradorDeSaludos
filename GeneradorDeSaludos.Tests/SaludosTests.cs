using FluentAssertions;
using GeneradorDeSaludos.Domain;

namespace GeneradorDeSaludos.Tests
{
    // Ejercicio: Generador de Saludos
    public class SaludosTests
    {
        /*
            Saludo General:

            Si no se proporciona un nombre, devuelve "Hola, mundo".
         */
        [Fact]
        public void SaludoGeneral()
        {
            // Arrange
            var saludos = new SaludosDomain();

            string? saludo = null;
            var hora = DateTime.UtcNow.AddHours(-6);

            // Act
            string respuestaSaludo = saludos.Saludar(saludo, hora);

            // Assert
            respuestaSaludo.Should().Be("Hola, mundo");

        }

        /*
         Saludos Matutinos:
         Si la hora es antes de las 12 p.m., devuelve "Buenos días, [Nombre]".
         */
        [Fact]
        public void SaludoMatutino()
        {
            // Arrange
            var saludos = new SaludosDomain();

            string? nombre = "Selvin";
            DateTime hora = new DateTime(2024, 1, 10, 7, 0, 0); ;

            // Act
            string respuestaSaludo = saludos.Saludar(nombre, hora);

            // Assert
            respuestaSaludo.Should().Be($"Buenos días, {nombre}");

        }

        /*
         * Saludos Vespertinos:
         * Si la hora es entre las 12 p.m. y las 6 p.m., devuelve "Buenas tardes, [Nombre]".
         **/
        [Fact]
        public void SaludoVespertino()
        {
            // Arrange
            var saludos = new SaludosDomain();

            string? nombre = "Selvin";
            DateTime hora = new DateTime(2024, 1, 10, 18, 0, 0);

            // Act
            string respuestaSaludo = saludos.Saludar(nombre, hora);

            // Assert
            respuestaSaludo.Should().Be($"Buenas tardes, {nombre}");

        }

        /*
         *  Saludos Nocturnos:
         *  Si la hora es de las 7 p.m. en adelante, devuelve "Buenas noches, [Nombre]".
         ***/
        [Fact]
        public void SaludoNocturno()
        {
            // Arrange
            var saludos = new SaludosDomain();

            string? nombre = "Selvin";
            DateTime hora = new DateTime(2024, 1, 10, 19, 0, 0);

            // Act
            string respuestaSaludo = saludos.Saludar(nombre, hora);

            // Assert
            respuestaSaludo.Should().Be($"Buenas noches, {nombre}");
        }

        /*
         * Saludos Especiales:
        Si el nombre es "Director", independientemente de la hora, devuelve "¿Cómo está hoy, Director?".
        */
        [Fact]
        public void SaludoEspecial()
        {
            // Arrange
            var saludos = new SaludosDomain();

            string? nombre = "Director";
            DateTime hora = new DateTime(2024, 1, 10, 19, 0, 0);

            // Act
            string respuestaSaludo = saludos.Saludar(nombre, hora);

            // Assert
            respuestaSaludo.Should().Be($"¿Cómo está hoy, {nombre}?");
        }
    }
}
