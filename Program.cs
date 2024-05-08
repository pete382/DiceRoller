using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

// Dice Roller Lab


string rollAgain = ""; 
//number of sides

bool again = true;
while (again)
{
    Console.WriteLine("Please Enter the number sides you wouLd you like to roll?");



    int max = -1;
    int Die_1 = -1;
    int Die_2 = -1;
    string win = "";


    while (int.TryParse(Console.ReadLine(), out max) == false)
    {

        Console.WriteLine($"Please enter a whole number. Try again.");
    }




    if (max != 6)

    {

        Die_1 = GetRandomNumber(1, max);
        Die_2 = GetRandomNumber(1, max);
        Console.WriteLine($"You rolled {Die_1} and {Die_2} !");


        again = false;

    }

    else if (max == 6)

    {

        Die_1 = GetRandomNumber(1, max);
        Die_2 = GetRandomNumber(1, max);
        Console.WriteLine($"You rolled {Die_1} and {Die_2} !!!!");
        Console.WriteLine(winCRAPS(Die_1,Die_2));
        Console.WriteLine(boxSnakeAce(Die_1,Die_2));

        again = false;

    }

    else
    {

        Console.WriteLine("Geez dog, I don't know what you've been smoking!");
        again = true;
    }
    
    while (rollAgain == "")
    {

        Console.WriteLine("Do you want to roll again ? Type 'Y' for yes and 'N' for no.");
        string response = Console.ReadLine();
        if (response.ToLower().Trim() == "y")
        { again = true; break; }
        else if (response.ToLower().Trim() == "n")
        { break;}
        else 
        { Console.WriteLine("Please enter a valid letter."); }
    }


 //end of while loop

}





//Method Random Die 1


static int GetRandomNumber(int min, int max)

{
    
    {
        return

        new Random().Next(1,max);
    }
}



//Method associated with totals

static string winCRAPS(int num1, int num2)
{
    if (num1 + num2 == 7 || num1 + num2 == 11)
    {
        string T = "You Win!";
        return T;
    }

    else if (num1 + num1 == 2 || num1 + num2 == 3 || num1 + num2 == 12)
    {
        string T = "Damn Dude, you crapped out!!!";
        return T;
    }
    else
    {
        return "";
    }
}



//Methods associated with matches

static string boxSnakeAce(int num1, int num2)
{
        if (num1 == 6 && num2 == 6)
        {
            string T = "BOX CARS! Dude, what is up...?";
            return T;
        }

    else if (num1 + num2 == 2)
    {
        string T = "Snake Eyes! Dude, what is up...?";
        return T;
    }
    else if (num1 + num2 == 3)
    {
        string T = "Ace Deuce! Yo, Yo, Yo man what is up...?";
        return T;
    }

    else
        {
            return "";
        }


}




