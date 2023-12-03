using Recent_Task;
#region FifthTask
Console.WriteLine("How many students are you willing to enroll?");
s1:
string stdNumber = Console.ReadLine();
bool message = int.TryParse(stdNumber, out int stdNmb);
if (!message)
{
    Console.WriteLine("The number of students should be whole number. Please add new one:");
    goto s1;
}

Student[] students = new Student[stdNmb];

// Loop to add students manually
for (int i = 0; i < stdNmb; i++)
{
    Console.WriteLine($"\nEnter details for Student {i + 1}:");

    // Get input from the user for each student
    students[i] = new Student
    {
        name = GetUserInput("Name"),
        surname = GetUserInput("Surname"),
        age = GetUserInput("Age"),
        specialty = GetUserInput("Specialty"),
        groupNo = GetUserInput("GroupNo")
    };
}


Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine($"You succesfully added {stdNmb} students");

foreach (var student in students)
{
    Console.WriteLine(student);
}

static string GetUserInput(string fieldName)
{
    Console.Write($"Enter {fieldName}: ");
    return Console.ReadLine();
}
#endregion


void firstTask()
{
    //1.İki ədəd verilib 
    // əgər bu iki ədədin cəmi cüt ədədirsə "Cəm cüt ədəddir"
    // deyilsə "Cəm tək ədəddir" yazı ekrana yazdırmaq
    // input: 3, 6
    // output:
    Console.Write("Add first number: ");
l2:
    string aStr = Console.ReadLine();
    bool firstMessage = int.TryParse(aStr, out int a);
    if (!firstMessage)
    {
        Console.WriteLine($"{aStr} should be a whole number. Please, add new one");
        goto l2;
    }
    Console.Write("Add second number: ");
l3:
    string bStr = Console.ReadLine();
    bool secondMessage = int.TryParse(bStr, out int b);
    if (!secondMessage)
    {
        Console.WriteLine($"{bStr} should be a whole number. Please, add new one");
        goto l3;
    }

    int sum = a + b;

    if (sum % 2 == 0)
    {
        Console.WriteLine("sum is even");
    }
    else
    {
        Console.WriteLine("sum is odd");
    }
}
void secondTask()
{
    //2.Massivdə 10(on) ədəd saxlanılıb, bu ədədlərdən cüt olanları ekrana yazdırmaq
    int[] myNum = { 10, 20, 30, 40, 24, 55, 105, 28, 23, 33 };
    for (int i = 0; i < myNum.Length; i++)
    {
        if (myNum[i] % 2 == 0)
        {
            Console.WriteLine(myNum[i]);
        }

    }
}
void thirdTask()
{
    //3.Massivdə 10(on) ədəd saxlanılıb
    //  bu ədədlərdən tək olanların cəmini tapıb ekrana yazdırmaq

    int sum = 0;
    int[] myNum = { 10, 20, 30, 40, 24, 55, 105, 28, 23, 33 };
    for (int i = 0; i < myNum.Length; i++)
    {
        if (myNum[i] % 2 != 0)
        {
            sum += myNum[i];

        }

    }
    Console.WriteLine(sum);
}
void fourthTask()
{
    //4.Verilmish 4 reqemli ededin reqemlerinin cemini tap (əgər ədəd 4reqemlidirse yoxlamaq)     
    //     input: 3423                                    input: 34231
    //     output: 12                                        output: ədəd 4rəqəmli deyil

    Console.WriteLine("Add a whole number with four digits");
    l1:
    string aStr = Console.ReadLine();
    bool message = int.TryParse(aStr, out int a);

    if (!message)
    {
        Console.WriteLine($"{a} is not whole number! Please, add new one:");
        goto l1;
    }

    if (a >= 1000 && a <= 9999)
    {
        // Extract and print each digit
        int thousands = a / 1000;
        int hundreds = (a % 1000) / 100;
        int tens = (a % 100) / 10;
        int units = a % 10;

        int output = thousands + hundreds + tens + units;
        Console.WriteLine("Here is your result: " + output);

    }
    else
    {
        Console.WriteLine($"{a} should have four digits! Please, add new one:");
        goto l1;
    }

    void firstTask()
    {
        /*1.İki ədəd verilib əgər bu iki ədədin cəmi cüt ədədirsə "Cəm cüt ədəddir" deyilsə "Cəm tək ədəddir" yazı ekrana yazdırmaq
        input: 3, 6
        output:

        Cəm, yəni 9 tək ədəddir*/

        int firstNumber = 3;
        int secondNumber = 6;
        int sum = firstNumber + secondNumber;

        if (sum % 2 == 0)
        {
            Console.WriteLine($"{sum} is even");
        }
        else
        {
            Console.WriteLine($"{sum} is odd");
        }
    }
}
