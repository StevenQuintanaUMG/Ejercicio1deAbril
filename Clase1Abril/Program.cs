void matriz()
{
    uint N;

    do
    {

        Console.Write("Ola ingrese el numero de notas que desea registrar: ");

    } while (!uint.TryParse(Console.ReadLine(), out N)||N < 50);

    string[] nombre = new string[N];
    uint[] notas = new uint[N];

    for (uint i = 0; i < N; i++) {

        Console.Clear();

        Console.Write("\nIngrese el nombre " + (i + 1) + "\n> ");
        nombre[i] = Console.ReadLine();

        do
        {
            Console.Write("\nIngrese la nota de " + nombre[i] + "\n> ");

        } while (!uint.TryParse(Console.ReadLine(), out notas[i]) || (notas[i] > 100));

    }

    uint max = 0;
    uint min = 100;
    uint num_max = 0;
    uint num_min = 0;

    for (uint i = 0; i < N; i++)
    {
        if(notas[i] > max)
        {
            max = notas[i];
            num_max = i;
        }

        if (notas[i] < min)
        {
            min = notas[i];
            num_min = i;
        }
    }

    Console.Clear();
    Console.WriteLine("\nLa nota mayor es de " + nombre[num_max] + " con " + max);
    Console.WriteLine("La nota menor es de " + nombre[num_min] + " con " + min);

}

matriz();