// hangman game

/*
we will come up with a word.
user will try to guess letters in the word.
there should be multiple words to work with.
we should see how many trys we have left before game over.
we should be able to quit the game.
we could allow a difficulty on how long or difficult the words are for the user to guess.

*/

/*
user stories:
 -user should be able to see how many letters the word has.
 -user should be able to see how many guesses they have left.
 -user should be able to see the history of letters they have already guessed.
 -user should be able to see the word's letters that have been used.
 -user should be able to see when the game is over.
 -user should be able to play again.
 -
*/

/*
mvp: minimum viable product
 -a word should be generated.
 -we should compare letters from user if it is in our generated word.
 -user should see if the letter is in the word or not.
 -users should be able to see where the correct letters are in the word.
 --the answer should be a real word.
*/

string[] words = { "hangman", "test", "tree", "red", "computer", "dog" };
Random rand = new Random();

string word = words[rand.Next(words.Length)];
int guessesLeft = 7;
string currentGuess = "";   //keeps track
foreach (char c in word) currentGuess += ' ';
while (true)
{
    HangMan.printGameHeader(guessesLeft, currentGuess);
    string guessRead = Console.ReadLine();
    if (guessRead.Length > 1)
    {
        Console.WriteLine("Invalid. Please Input a single letter.");
        continue;
    }
    string newCurrent = "";
    bool success = false;
    for (int i = 0; i < word.Length; i++)
    {
        if (word.ElementAt(i) == guessRead.ElementAt(0))
        {
            newCurrent += guessRead.ElementAt(0);
            success = true;
        }
        else
        {
            newCurrent += ' ';
        }
    }
    currentGuess = HangMan.CombinedGuesses(currentGuess, newCurrent);

    if (success)
    {
        if (!currentGuess.Contains(' '))
        {
            Console.WriteLine("Congratulations, you guessed the word!");
            break;
        }
    }
    else
    {
        guessesLeft--;
        if (guessesLeft == 0)
        {
            Console.WriteLine("You ran out of guesses!");
            break;
        }
    }
}

public class HangMan
{
    public static void printGameHeader(int guessesLeft, string currentGuess)
    {
        Console.WriteLine("You have " + guessesLeft + " guesses left.");
        Console.Write("the current string is: ");
        foreach (char c in currentGuess)
        {
            if (c == ' ')
            {
                Console.Write("_");
            }
            else { Console.Write(c); }
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public static string CombinedGuesses(string currentGuess, string newCurrent)
    {
        string output = "";
        for (int i = 0; i < currentGuess.Length; i++)
        {
            if (newCurrent.ElementAt(i) != ' ')
            {
                output += newCurrent.ElementAt(i);
            }
            else
            {
                output += currentGuess.ElementAt(i);
            }
        }
        return output;
    }
}
