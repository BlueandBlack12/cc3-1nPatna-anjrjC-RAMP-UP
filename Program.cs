namespace CSharpRampUp
{
    internal class Program
    {
        static void Main()
        {
            // Pounds to Kilograms Conversion
            Console.Write("Enter weight in pounds: ");
            double weightPounds = Convert.ToDouble(Console.ReadLine());
            double weightKilos = weightPounds * 0.45359237;
            Console.WriteLine($"{weightPounds} pounds is  {weightKilos} in kilograms.");
            Console.WriteLine(" ");

            // Miles to Kilometers Conversion
            Console.Write("Enter length in miles: ");
            double distanceMiles = Convert.ToDouble(Console.ReadLine());
            double distanceKilometers = distanceMiles * 1.609344;
            Console.WriteLine($"{distanceMiles} miles is  {distanceKilometers} in kilometers.");
            Console.WriteLine(" ");


            // Fahrenheit to Celsius Conversion
            Console.Write("Enter temperature in Fahrenheit: ");
            double temperatureFahrenheit = Convert.ToDouble(Console.ReadLine());
            double temperatureCelsius = (temperatureFahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{temperatureFahrenheit}°F is  {temperatureCelsius} in °C.");
            Console.WriteLine(" ");


            // Average Age Calculation
            double sumAge = 0;
            Console.WriteLine("Enter age of 10 students:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Student {i + 1} age: ");
                double age = Convert.ToDouble(Console.ReadLine());
                sumAge += age;
            }
            double averageAge = sumAge / 10;
            Console.WriteLine($"Average age of the students is {averageAge} years old.");
            Console.WriteLine(" ");


            // Fantasy Story
            string character1 = "Michael O’Connor";
            string identity = " Main Character";
            string character2 = "Daniel";
            string identity2 = "A leprechaun";
            string character3 = "Liam";
            string identity3 = "Richest leprechaun";
            string equipment = "Trap master";
            string item = "Wishing Stone";
            string skill = "Thorn Binding";

            Console.WriteLine($"In “The Leprechaun Trap,” {character1} <{identity}> believes he is the most clever person in Ireland. In an attempt to get rich quickly, Michael catches  {character2}  <{identity2}> using his tool <{equipment}> and  his ability<{skill}> the two work together to steal the gold of Daniel’s wealthier brother, {character3}<{identity3}> and the sacred treasure <{item}>. Although Michael follows all of Daniel’s tips and tricks for outwitting {character3}, he soon learns that greed can distract even the cleverest folks.");
            Console.WriteLine(" ");

            // Print number pattern
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine(" ");

            // Print sum of numbers
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)


            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                int sumNum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sumNum += i;

                }
                Console.WriteLine($"The sum of numbers from 1 to {num} is: {sumNum}");

            }
            Console.WriteLine(" ");

            // Print number pattern
            Console.Write("Enter a positive integer: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = num; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }

        }

    }
}