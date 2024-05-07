using System;
using System.Globalization;

class URI { 
        
    static void Main(string[] args) {

        double pi, volumeEsfera;
        int raio;

        raio = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        pi = 3.14159;

        volumeEsfera = (4.0/ 3) * pi * Math.Pow(raio, 3.0);

        //fórmula para calcular o volume é: (4/3) * pi * Raio ao cubo*

        Console.WriteLine("VOLUME = " + volumeEsfera.ToString("F3", CultureInfo.InvariantCulture));

        Console.ReadLine();
    }

}