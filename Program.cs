//найти сумму элементов на нечётных позициях в случайном массиве
Console.WriteLine("Введите кол-во элементов в массиве:");
int numbermas = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[numbermas];
Random rnd = new Random();
for (int count = 0; count < numbermas; count++)
{
    mas[count] = rnd.Next(0, 100);
    Console.WriteLine("Элемент массива номер" + count + " = " + mas[count]);
}
double sum = 0;
int count1 = 1;
do
{
    sum = sum + mas[count1];
    count1 = count1+2;
}
while (count1 < numbermas);
Console.WriteLine("Сумма элементов массива на нечётных позициях = " + sum);
