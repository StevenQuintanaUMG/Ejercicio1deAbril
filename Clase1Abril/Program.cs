void matriz()
{
    string[] nombre = new string[5];

    for (int i = 0; i < 5;  i++) {
        Console.WriteLine("\nIngrese el nombre: " + (i+1));
        nombre[i] = Console.ReadLine();
    }

    int[] notas = new int[nombre.Length];

    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine("\nIngrese la nota de " + nombre[i]);
        notas[i] = Convert.ToInt32(Console.ReadLine());
    }

    int max = 0;
    int num = 0;

    for(int i = 0; i < notas.Length; i++)
    {
        if(notas[i] > max)
        {
            max = notas[i];
            num = i;
        }
    }

    Console.WriteLine("\nLa nota mayor es de: " + nombre[num] + " con " + max);
}

matriz();