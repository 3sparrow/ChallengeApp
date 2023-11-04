int number = 642426;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int zero = 0;
int one = 0;
int two = 0;
int three = 0;
int four = 0;
int five = 0;
int six = 0;
int seven = 0;
int eight = 0;
int nine = 0;


foreach (char z in letters)
{
    if (z == '0')
    {
        zero++;
    }
    else if (z == '1')
    {
        one++;
    }
    else if (z == '2')
    {
        two++;
    }
    else if (z == '3')
    {
        three++;
    }
    else if (z == '4')
    {
        four++;
    }
    else if (z == '5')
    {
        five++;
    }
    else if (z == '6')
    {
        six++;
    }
    else if (z == '7')
    {
        seven++;
    }
    else if (z == '8')
    {
        eight++;
    }
    else if (z == '9')
    {
        nine++;
    }



}
Console.WriteLine("Cyfr 0 jest " + zero);
Console.WriteLine("Cyfr 1 jest " + one);
Console.WriteLine("Cyfr 2 jest " + two);
Console.WriteLine("Cyfr 3 jest " + three);
Console.WriteLine("Cyfr 4 jest " + four);
Console.WriteLine("Cyfr 5 jest " + five);
Console.WriteLine("Cyfr 6 jest " + six);
Console.WriteLine("Cyfr 7 jest " + seven);
Console.WriteLine("Cyfr 8 jest " + eight);
Console.WriteLine("Cyfr 9 jest " + nine);