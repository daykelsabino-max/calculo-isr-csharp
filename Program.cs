using System;

class Program
{
    static void Main()
    {
        double sueldoMensual, sueldoAnual, isr = 0;

        Console.Write("Ingrese el sueldo mensual del empleado: ");
        sueldoMensual = Convert.ToDouble(Console.ReadLine());

        sueldoAnual = sueldoMensual * 12;

        if (sueldoAnual <= 416220.00)
            isr = 0;
        else if (sueldoAnual <= 624329.00)
            isr = (sueldoAnual - 416220.00) * 0.15;
        else if (sueldoAnual <= 867123.00)
            isr = ((sueldoAnual - 624329.00) * 0.20) + 31216.00;
        else
            isr = ((sueldoAnual - 867123.00) * 0.25) + 79776.00;

        Console.WriteLine("Sueldo anual: RD$ " + sueldoAnual.ToString("F2"));

        if (isr == 0)
            Console.WriteLine("ISR a pagar: N/A");
        else
            Console.WriteLine("ISR anual a pagar: RD$ " + isr.ToString("F2"));
    }
}