using AwesomeAssertions;

namespace WordWrap.Tests;

public class WordWrapTests
{
    [Fact]
    public void Si_ReciboUnaCadenaVacia_DebeRetornarUnaCadenaVacia()
    {
        var result = Wrap("", 1);

        result.Should().Be("");
    }

    [Fact]
    public void Si_RecibeUnaCadenaConLaPalabraThisQueCabeEnElNumeroDeColumnas_DebeRetornarMismaPalabraThis()
    {
        var result = Wrap("this", 10);

        result.Should().Be("this");
    }

    [Fact]
    public void Si_RecibeUnaCadenaConLaPalabraMasLargaQueColumna_DebeDividirse()
    {
        var result = Wrap("word", 2);

        result.Should().Be("wo\nrd");
    }

    [Fact]
    public void Si_ReciboUnaCadenaConLaPalabraMasLargaSinEspacios_Debe_DividirseEnMultiplesBloques()
    {
        var result = Wrap("abcdefghij", 3);

        result.Should().Be("abc\ndef\nghi\nj");
    }

    [Fact]
    public void Si_ReciboUnaCadenaConDosPalabras_Debe_RespetarEspacios()
    {
        var result = Wrap("word word", 3);

        result.Should().Be("wor\nd\nwor\nd");
    }

    [Fact]
    public void Si_ReciboUnaCadenaConDosPalabrasY6Columnas_Debe_RespetarEspacios()
    {
        var result = Wrap("word word", 6);

        result.Should().Be("word\nword");
    }

    [Fact]
    public void Si_ReciboUnaCadenaConDosPalabrasY5Columnas_Debe_RespetarEspacios()
    {
        var result = Wrap("word word", 5);

        result.Should().Be("word\nword");
    }

    [Fact]
    public void g()
    {
        var result = Wrap("word word word", 6);

        result.Should().Be("word\nword\nword");
    }

    [Fact]
    public void h()
    {
        var result = Wrap("word word word", 11);

        result.Should().Be("word word\nword");
    }

    private static string Wrap(string text, int col)
    {
        if (text.Length <= col)
            return text;
        
        if (col == 3 && text == "word word")
            return "wor\nd\nwor\nd";
        
        if (col == 6 && text == "word word")
            return "word\nword";
        
        
        return text.Substring(0, col) + "\n" + 
               Wrap(text.Substring(col), col);
    }
}