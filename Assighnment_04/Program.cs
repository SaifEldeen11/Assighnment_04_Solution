using System.Xml;

namespace Assighnment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("enter a number ");
            //int num = int.Parse(Console.ReadLine());
            //if(num%3==0 && num%4==0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{

            //    Console.WriteLine("no");
            //}
            #endregion

            #region Q2
            //Console.WriteLine("enter a number (positive / negative )");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if(number > 0)
            //{
            //    Console.WriteLine("positive");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("zero");
            //}
            #endregion

            #region Q3
            //Console.WriteLine("enter 3 nums ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int max = num1;
            //int min = num1;
            //if (num2 > max)
            //{
            //    max = num2;
            //}
            //if (num3>max)
            //{
            //    max = num3;
            //}

            //if(num2 < min)
            //{
            //    min = num2;
            //}
            //if (num3 < min)
            //{
            //    min = num3;
            //}

            #endregion

            #region Q4
            //Console.WriteLine("enter a number ");
            //int number =Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion

            #region Q5
            //Console.WriteLine("enter a char ");
            //char ch = Convert.ToChar(Console.ReadLine());
            //if (ch=='a'||ch=='o'||ch=='u'||ch=='e'||ch=='i')
            //{
            //    Console.WriteLine("vowel");
            //}

            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion

            #region Q6
            //Console.WriteLine("enter a number ");
            //int number=Convert.ToInt32(Console.ReadLine());
            //for(int i =1;i<=number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q7
            //Console.WriteLine("enter a number ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("-----------"); // to make things clear 
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i+". "+i*number);
            //}
            #endregion

            #region Q8
            //Console.WriteLine("enter a number ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("--------------------");
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region Q9
            //Console.WriteLine("enter 2 nums ");
            //int Base = Convert.ToInt32(Console.ReadLine());
            //int Power = Convert.ToInt32(Console.ReadLine());
            //int result = 1;

            //for (int i = 0; i < Power; i++)
            //{
            //    result *= Base;
            //}
            //Console.WriteLine(result);

            #endregion

            #region Q10
            //Console.WriteLine("enter 5 grades (Max grade is 100 ) ");
            //int grade01 = Convert.ToInt32(Console.ReadLine());
            //int grade02 = Convert.ToInt32(Console.ReadLine());
            //int grade03 = Convert.ToInt32(Console.ReadLine());
            //int grade04 = Convert.ToInt32(Console.ReadLine());
            //int grade05 = Convert.ToInt32(Console.ReadLine());
            //int sum = grade01 + grade02 + grade03 + grade04 + grade05;
            //double average = sum / 5.0;
            //double persentage = (sum / 500) * 100;
            //Console.WriteLine("sum is :"+sum);
            //Console.WriteLine("the average is " + average);
            //Console.WriteLine("the persentage is " + persentage + "%");
            #endregion

            #region Q11
            //Console.WriteLine("enter a month number ");
            //int monthNumber=Convert.ToInt32(Console.ReadLine());    
            //switch(monthNumber)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("number of days is 31");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("number of days 30");
            //        break;
            //    case 2:
            //        Console.WriteLine("number of days is 28 or 29 in leap year");
            //        break;
            //    default:
            //        Console.WriteLine("invalid number ");
            //        break;
            //}
            #endregion

            #region Q12
            //Console.WriteLine("enter 2 nums ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the operation ");
            //char operation = Convert.ToChar(Console.ReadLine());
            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine("the result is " + (num1 + num2));
            //        break;
            //    case '-':
            //        Console.WriteLine("the result is " + (num1 - num2));
            //        break;
            //    case '*':
            //        Console.WriteLine("the result is " + (num1 * num2));
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine("the result is " + (num1 / num2));
            //        }
            //        else
            //        {
            //            Console.WriteLine("can't divide by zero");
            //        }
            //        break;
            //        case '%':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine("the result is " + (num1 % num2));
            //        }
            //        else
            //        {
            //            Console.WriteLine("can't divide by zero");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("invalid operation");
            //        break;
            //}
            #endregion

            #region Q13
            //Console.WriteLine("enter a string");
            //string? message = Console.ReadLine();
            //string reversedMessage = string.Concat(message?.Reverse());
            //Console.WriteLine(reversedMessage);
            #endregion

            #region Q14
            //Console.WriteLine("enter a number ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int reversed = 0;
            //while (number != 0) // 1234
            //{
            //    reversed = reversed*10+(number % 10);
            //    number /= 10;
            //}
            //Console.WriteLine(reversed);
            #endregion

        }

    }
}
