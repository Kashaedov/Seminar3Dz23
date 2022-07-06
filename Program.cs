Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());


void  Zadacha23 (int number1)

{
    for (int kub = 1; kub <= number1; kub+=1)
    {
        Console.Write ($"Число {kub} возведено в куб = ");
        Console.WriteLine ($"{kub}^3 = {Math.Pow(kub,3)}");

    }   
}
Zadacha23 ( number1 );
