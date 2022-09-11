internal class Program
{
    private static void Main(string[] args)
    {
        const string Sum = "Sum";
        const string Exit = "Exit";

        int value = 0;
        bool isWorking = true;

        int[] array = new int[value];

        while (isWorking)
        {
            Console.Write($"Введите число: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == Sum.ToLower())
            {
                int finalSum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    finalSum += array[i];
                }

                Console.Write($"\nСумма равна - {finalSum}\n\n");
            }
            else if (userInput.ToLower() == Exit.ToLower())
            {
                isWorking = false;
            }
            else
            {
                int number = Convert.ToInt32(userInput);

                int[] tempArray = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }

                tempArray[tempArray.Length - 1] = number;
                array = tempArray;
            }
        }
    }
}