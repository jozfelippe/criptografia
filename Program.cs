Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("DIGITE UMA FRASE PARA ENCRIPTAR:");
string frase = Console.ReadLine()!;

Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("DIGITE UMA CHAVE (NÚMERO):");
int numero = Convert.ToInt32(Console.ReadLine())!;

    string fraseNormal = frase.ToLower(); 
    string fraseEncriptada = fraseNova(fraseNormal, numero);

Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("FRASE ESCOLHIDA: " + frase);
Console.WriteLine("FRASE ENCRIPTADA: " + fraseEncriptada);
Console.WriteLine("");

    static string fraseNova(string frase, int numero)
        {
        char[] letras = frase.ToCharArray();
        string novaFrase = "";

            foreach (char letra in letras)
            {
            if (char.IsLetter(letra)) 
            {
            char novaLetra = (char)(((letra - 'a' + numero) % 26) + 'a'); 

            novaFrase += novaLetra;
            }
            else
            {
            novaFrase += letra; 
            }
            }

        return novaFrase;
        }