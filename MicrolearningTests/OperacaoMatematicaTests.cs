using Microlearning;
using Xunit;

namespace MicrolearningTests
{
    public class OperacaoMatematicaTests
    {
        #region Fact

        //Fact permite testar um cenário único
        //DisplayName que aparecerá no console de testes, caso oculta aparecerá o próprio nome do método
        [Fact(DisplayName = "Teste para validar operação de soma")]
        //Trait permite o agrupamento dos testes pela descrição
        [Trait("Funcionalidade", "Somar")]
        public void DadoDoisNumerosDeveRetornarASomatoriaEntreEles()
        {
            //Padronização de testes unitários => Padrão AAA

            //Arrange => Preparação do cenário que precisa testar
            //aqui vem a instacia das classes, inicialização de variaveis, etc
            var math = new OperacaoMatematica();

            //Act => metódo que de será testado
            var resultado = math.Somar(1, 1);

            //Assert => validação do resultado do teste
            Assert.Equal(2, resultado);
        }

        //[Fact(DisplayName = "Teste para validar operação de subtração")]
        //[Trait("Funcionalidade", "Subtrair")]
        //public void DadoDoisNumerosDeveRetornarASubtracaoEntreEles()
        //{
        //    //Arrange
        //    var math = new OperacaoMatematica();

        //    //Act
        //    var resultado = math.Subtrair(2, 1);

        //    //Assert
        //    Assert.Equal(1, resultado);
        //}

        //[Fact(DisplayName = "Teste para validar operação de multiplicação")]
        //[Trait("Funcionalidade", "Multiplicar")]
        //public void DadoDoisNumerosDeveRetornarAMultiplicacaoEntreEles()
        //{
        //    //Arrange
        //    var math = new OperacaoMatematica();

        //    //Act
        //    var resultado = math.Multiplicar(7, 5);

        //    //Assert
        //    Assert.Equal(35, resultado);
        //}

        //[Fact(DisplayName = "Teste para validar operação de divisão")]
        //[Trait("Funcionalidade", "Divisão")]
        //public void DadoDoisNumerosDeveRetornarADivisaoEntreEles()
        //{
        //    //Arrange
        //    var math = new OperacaoMatematica();

        //    //Act
        //    var resultado = math.Dividir(50, 2);

        //    //Assert
        //    Assert.Equal(25, resultado);
        //}

        #endregion

        #region Theory

        //private OperacaoMatematica mathSetup;
        //public OperacaoMatematicaTests()
        //{
        //    mathSetup = new OperacaoMatematica();
        //}

        ////Theory permite criar varios cenários de testes com parametro sem necessariamente reescrever os testes
        //[Theory]
        ////As 3 linhas abaixo, criam 3 cenários de testes
        //[InlineData(2, 3, 5)]
        //[InlineData(14, 14, 28)]
        //[InlineData(37, 3, 40)]
        //public void DadoDoisNumerosDeveRetornarASomatoriaEntreElesUsandoTheory(int numero1, int numero2, int resultadoEsperado)
        //{
        //    //Act
        //    var resultado = mathSetup.Somar(numero1, numero2);

        //    //Assert
        //    Assert.Equal(resultadoEsperado, resultado);
        //}

        //[Theory]
        //[InlineData(5, 4, 1)]
        //[InlineData(14, 7, 7)]
        //[InlineData(10, 5, 5)]
        //public void DadoDoisNumerosDeveRetornarASubtracaoEntreElesUsandoTheory(int numero1, int numero2, int resultadoEsperado)
        //{
        //    //Act
        //    var resultado = mathSetup.Subtrair(numero1, numero2);

        //    //Assert
        //    Assert.Equal(resultadoEsperado, resultado);
        //}

        //[Theory]
        //[InlineData(4, 4, 16)]
        //[InlineData(7, 5, 35)]
        //[InlineData(8, 9, 72)]
        //public void DadoDoisNumerosDeveRetornarAMultiplicacaoEntreElesUsandoTheory(int numero1, int numero2, int resultadoEsperado)
        //{
        //    //Act
        //    var resultado = mathSetup.Multiplicar(numero1, numero2);

        //    //Assert
        //    Assert.Equal(resultadoEsperado, resultado);
        //}

        //[Theory]
        //[InlineData(4, 4, 1)]
        //[InlineData(2, 1, 2)]
        //[InlineData(8, 2, 4)]
        //public void DadoDoisNumerosDeveRetornarADivisaoEntreElesUsandoTheory(int numero1, int numero2, int resultadoEsperado)
        //{
        //    //Act
        //    var resultado = mathSetup.Dividir(numero1, numero2);

        //    //Assert
        //    Assert.Equal(resultadoEsperado, resultado);
        //}

        #endregion

        #region Exception

        //[Fact(DisplayName = "Teste para validar operação de divisão com cenário de exception")]
        //[Trait("Funcionalidade", "DivisãoException")]
        //public void DadoDoisNumerosSendoOSegundoIgualAZeroDeveRetornarUmaExceptionParaOMetodoDeDivisao()
        //{
        //    //Arrange
        //    var math = new OperacaoMatematica();

        //    //Assert
        //    var exception = Assert.Throws<FormatException>(
        //        //Act
        //        () => math.Dividir(1, 0)
        //    );

        //    Assert.Equal("Divisão por zero não pode ser executada", exception.Message);
        //}

        #endregion

        #region Testa todos os cenários

        //[Fact(DisplayName = "Teste para validar operação de soma condicional com primeiro número sendo igual a zero")]
        //[Trait("Funcionalidade", "SomarCondicional")]
        //public void DadoDoisNumerosSendoOPrimeiroIgualAZeroDeveRetornarZero()
        //{
        //    //Arrange
        //    var math = new OperacaoMatematica();

        //    //Act
        //    var resultado = math.SomarCondicional(0, 1);

        //    //Assert
        //    Assert.Equal(0, resultado);
        //}

        //[Fact(DisplayName = "Teste para validar operação de soma condicional com números iguais")]
        //[Trait("Funcionalidade", "SomarCondicional")]
        //public void DadoDoisNumerosIguaisDeveRetornarUmNegativo()
        //{
        //    //Arrange
        //    var math = new OperacaoMatematica();

        //    //Act
        //    var resultado = math.SomarCondicional(1, 1);

        //    //Assert
        //    Assert.Equal(-1, resultado);
        //}

        //[Fact(DisplayName = "Teste para validar operação de soma condicional")]
        //[Trait("Funcionalidade", "SomarCondicional")]
        //public void DadoDoisNumerosDeveRetornarASomaEntreEles()
        //{
        //    //Arrange
        //    var math = new OperacaoMatematica();

        //    //Act
        //    var resultado = math.SomarCondicional(1, 2);

        //    //Assert
        //    Assert.Equal(3, resultado);
        //}

        #endregion
    }
}
