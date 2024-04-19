// See https://aka.ms/new-console-template for more informat



int Calculate(int a, int b,int identifer)
{
        switch (identifer)
        {
                case 1:
                        return a + b;
                case 2:
                        return a - b;
                case 3:
                        return a * b;
                case 4:
                        if (a == 0 || b == 0)
                        {
                                Console.WriteLine("Sifira bolme olmaz");
                                return 0;
                        }
                        return a / b;
                default:
                        Console.WriteLine("Emeliyyatda sehf oldu yeniden basladin");
                        return 0;
        }
}

Console.WriteLine("Calculator basladildi...");
Console.WriteLine("Birinci ededi yazin.");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ikinci ededi yazin");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Emeliyyati secin 1den 4e qeder: +,-,*,/");
int emelliyat = Convert.ToInt32(Console.ReadLine());

int result = Calculate(a,b,emelliyat);

Console.WriteLine("Emelliyat neticesi: " + result);