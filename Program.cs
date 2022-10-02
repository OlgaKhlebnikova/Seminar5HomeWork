//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine("Какую задачу вы хотите проверить (1/2/3/4)? ");
int Task = Convert.ToInt32(Console.ReadLine());

if(Task == 1){
    Task1();
}
else if(Task == 2){
    Task2();
}
else if(Task == 3){
    Task3();
}

else if(Task == 4){
    Task4();
} 

void Task1()
{

    Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
    Console.WriteLine();
    int[] FillArray(int size, int min, int max)
    {
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
    }
    int FindNum(int []inputarray)
    {
        int counter = 0;
        for (int i = 0; i < inputarray.Length ; i++)
        {
          if (inputarray[i] % 2 == 0)
            {
            counter++;
            }
            
        }
             
    return counter;

    }

    int[]newarray = FillArray(15,100,999);
    Console.WriteLine($"Количество четных чисел в массиве [{ String.Join(",",newarray)}] равно {FindNum(newarray)}." );
    Console.WriteLine();
} 

void Task2()
{
/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
    Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine();
    int[] FillArray(int size, int min, int max)
    {
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
    }
    int FindSum(int []inputarray)
    {
        int sum = 0;
        for (int i = 0; i < inputarray.Length ; i++)
        {
          if (i % 2 > 0)
            {
            sum = sum + inputarray[i];
            }
            
        }
             
    return sum;

    }

    int[]newarray = FillArray(6,-5,20);
    Console.WriteLine($"Сумма элементов на нечетных позициях в массиве [{ String.Join(",",newarray)}] равно {FindSum(newarray)}." );
    Console.WriteLine(); 
} 

void Task3()
{
/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
     Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    Console.WriteLine();
    int[] FillArray(int size, int min, int max)
    {
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
    }
    int FindSum(int []inputarray)
    {
        int sum = 0;
        for (int i = 0; i < inputarray.Length ; i++)
        {
          if (i % 2 > 0)
            {
            sum = sum + inputarray[i];
            }
            
        }
             
    return sum;
    }

    int FindMax(int []arrayMax)
    {
    int max = arrayMax[0];
    for (int i = 1; i < arrayMax.Length; i++)
        {
         if (max < arrayMax[i])
             max = arrayMax[i];
        }
    return max;
    }


    int FindMin(int []arrayMin)
    {
    int min = arrayMin[0];
    for (int i = 1; i < arrayMin.Length; i++)
        {
         if (min > arrayMin[i])
             min = arrayMin[i];
        }
    return min;
    }

    int[]newarray = FillArray(6,5,20);
    Console.WriteLine("Массив [" + String.Join(",",newarray)+ "]" );
    Console.WriteLine("Максимальный элемент " + FindMax(newarray)); 
    Console.WriteLine("Минимальный элемент " + FindMin(newarray)); 
    Console.WriteLine($"Разница между  максимальным и минимальным элементами в массиве [{ String.Join(",",newarray)}] равна {FindMax(newarray)-FindMin(newarray)}." );
    Console.WriteLine();  
} 

void Task4()
{
/* Задайте одномерный массив, заполненный случайными числами. 
Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат 
сравнения средних арифметических. */
    Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.");
    Console.WriteLine();
    int[] FillArray(int size, int min, int max)
    {
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
    }
    int[]newarray = FillArray(15,1,99);
    Console.WriteLine("[" + String.Join(",",newarray)+ "]");

    int evenLengh = 0;
    int oddLengh = 0;
   

    foreach(int element in newarray)
    {

        if ((element % 2 == 0) && (element != 0))
            {
                evenLengh++;
            }
        else
        {
            oddLengh++;
        }
   
    }
    //Console.WriteLine("Всего положительных чисел в массиве:" + evenLengh);
    //Console.WriteLine("Всего отрицательных чисел в массиве:" + oddLengh);
   

    int[] new_arrayEven = new int[evenLengh]; 
    int[] new_arrayOdd = new int[oddLengh];
    int i =0;
    int j=0;
    foreach(int element in newarray)
    {

        if ((element % 2 == 0) && (element != 0))
            {
                new_arrayEven[i]=element;
                i++;
            }
        else
            {
            new_arrayOdd[j]=element;
            j++;
            }
   
    }
    //Console.WriteLine("Массив четных чисел [" + String.Join(",",new_arrayEven)+ "]");
    //Console.WriteLine("Массив нечетных чисел [" + String.Join(",",new_arrayOdd)+ "]");
   
    int FindSum(int []inputarray)
    {
        int sum = 0;
        for (int i = 0; i < inputarray.Length ; i++)
        {
          
            sum = sum + inputarray[i];
                       
        }
             
    return sum;
    }
    //Console.WriteLine("Cреднее арифм. значений элементов массива с чётными числами " + FindSum(new_arrayEven)/evenLengh);
    //Console.WriteLine("Cреднее арифм. значений элементов массива с нечётными числами " + FindSum(new_arrayOdd)/oddLengh);

    if (FindSum(new_arrayEven)/evenLengh > FindSum(new_arrayOdd)/oddLengh)
        Console.WriteLine("Cреднее арифм. значений элементов массива с чётными числами > среднего арифм. значений элементов с нечётными числами");
    else if (FindSum(new_arrayEven)/evenLengh < FindSum(new_arrayOdd)/oddLengh)
        Console.WriteLine("Cреднее арифм. значений элементов массива с чётными числами < среднего арифм. значений элементов с нечётными числами");
    else
    {
        Console.WriteLine("Cреднее арифм. значений элементов массива с чётными числами = среднего арифм. значений элементов с нечётными числами");
    }
}