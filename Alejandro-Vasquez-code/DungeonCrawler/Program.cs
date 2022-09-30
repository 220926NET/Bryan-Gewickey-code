// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//i'm making a dungeon crawler game sort of similar to the git practice one we created earlier.
//my goal is to try to implement stuff we learned from the curriculum and label it if necessary.

/*program:
this is a dungeon crawler game sort of similar to the git practice one we created earlier.
the goal of this project is to implement stuff we learned from the curriculum and label it if necessary.
*/

/*user stories:
   - user should be able to move forward & back through the map.
   - user should be able to access their inventory.
   - user should be able to see their health.
   - user should be able to see/interact their environment.
   -
   -
   -
   -
   -
*/

/*mvp: minimum viable product:
   - user should be able to move forward & back through the map.
   - user should be able to access their inventory.
   - user should be able to see their health.
   - user should be able to see/interact their environment.
*/

/*additional features (to-add-later):
   - maybe a feature for holding a main weapon?
   - maybe allow player to change equipment?
   - money system with merchants...
   - different powered weapons & equipment...
*/

//my partner is bryan
//this is due tomorrow at 3:00pm est (we will be presenting)
/****************************************************************************************************/

//setting everything up...
List<string> dungeon = new List<string>() { "room 1", "room 2", "room 3" };   //dungeon layout
Player player = new Player();                                                 //instance of the player
string currentRoom = dungeon[0];                                              //starting room
bool dungeonCompleted = false;
string input;

//start of the game
while (!dungeonCompleted)
{
    Console.WriteLine("You are in " + currentRoom);
    input = Console.ReadLine();
    action(dungeon, ref currentRoom, input, dungeonCompleted);
}
Console.WriteLine("You completed the game!");
Console.WriteLine("end of the program...");

static void action(List<string> dungeon, ref string currentRoom, string input, bool dungeonCompleted)

{
    if (currentRoom == "room 1")
    {
        switch (input)
        {
            case "a":
                Console.WriteLine("you moved into " + dungeon[1]);
                currentRoom = dungeon[1];
                Console.WriteLine("you are currently in " + currentRoom);
                break;
            default:
                Console.WriteLine("you did nothing...");
                break;
        }
    }
    else if (currentRoom == "room 2")
    {
        switch (input)
        {
            case "a":
                Console.WriteLine("you moved into " + dungeon[2]);
                currentRoom = dungeon[2];
                break;
            case "b":
                Console.WriteLine("you moved into " + dungeon[1]);
                currentRoom = dungeon[1];
                break;
            default:
                Console.WriteLine("you did nothing...");
                break;
        }
    }
    else if (currentRoom == "room 3")
    {
        switch (input)
        {
            

            case "a":
                Console.WriteLine("you beat the dungeon!");
                dungeonCompleted = true;
                break;
            case "c":
                Console.WriteLine("you moved into " + dungeon[1]);
                currentRoom = dungeon[1];
                break;
            case "f":
                 Console.WriteLine("The room you have just entered is dank and musty, filled to cobwebs. You hear a low rumbling and a shape appears on the opposite side of the room, blocking the only other door. It materializes into a tall, hulking monster, dripping with something wet and viscous. It makes a noise somewhat like a low chuckle as it notices you.");
                for (int i = 0; i < 11; i++)
                {
                Random rand = new Random();
                // List<int> hitCount = new List<int> ();
                string[] fightText = {"Successful hit! The monster takes 10 damage.", "Miss! The monster dodged.", "Oh no! The monster hit you. You take 10 damage." };
                int randomNumber = rand.Next(0, 3);
                string fightSeq = fightText[randomNumber];
                Console.WriteLine("Random number: " + i);
                } 
                Console.WriteLine("you beat the dungeon!");
                dungeonCompleted = true;
                break;
            default:
                Console.WriteLine("you did nothing...");
                break;
        }
    }
    else
    {
        // shouldn't be able to get here...???
    }
}
public class Player  //simple player class
{
    public Player()
    {
        List<string> inventory = new List<string>() { "knife" };
        int playerHealth = 100;
        int playerStrength = 100;
    }
}
public class Slime   //simple slime class
{
    int monsterHealth = 100;
    int montserStrength = 25;
}