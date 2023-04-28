using System;

class HelloWorld {
    static void Main() {
        float fahrenheit, celsius;
        celsius = 0;
        fahrenheit = 9.0f/5.0f * celsius + 32;
        Console.WriteLine("{0} Celsius entspricht {1} fahrenheit", celsius, fahrenheit);
        
        celsius = (float) Convert.ToDouble("20");
        fahrenheit = 9.0f/5.0f * celsius + 32;
        Console.WriteLine("{0} Celsius entspricht {1} fahrenheit", celsius, fahrenheit);
    }
}
