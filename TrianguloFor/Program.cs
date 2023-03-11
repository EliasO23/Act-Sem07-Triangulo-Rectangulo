// See https://aka.ms/new-console-template for more information

Console.WriteLine("\nBIENVENIDO AL CREADOR DE TRIANGULOS");
Console.WriteLine("             RECTANGULOS             ");
Console.WriteLine("\nIngrese la altura del triangulo: ");
int altura = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("\n-----------------------------------");
Console.WriteLine("             Triangulo   ");
Console.WriteLine("-----------------------------------\n");
for (int i = 1; i <= altura; i++){
    for (int j = 1; j <= i; j++){
        Console.Write(" *");
    }
    Console.WriteLine();
}
Console.WriteLine("\n----------------------------------\n");

Console.WriteLine("¡Gracias por viisitar el creador \nde tringulos rectangulos!\n");




