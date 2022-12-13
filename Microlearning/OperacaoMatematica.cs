namespace Microlearning
{
    public class OperacaoMatematica
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            if(numero2 == 0)
            {
                throw new FormatException("Divisão por zero não pode ser executada");
            }

            return numero1 / numero2;
        }

        public int SomarCondicional(int numero1, int numero2)
        {
            if (numero1 == 0)
                return 0;

            if (numero1 == numero2)
                return -1;

            return numero1 + numero2;
        }
    }
}
