// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

interface OrepadoresRelacionais2
{
       public void Main(string[] args){

        Console.WriteLine("Digite a sua nota: ");
        double.TryParse(Console.ReadLine(), out double nota);

        Console.WriteLine("Nota maior que 7? {0}", nota > 7.0);
        Console.WriteLine("Tirou 10?", nota == 10.0);

    }
}
