int numero;

Console.WriteLine("------ Bem-vindo(a) ao programa de tabuadas ------");

Console.Write("Digite um número para ver sua tabuada: "); 

while (!int.TryParse(Console.ReadLine(), out numero)) {
    Console.Write("Resposta inválida. Tente novamente digitando um número inteiro: "); 
} 
Console.WriteLine($"\nTabuada do número: {numero}"); 
for (int i = 0; i <= 10; i++){ 
    Console.WriteLine($"{numero} x {i} = {numero * i}"); 
}

Console.Write("Digite qualquer tecla para finalizar o programa!");
Console.ReadKey();
Console.Clear();