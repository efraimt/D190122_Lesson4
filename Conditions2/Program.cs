
/******************
 * Welcome if age >=40 
 * and customer paid
 * and does NOT live in Eilat
 * ***************/

int age = 54;
bool isPaid = bool.Parse("false");
string city = "Eilat";

bool isOver40 = age >= 40;
bool doesNotLiveInEilat = city != "Eilat";

bool canEnter;
canEnter = isOver40 && isPaid && doesNotLiveInEilat;

if (canEnter)
{
    //Welcome...
}
else
{
    if (city == "Eilat")
    {
        //Giv benefits
    }
    else
    {
        //Sorry
    }
}

//Rest of code.............


