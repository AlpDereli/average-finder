// See https://aka.ms/new-console-template for more information
fibonacii kullan = new fibonacii();
double uzunluk = kullan.gen();
double top = kullan.fibgener(uzunluk);
double ort = top / uzunluk;
Console.WriteLine(ort);

class fibonacii
{
    public double gen()
    {
        Console.WriteLine("Please enter a number for the length of the fibonacii sequance: ");
        double uzunluk = double.Parse(Console.ReadLine());
        return uzunluk;
    }
    public double fibgener(double uzunluk)
    {

        int ilk = 1, second = 1;
        int birim = 0; 
        double toplam = 0;
        if (uzunluk > 2)
        {
            for (int i = 0; i < uzunluk-2; i++)
            {
                birim = ilk + second;
                ilk = second;
                second = birim;
                toplam += birim;
            }
            toplam += 2;
        }
        else if(uzunluk == 2)
        {
            toplam = 2;
        }
        else 
        {
            toplam = 1;
        }
        return toplam;
    }
}