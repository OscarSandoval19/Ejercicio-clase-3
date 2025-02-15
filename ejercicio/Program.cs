Console.Write("Ingrese el primer número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Elija una operacion:");
        Console.WriteLine(" +  Suma");
        Console.WriteLine(" -  Resta");
        Console.WriteLine(" *  Multiplicacion");
        Console.WriteLine(" /  Divsion");
        Console.Write("Ingrese la operacion que quiere realizar (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        
        int resultado;

        switch (op)
        {
            case '+':
                resultado = n1 + n2;
                Console.WriteLine("El resultado de la suma es: " + resultado);
                break;
            case '-':
                resultado = n1 - n2;
                Console.WriteLine("El resultado de la resta es: " + resultado);
                break;
            case '*':
                resultado = n1 * n2;
                Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                break;
            case '/':
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                    Console.WriteLine("El resultado de la division es: " + resultado);
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    
