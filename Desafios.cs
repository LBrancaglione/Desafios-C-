using System;

class Desafios
{
    static void Main(string[] args)
    {
        while (true) // Loop infinito para permitir múltiplas escolhas
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Soma dos números de 1 a 10");
            Console.WriteLine("2 - Calcular IMC");
            Console.WriteLine("3 - Calculadora");
            Console.WriteLine("0 - Sair");

            // Lê a escolha do usuário
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    SomaNumeros(); // Chama o método SomaNumeros
                    break;
                case "2":
                    CalcularIMC(); // Chama o método CalcularIMC
                    break;
                case "3":
                    Calculadora(); // Chama o método Calculadora
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    return; // Sai do programa
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void SomaNumeros()
    {
        int soma = 0;

        for (int i = 1; i <= 10; i++)
        {
            soma += i; // Soma os números de 1 a 10
        }

        Console.WriteLine("A soma dos números de 1 a 10 é: " + soma);
    }

    static void CalcularIMC()
    {
        double peso;
        double altura;

        // Valida a entrada do peso
        while (true)
        {
            Console.WriteLine("Digite seu peso (em kg):");
            string pesoInput = Console.ReadLine();
            if (double.TryParse(pesoInput, out peso))
            {
                break; // Sai do loop se a conversão for bem-sucedida
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido para o peso.");
            }
        }

        // Valida a entrada da altura
        while (true)
        {
            Console.WriteLine("Digite sua altura (em metros):");
            string alturaInput = Console.ReadLine();
            if (double.TryParse(alturaInput, out altura))
            {
                break; // Sai do loop se a conversão for bem-sucedida
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido para a altura.");
            }
        }

        double imc = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: " + imc.ToString("F2")); // Formata o IMC com duas casas decimais

        // Classificação do IMC
        if (imc < 16)
            Console.WriteLine("Classificação: Magreza grave.");
        else if (imc >= 16 && imc < 16.9)
            Console.WriteLine("Classificação: Magreza moderada.");
        else if (imc >= 17 && imc < 18.4)
            Console.WriteLine("Classificação: Magreza leve.");
        else if (imc >= 18.5 && imc < 24.9)
            Console.WriteLine("Classificação: Peso normal.");
        else if (imc >= 25 && imc < 29.9)
            Console.WriteLine("Classificação: Sobrepeso.");
        else if (imc >= 30 && imc < 34.9)
            Console.WriteLine("Classificação: Obesidade grau 1.");
        else if (imc >= 35 && imc < 39.9)
            Console.WriteLine("Classificação: Obesidade severa.");
        else
            Console.WriteLine("Classificação: Obesidade mórbida.");
    }

    static void Calculadora()
    {
        double num1, num2;
        string operacao;

        // Lê o primeiro número
        Console.WriteLine("Digite o primeiro número:");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
        }

        // Lê o segundo número
        Console.WriteLine("Digite o segundo número:");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
        }

        // Lê a operação
        Console.WriteLine("Escolha a operação (+, -, *, /):");
        operacao = Console.ReadLine();

        double resultado = 0;
        bool operacaoValida = true;

        // Executa a operação com base na escolha do usuário
        switch (operacao)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    operacaoValida = false;
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                operacaoValida = false;
                break;
        }

        // Exibe o resultado
        if (operacaoValida)
            Console.WriteLine($"Resultado: {resultado}");
    }
}
