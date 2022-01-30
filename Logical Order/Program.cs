
bool isTrue = true;
bool isFalse = !isTrue;

bool b1 = !true;
bool b2 = !false;

bool b3 = true;
b3 = !b3;
b3 = !b3;


/******************
 * Welcome if age >=40 
 * or customer paid
 * and does NOT live in Eilat
 * ***************/

int age = 90;
bool ageIsOver40 = age >= 40;

bool isPaid = false;

string city = "Eilat";
bool doesNotliveInEilat = !(city == "Eilat");

bool canEnter;
canEnter = ageIsOver40 || isPaid && doesNotliveInEilat;
canEnter = ageIsOver40 || (isPaid && doesNotliveInEilat);//Same as the line above

//canEnter = (ageIsOver40 || isPaid) && doesNotliveInEilat;

while (canEnter)
{ 
    //Welcome
}

//Rest of code.............





