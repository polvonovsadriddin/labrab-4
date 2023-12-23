try
{
    Console.Write(" Введите колво строк:");
   int f = int.Parse(Console.ReadLine());
    Console.Write(" Введите колво столбцов:");
    int n = int.Parse(Console.ReadLine());

    int[,] mas1 = new int[f, n];
    Random rand = new Random();
    for (int i = 0; i < mas1.GetLength(0); i++)
    {
        for (int j = 0; j < mas1.GetLength(1); j++)
        {
            mas1[i, j] = rand.Next(1, 100);

             
            Console.Write(mas1[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int[] mas2 = new int[f*n];
    int k = 0;
    for (int i = 0;i < mas1.GetLength(0);i++)
    {
       
        for (int j = 0;j < mas1.GetLength(1);j++)
        {
            mas2[k]= mas1[i,j];
            k++;
           
        }
    }

    
    ////сортировка пузырком

    for (int i = 0; i < mas2.GetLongLength(0); i++)
    {
       
        for (int j = 0; j < mas2.Length - i - 1; j++)
        {

            if (mas2[j] > mas2[j + 1])
            {
                int temp = mas2[j];
                mas2[j] = mas2[j + 1];
                mas2[j + 1] = temp;

            }
           
        }
    }
    int d= 0;
    for(int i = 0;i<mas1.GetLength(0);i++) 
    {
        for(int j = 0; j < mas1.GetLength(1); j++)
        {
            mas1[i, j] = mas2[d++];
            Console.Write(mas1[i,j]+" ");
        }
        Console.WriteLine();

    }



}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}