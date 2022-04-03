using System;

namespace BelaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Take the user input
                const int cardsPerHand = 4;
                const char space = ' ';
                string input;
                string[] inputs;
                string numberOfHands;
                string dominantSuit;
                int numOfHands;
                int index;
                int points = 0;

                // Read the first line with number of hands and the dominant suit
                input = Console.ReadLine();

                // Split it to two on the space
                inputs = input.Split(space);

                // Now save as another variable so we can remember by name easier
                numberOfHands = inputs[0];
                dominantSuit = inputs[1];

                // Parse the token input of numberOfHands into the variable numOfHands 
                numOfHands = int.Parse(numberOfHands);

                // Create a for loop that repeats based on the calculation of numOfHands * cardsPerHand
                for ( index = 0; index < numOfHands * cardsPerHand; index++ )
                {
                    //Define variables and create an array with values
                    const int card=0;
                    const int suit=1;
                    int cardNumber;
                    int[] dominant = { 11, 4, 3, 20, 10, 14, 0, 0 };
                    int[] notDominant = { 11, 4, 3, 2, 10, 0, 0, 0 };
                    string cardList = "AKQJT987" ;

                    // Read one line with the card and suit
                    input = Console.ReadLine();

                    /*
                     * Get the card number by checking for card (position 0) in the input
                     * Card:     A K Q J T 9 8 7
                     * Position: 0 1 2 3 4 5 6 7
                    */
                    cardNumber = cardList.IndexOf(input.Substring(card, 1));

                    // If the dominant suit is equal to the suit given in the input then add the dominant points, if not add the not dominant points.
                    if ( input.Substring(suit,1) == dominantSuit )
                    {
                        points += dominant[cardNumber];
                    }
                    else
                    {
                        points += notDominant[cardNumber];

                    }
                }

                Console.WriteLine(points);
            }
            catch
            {
                Console.WriteLine("An error occured");
            

            }
        }
    }
}
