class homework6
{
    public static void Main()
    {
        showCharacter();
        CalculateRetail();
        ConvertCelsius();
        primeNum();


    }
   public static void showCharacter()
{
    Console.WriteLine("Please enter a word.");
    string anyWord = System.Console.ReadLine();

    Console.WriteLine("enter a number.");
    int num = Convert.ToInt32(Console.ReadLine());
    var result = anyWord[num - 1];

    Console.WriteLine($"{anyWord}. {num}. The character in the {num} position is the letter {result}.");
    

}


//CALCULATE RETAIL

public static double calculateRetail(double wholeSale, double markupPercentage)
        
        {
            double retailValue = wholeSale + wholeSale * markupPercentage / 100;

            return retailValue;
        }

       public static void CalculateRetail()
        {

            Console.Write("What is wholesale cost of item?: ");
            double wholeSaleEntered = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is markup percentage of item?: ");
            double markupPercentageEntered = Convert.ToDouble(Console.ReadLine());

            double retailPrice = calculateRetail(wholeSaleEntered, markupPercentageEntered);

            Console.WriteLine("Item's retail price is: " + retailPrice.ToString("0.00"));
          
        }

        //TEMPERATURE TABLE
        public static float convertCelsius(float fahrenheit)
        {
            float celsius = (5f / 9f) * (fahrenheit - 32);
            return celsius;
        }
       public static void ConvertCelsius()
        {

            Console.WriteLine("Fahrenheit      Celsius");
            for (int integer = 80; integer <= 100; integer++)
            {

                float celsius = (float)integer;

                Console.WriteLine("   " + integer + "           " + convertCelsius(celsius));
            }
        }

        //PRIME NUMBERS
        public static void primeNum()

        {

            Console.WriteLine("Enter a number");

            int num = Convert.ToInt32(Console.ReadLine());

            int result = IsPrime(num);

            if (result == 0)

            {

                Console.WriteLine("{0} Is not a Prime Number (False)", num);

            }

            else

            {

                Console.WriteLine("{0} Is a Prime Number (True)", num);

            }

            Console.Read();

        }


        public static int IsPrime(int num)

        {

            int integer;

            for (integer = 2; integer <= num - 1; integer++)

            {

                if (num % integer == 0)

                {

                    return 0;

                }

            }

            if (integer == num)

            {

                return 1;

            }

            return 0;

        }

    }



