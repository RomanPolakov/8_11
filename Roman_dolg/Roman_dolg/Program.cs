int i, s, s1, s2, s3, mes1, mes2, mes3;
int[] one = new int[12];
int[] two = new int[12];
int[] three = new int[12];
s1 = 0;
s2 = 0;
s3 = 0;
for (i = 1; i < 12; i++)
{
    Console.WriteLine("Введите зарпалату 1 работника за " + i + ", месяц");
    one[i] = Convert.ToInt32(Console.ReadLine());
    s1 = s1 + one[i];
    Console.WriteLine();
}
for (i = 1; i < 12; i++)
{
    Console.WriteLine("Введите зарплату 2 работника за " + i + " месяц");
    two[i] = Convert.ToInt32(Console.ReadLine());
    s2 = s2 + two[i];
    Console.WriteLine();
}
for (i = 1; i < 12; i++)
{
    Console.WriteLine("Введите зарплату 3 работника за " + i + " месяц");
    three[i] = Convert.ToInt32(Console.ReadLine());
    s3 = s3 + three[i];
    Console.WriteLine();
}

Console.WriteLine(); s = s1 + s2 + s3;
mes1 = one[1] + two[1] + three[1];
mes2 = one[2] + two[2] + three[2];
mes3 = one[3] + two[3] + three[3];
Console.WriteLine("Общая сумма зарплат: {0}", s);
Console.WriteLine("Зарплата 1 рабочего за квартал: {0}", s1);
Console.WriteLine("Зарплата 2 рабочего за квартал: {0}", s2);
Console.WriteLine("Зарплата 3 рабочего за квартал: {0}", s3);
Console.WriteLine("Зарплата всех работников за 1 месяц: {0}", mes1);
Console.WriteLine("Зарплата всех работников за 2 месяц: {0}", mes2);
Console.WriteLine("Зарплата всех работников за 3 месяц: {0}", mes3);
