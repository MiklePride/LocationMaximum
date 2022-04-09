class program
{
    static void Main(string[] args)
    {
        int arrayOfIntegerSize = 30;
        int[] arrayOfIntegers = new int[arrayOfIntegerSize];
        int indexFirstElementArrayOfInteger = 0;
        Random random = new Random();
        int indexArrayOfIntegers;
        int minimumRandomNumber = 0;
        int maximumRandomNumber = 90;

        for (indexArrayOfIntegers = 0; indexArrayOfIntegers < arrayOfIntegers.Length; indexArrayOfIntegers++)
        {
            arrayOfIntegers[indexArrayOfIntegers] = random.Next(minimumRandomNumber, maximumRandomNumber);
            Console.Write(arrayOfIntegers[indexArrayOfIntegers] + " ");
        }
        Console.Write("\nЛокальные максимумы целочисленноного массива:");

        if (arrayOfIntegers[indexFirstElementArrayOfInteger] > arrayOfIntegers[indexFirstElementArrayOfInteger + 1])
        {
            Console.Write(arrayOfIntegers[indexFirstElementArrayOfInteger] + " ");
        }

        for (indexArrayOfIntegers = 1; indexArrayOfIntegers < arrayOfIntegers.Length - 1; indexArrayOfIntegers++)
        {
            if (arrayOfIntegers[indexArrayOfIntegers] > arrayOfIntegers[indexArrayOfIntegers + 1] && arrayOfIntegers[indexArrayOfIntegers] > arrayOfIntegers[indexArrayOfIntegers - 1])
            {
                Console.Write(arrayOfIntegers[indexArrayOfIntegers] + " ");
                indexArrayOfIntegers ++;
            }
        }

        if (arrayOfIntegers[arrayOfIntegers.Length - 1] > arrayOfIntegers[arrayOfIntegers.Length - 2])
        {
            Console.Write(arrayOfIntegers[arrayOfIntegers.Length - 1] + " ");
        } 
    }
}