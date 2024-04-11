/* 1. 2d Array 6 x 8; Rows x Seats filled with 0s
 * 2. User quit input Do-While loop
 * 3. User enter Row# and Seat#
 * 4. Replace location of RowxSeat with a 1
 * 5. Display the Seats - For Statements
 */

int[,] seatChart = new int[6, 8] // [Row, Seat]
{
    {0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0},
};

bool quit = false;
int rowNum;
int seatNum;
int purchased = 0;

do 
{
    do
    {
        Console.WriteLine("Row Number? 1 - 6");
        rowNum = Convert.ToInt32(Console.ReadLine()) - 1;
    } while (rowNum < 0 || rowNum > 5);

    do
    {
        Console.WriteLine("Seat Number? 1 - 8");
        seatNum = Convert.ToInt32(Console.ReadLine()) - 1;
    }while (seatNum < 0 || seatNum > 7);

    if (seatChart[rowNum, seatNum] == 1)
    {
        Console.WriteLine("Seat Taken. Please Choose Another Seat.");
    }
    else
    {
        Console.WriteLine("Seat Purchased.");
        purchased++;
        seatChart[rowNum, seatNum] = 1;
    }

    Console.WriteLine("Would you like to purchase additional seats? Y or N");
    string input = "";
    input = Console.ReadLine().ToUpper();
    switch (input)
    {
        case "N":
            Console.WriteLine("Thank you. Have a nice day!");
            quit = true;
            break;
        case "Y":
            quit = false;
            break;
        default:
            Console.WriteLine("Invalid Response. Exiting Application");
            Console.ReadLine();
            quit = true;
            break;
    }

} while (quit == false);

Console.Clear();
Console.WriteLine("New Seating Chart");
Console.WriteLine($"Number of Seats Purchased: {purchased}");
for (int i = 0; i <= 5; i++) //outer loop - Chooses which Row in the seatChart
{
    for (int j = 0; j <= 7; j++) //innerloop - seat number
    {
        Console.Write(" -" + seatChart[i, j] + "-");
    }
    Console.WriteLine();
}