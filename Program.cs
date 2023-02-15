int numero,resultado;
Console.WriteLine("Digite um número para ver a Tabuada dele:");
numero = int.Parse(Console.ReadLine());

for(int i = 0; i <11; i++){
    resultado = numero*i;
    Console.WriteLine($"{numero} X {i} = {resultado}");
}
