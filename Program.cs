//Основные задачи

//Проверка ЛЮБОГО числа на палиндром
void ex19MODIFED()
{   
    Console.WriteLine("Введите натуральное число");
    int Num1 = Convert.ToInt32(Console.ReadLine());    
    int i = 0;
    int Num2 = Num1;
    double Rev1 = 0;
    double Rev2 = 0;
    while (Num1>0)
    { 
        int b=Num1%10;
        Num1 = Num1/10;
        Rev1 = Rev1 + b*Math.Pow(10,i);
        i = i + 1;
    }
    i = i- 1;
    while (Num2>0)
    {
        int b=Num2%10;
        Rev2 = Rev2 + b*Math.Pow(10,i);
        Num2 = Num2/10;
        i = i - 1;
    }
    if (Rev1 == Rev2) Console.WriteLine("Является палиндромом");
    else  Console.WriteLine("Не является палиндромом");
}
//Нахождения расстояния между точками в пространстве
void ex21()
{
    Console.WriteLine("Введите координаты первой точки");
    Console.WriteLine("x:");
    double x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y:");
    double y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z:");
    double z1 = Convert.ToInt32(Console.ReadLine());    
    Console.WriteLine($"Координата точки ({x1},{y1},{z1})");
        
    Console.WriteLine("Введите координаты второй точки");
    Console.WriteLine("x:");
    double x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y:");
    double y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z:");
    double z2 = Convert.ToInt32(Console.ReadLine());    
    Console.WriteLine($"Координата точки ({x2},{y2},{z2})");
    double dist=0;

    dist = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
    dist =  Math.Round(dist,2);
    Console.WriteLine($"Расстояние между точками ({dist})");
}
//Таблица кубов чисел от 1 до N
void ex23()
{
    Console.WriteLine("Введите натуральное число:");
    int N = Convert.ToInt32(Console.ReadLine());    
    int n =1;

    while (n < N+1)
        {
            double sqr = Math.Pow(n,3);
            Console.Write(sqr + " ");
            n = n +1;
        }
}





//Дополнительные задания 

//Решение простого уравнения
void ex1()
{
    Console.WriteLine("Введите x");
    double x = Convert.ToInt32(Console.ReadLine()); 
    double y = 0;

    if (x>0) y=Math.Pow(Math.Sin(x),2);
    else y=1-2*Math.Sin(Math.Pow(x,2));
}
//Проверка числа на деление на 3
void ex2()
{
    Console.WriteLine("Введите натуральное число");
    int Num = Convert.ToInt32(Console.ReadLine()); 
    int sum = 0;
    while (Num>0)
    { 
        int b=Num%10;
        sum = sum + b;
        Num = Num/10;
    }
    if (sum%3==0) Console.WriteLine("Число кратно трем");
    else Console.WriteLine("Число не кратно трем");
}
//Нахождение в числе 4 или 7
void ex3()
{
    Console.WriteLine("Введите натуральное число");
    int Num = Convert.ToInt32(Console.ReadLine()); 
    int b7=0;
    int b4=0;
    while (Num>0)
    { 
        int b=Num%10;
        if (b==7) b7=b7+1;
        if (b==4) b4=b4+1;
        Num = Num/10;
    }
    Console.WriteLine($"В числе есть семерки:{b7}");
    Console.WriteLine($"В числе есть четверки:{b4}");
}





//Дополнительные задания повышенной сложности
    
