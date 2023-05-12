// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

interface OperadoresLogicos { 
    static void Main(String[] args)
    {
        var atividade1 = true;
        var atividade2 = false;

        var todas = atividade1 && atividade2;

        Console.WriteLine("Fez todas as atividades? {0}", todas);

        var umaApenas = atividade1 || atividade2;

        Console.WriteLine("Fez pelomenos uma das atividades? {0}", umaApenas);
        Console.WriteLine("Não fez nenhuma? {0}", !umaApenas);
    }
}