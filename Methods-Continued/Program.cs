//////HOMEWORK///////

//Task 1: Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

string CheckDivisionByThreeAndSeven(int number)
{
    string message;

    if (number % 3 == 0 && number % 7 == 0)
    {
        message = $"{number} is divided by 3 and 7";
    }
    else
    {
        message = $"{number} is not divided by 3 and 7";
    }

    return message;
}

//string result1 = CheckDivisionByThreeAndSeven(21);
//Console.WriteLine(result1);



//Task 2: n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
int SumOfEvenNums(int num1, int num2)
{
    int sum = 0;

    if (num1 % 2 == 0 && num2 % 2 == 0)
    {
        sum = num1 + num2;
    }

    return sum;
}

//int result2 = SumOfEvenNums(4, 2);
//Console.WriteLine(result2);



//Task 3: Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

int CountOfOddNumbers(int n, int m)
{
    int count = 0;

    for (int i = n; i <= m; i++)
    {
        if (i % 2 != 0)
        {
            count++;
        }
    }

    return count;
}

//int result3 = CountOfOddNumbers(1, 10);
//Console.WriteLine(result3);



//Task 4: Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

int SumOfOddNumbers(int n, int m)
{
    int sum = 0;

    for (int i = n; i <= m; i++)
    {
        if (i % 2 != 0)
        {
            sum += i;
        }
    }

    return sum;
}

//int result4 = SumOfOddNumbers(1, 10);
//Console.WriteLine(result4);



//Task 5: Verilmish arrayin icindeki tek ededlerin cemini tapin.

int SumOfOddNumsInArray(params int[] numbers)
{
    int sum = 0;

    foreach (var number in numbers)
    {
        if (number % 2 != 0)
        {
            sum += number;
        }
    }

    return sum;
}

//int result5 = SumOfOddNumsInArray(1, 5, 4, 2, 7);
//Console.WriteLine(result5);



//Task 6: Verilmish arrayin icindeki cut ededlerin sayini tapin.

int CountOfEvenNumsInArray(int[] numbers)
{
    int count = 0;

    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

//int[] arr = { 5, 10, 2, 4 };
//int result6 = CountOfEvenNumsInArray(arr);
//Console.WriteLine(result6);



//Task 7: Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

string CheckPrime(int n)
{
    string message;

    bool isPrime = true;

    if (n < 2)
    {
        message = $"{n} is neither prime nor composite number";
    }
    else
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            message = $"{n} is a prime number";
        }
        else
        {
            message = $"{n} is a composite number";

        }
    }

    return message;
}

//string result7 = CheckPrime(6);
//Console.WriteLine(result7);



//Task 8: n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.
//Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.

string CheckPowerOfTwo(int n)
{
    string message;

    if (n <= 0)
    {
        message = "Number must be positive";
    }
    else
    {
        bool isPower = true;

        for (int i = 2; i < n; i *= 2)
        {
            if (n % i != 0)
            {
                isPower = false;
                break;
            }
        }

        if (isPower)
        {
            message = $"{n} is power of 2";
        }
        else
        {
            message = $"{n} is not power of 2";
        }
    }

    return message;
}

//string result8 = CheckPowerOfTwo(64);
//Console.WriteLine(result8);



//Task 9: Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab : 18).

int ProductOfArray(params int[] numbers)
{
    int product = 1;

    foreach (var number in numbers)
    {
        if (number >= 1 && number <= 20)
        {
            product *= number;
        }
    }

    return product;
}

//int result9=ProductOfArray(1, 3, 55, 6, 33);
//Console.WriteLine(result9);



// Task 10: Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

int SquareOfSum(params int[] numbers)
{
    int sum = 0;

    foreach (var number in numbers)
    {
        if (number % 2 == 0)
            sum += number;
    }

    return sum * sum;
}

//int result10 = SquareOfSum(1, 2, 3, 4, 5, 6);
//Console.WriteLine(result10);



// Task 11: temp qebul eden method yazirsiz. Return type olan method olmalidir.
// Method temp 20den boyukdurse isti, kicikdirse soyuq, beraberdirse mulayim mesajlarini qaytarsin.

string CheckTemperature(int temp)
{
    string message;

    if (temp == 20)
    {
        message = "mulayim";
    }
    else if (temp > 20)
    {
        message = "isti";
    }
    else
    {
        message = "soyuq";
    }

    return message;
}

//string result11 = CheckTemperature(20);
//Console.WriteLine(result11);



// Task 12: methoda a ve b ededleri gelecek, method a ve b arasindaki ededlerin sayini qaytarsin.

// Ededlerin her ikisi daxildir
int CountOfIntegers(int a, int b)
{
    int count;

    if (a == b)
    {
        count = 1;
    }
    else if (a > b)
    {
        count = a - b + 1;
    }
    else
    {
        count = b - a + 1;
    }

    return count;
}

//int result12 = CountOfIntegers(1, 5);
//Console.WriteLine(result12);



// Task 13: method reqemlerden ibaret 2 array qebul edecek, her iki arrayin elementlerinin cemini geri qaytarsin.

int SumOfArrayItems(int[] arr1, int[] arr2)
{
    int sum = 0;

    foreach (var item in arr1)
    {
        sum += item;
    }

    foreach (var item in arr2)
    {
        sum += item;
    }

    return sum;
}

//int[] arr1 = { 5, 2, 6, 2 };
//int[] arr2 = { 3, 5, 7, 20 };

//int result13 = SumOfArrayItems(arr1, arr2);
//Console.WriteLine(result13);



// Task 14: methoda eded gelir, hemin method ededin kvadratini geriye qaytarsin.

int Square(int a)
{
    return a * a;
}

//int result14 = Square(12);
//Console.WriteLine(result14);



// Task 15: methoda eded gelir, hemin method 1-den gelen edede qeder olan cut ededlerin cemini geri qaytarsin.

int SumOfEvenNumbers(int a)
{
    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }

    return sum;
}

//int result15 = SumOfEvenNumbers(5);
//Console.WriteLine(result15);