//Определение оптимального маршрута 
void HARDex1()
{
    Console.WriteLine("Введите номер координатной четверти");
    int x = Convert.ToInt32(Console.ReadLine());

    Random rand = new Random();
    double x1 = 0;
    double x2 = 0;
    double x3 = 0;
    double y1 = 0;
    double y2 = 0;
    double y3 = 0;
    //Задание координат точек
    if (x==1)
    {
        x1 = rand.Next(1,100);
        x2 = rand.Next(1,100);
        x3 = rand.Next(1,100);
        y1 = rand.Next(1,100);
        y2 = rand.Next(1,100);
        y3 = rand.Next(1,100);
    }
    else if (x==2) 
    {
        x1 = rand.Next(-100,-1);
        x2 = rand.Next(-100,-1);
        x3 = rand.Next(-100,-1);
        y1 = rand.Next(1,100);
        y2 = rand.Next(1,100);
        y3 = rand.Next(1,100);
    }
    else if (x==3) 
    {
        x1 = rand.Next(-100,-1);
        x2 = rand.Next(-100,-1);
        x3 = rand.Next(-100,-1);
        y1 = rand.Next(-100,-1);
        y2 = rand.Next(-100,-1);
        y3 = rand.Next(-100,-1);
    }
    else if (x==4) 
    {
        x1 = rand.Next(1,100);
        x2 = rand.Next(1,100);
        x3 = rand.Next(1,100);
        y1 = rand.Next(-100,-1);
        y2 = rand.Next(-100,-1);
        y3 = rand.Next(-100,-1);
    }
    else Console.WriteLine("не является координатной четвертью");
    Console.WriteLine($"Точка А с координатам ({x1},{y1})");
    Console.WriteLine($"Точка B с координатам ({x2},{y2})");
    Console.WriteLine($"Точка C с координатам ({x3},{y3})");
    
    double r1 = 0;
    double r2 = 0;
    double r3 = 0;
    //Нахождение радиус-векторов от начала координат
    r1 = Math.Round(Math.Sqrt(x1*x1 +y1*y1),2);
    r2 = Math.Round(Math.Sqrt(x2*x2 +y2*y2),2);
    r3 = Math.Round(Math.Sqrt(x3*x3 +y3*y3),2);
    
    Console.WriteLine($"Раиус-вектор точки А ({r1})");
    Console.WriteLine($"Раиус-вектор точки B ({r2})");
    Console.WriteLine($"Раиус-вектор точки C ({r3})");
    //Нахождение и вывод оптимального маршрута
    double maxR;
    double midR =0;
    double minR;

    if (r1>r2)
    {
        if (r1>r3) maxR = r1;
        else maxR= r3;
    }
    else if (r2>r3) maxR = r2;
    else maxR = r3;

    if (r1<r2)
    {
        if (r1<r3) minR = r1;
        else minR= r3;
    }
    else if (r2<r3) minR = r2;
    else minR = r3;

    if (minR==r1 && maxR==r2) midR = r3;
    else if (minR==r1 && maxR==r3) midR = r2;
    else if (minR==r2 && maxR==r1) midR = r3;
    else if (minR==r2 && maxR==r3) midR = r1;
    else if (minR==r3 && maxR==r1) midR = r2;
    else if (minR==r3 && maxR==r2) midR = r1;

    Console.WriteLine($"Ближняя точка {minR}");
    Console.WriteLine($"Средняя точка {midR}");
    Console.WriteLine($"Дальняя точка {maxR}");

    double minX = 0;
    double minY = 0;

    double midX = 0;
    double midY = 0;

    double maxX = 0;
    double maxY = 0;

    if (minR==r1 && maxR==r2)
    {
    minX = x1;
    minY = y1;
    midX = x3;
    midY = y3;

    maxX = x2;
    maxY = y2;
    }
    else if (minR==r1 && maxR==r3) 
    {
    minX = x1;
    minY = y1;
    midX = x2;
    midY = y2;
    maxX = x3;
    maxY = y3;
    }
    else if (minR==r2 && maxR==r1) 
    {
    minX = x2;
    minY = y2; 
    midX = x3;
    midY = y3;
    maxX = x1;
    maxY = y1;
    }
    else if (minR==r2 && maxR==r3) 
    {
    minX = x2;
    minY = y2; 
    midX = x1;
    midY = y1;
    maxX = x3;
    maxY = y3;
    }
    else if (minR==r3 && maxR==r1) 
    {
    minX = x3;
    minY = y3; 
    midX = x2;
    midY = y2;
    maxX = x1;
    maxY = y1;
    }
    else if (minR==r3 && maxR==r2) 
    {
    minX = x3;
    minY = y3; 
    midX = x1;
    midY = y1;
    maxX = x2;
    maxY = y2;
    }

    Console.WriteLine($"Маршрут должен проходить по точкам:1.({minX},{minY})  2.({midX},{midY})  3.({maxX},{maxY})");
}

HARDex1();