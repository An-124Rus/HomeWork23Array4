internal class Program
{
    private static void Main(string[] args)
    {
        const string Sum = "Sum";
        const string Exit = "Exit";

        int number = 0;
        bool isWorking = true;
        int finalSum = 0;

        int[] array = new int[number];

        while (isWorking)
        {
            Console.Write($"Введите число: ");
            string userInput = Console.ReadLine();

            int[] tempArray = new int[array.Length + 1];

            if (userInput.ToLower() == Sum.ToLower())
            {
                for (int i = 0; i < array.Length; i++)
                {
                    finalSum += array[i];
                }

                Console.Write($"\nСумма равна - {finalSum}\n\n");

                finalSum = 0;
            }

            if (userInput.ToLower() == Exit.ToLower())
            {
                isWorking = false;
            }

            if (userInput.ToLower() != Sum.ToLower() && userInput.ToLower() != Exit.ToLower())
            {
                number = Convert.ToInt32(userInput);

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