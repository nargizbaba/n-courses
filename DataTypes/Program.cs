//server side
string s_username = "admins";
string s_password = "who";
bool isLogged = false;
int tryCount = 0;
int chancesLeft = 0;
const int MAX_TRY_COUNT = 17;

//client side
if (isLogged == false)
{
    LOG:
    Console.WriteLine("enter username");
    string c_username = Console.ReadLine();
    Console.WriteLine("enter password");
    string c_password = Console.ReadLine();

    if (c_username == s_username && c_password == s_password)
    {
        isLogged = true;
        Console.WriteLine("You logged in successfully!");
    }
    else
    {
        Console.WriteLine("Try again");
        tryCount++;
        chancesLeft = MAX_TRY_COUNT - tryCount;
        Console.WriteLine("you have chances: " + chancesLeft);
        if (tryCount == MAX_TRY_COUNT)
        {
            Console.WriteLine("you banned");
        }
        goto LOG;
    }
}




