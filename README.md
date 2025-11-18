Word Wrap Kata - Implementación con TDD
📋 Descripción
Este repositorio contiene la implementación de la Word Wrap Kata desarrollada mediante Test-Driven Development (TDD). El proyecto consistió en implementar el método Wrap paso a paso, partiendo de un conjunto de pruebas unitarias ya definidas.
🎯 Objetivo
Crear una función que envuelva texto en múltiples líneas respetando un ancho máximo especificado, sin romper palabras en medio, aplicando los principios de TDD.
🔄 Metodología TDD Aplicada
El desarrollo siguió rigurosamente el ciclo Red-Green-Refactor:

🔴 Red (Rojo)
Se ejecutaron las pruebas existentes que inicialmente fallaban
Cada prueba definía un caso específico del comportamiento esperado

🟢 Green (Verde)
Se implementó el código mínimo necesario para hacer pasar cada prueba
Cada iteración agregó funcionalidad incremental al método Wrap

🔵 Refactor (Azul)
Se mejoró el código manteniendo las pruebas en verde
Se optimizó la legibilidad y estructura sin alterar el comportamiento

💻 Tecnologías y Conceptos de C#
Método Wrap Implementado

public static string Wrap(string text, int col)
{
    // Implementación que maneja:
    // - Texto vacío
    // - Texto más corto que el ancho
    // - División por espacios
    // - Múltiples líneas
    // - Palabras largas
}
Características de C# Utilizadas

String manipulation: Uso de Split, Substring, Trim
StringBuilder: Para construcción eficiente de strings
LINQ: Para procesamiento de colecciones
String interpolation: Para formateo de texto
Métodos de extensión: Para mejorar la legibilidad del código

✅ Casos de Prueba Cubiertos
Texto vacío
Texto menor al ancho especificado
Texto exactamente igual al ancho
Texto que requiere una división
Texto con múltiples espacios
Palabras más largas que el ancho permitido

🚀 Ejecución
bash# Ejecutar las pruebas
dotnet test

# Compilar el proyecto
dotnet build

📚 Aprendizajes Clave

TDD como disciplina: El ciclo Red-Green-Refactor guió todo el desarrollo
Diseño incremental: Cada prueba agregó complejidad gradualmente
Refactorización segura: Las pruebas permitieron mejorar el código con confianza
Manejo de strings en C#: Aplicación práctica de métodos nativos del lenguaje

🔗 Referencias

Word Wrap Kata - Samman Coaching
Test-Driven Development
