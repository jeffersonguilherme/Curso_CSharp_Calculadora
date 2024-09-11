namespace Calculator {
    class Program {
        static void Main(string[] args) {
            Menu();
           
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("");

            Console.WriteLine("Qual o peração deseja fazer? ");
            Console.WriteLine("0 - Sair da calculadora ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");


            Console.WriteLine("");
            Console.WriteLine("___________");
            Console.WriteLine("");

            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res){
                case 0: Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }

        }
        static void Soma(){
             Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();

            Console.Write("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Divisao(){
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadLine();
            Menu();
        }
    }
}