int numero;

Console.WriteLine("------ Bem-vindo(a) ao programa de tabuadas ------");

Console.Write("Digite um número para ver sua tabuada: "); 

while (!int.TryParse(Console.ReadLine(), out numero)) {
    Console.Write("Resposta inválida. Tente novamente digitando um número inteiro: "); 
} 
Console.WriteLine($"\nTabuada do número: {numero}"); 
for (int x = 0; x <= 10; x++){ 
    Console.WriteLine($"{numero} x {x} = {numero * x}"); 
}

Console.Write("Digite qualquer tecla para finalizar o programa!");
Console.ReadKey();
Console.Clear();