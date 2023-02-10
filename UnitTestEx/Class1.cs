namespace UnitTestEx;
public class Class1
    {
        public static double Min(double num1, double num2)
        {
            if (num1 < num2) { return num1; }
            else { return num2; } 
        }

        public static double Min(double num1, double num2, double num3)
        {
            double min = num1;
            if (num2 < min) { min = num2; }
            if (num3 < min) { min = num3; }

            return min;
        }

    }
