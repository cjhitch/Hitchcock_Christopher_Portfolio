using System;

namespace Hitchcock_Christopher_MadLibs
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
            Christopher Hitchcock
            Scalable Database Infrastructure           
            MDV2330-O Section 01
            March 10th, 2019
            MadLibs          
            */

            //Get User's Name and welcome to the game
            Console.WriteLine("Please Type Your Name and Press Enter");
            string userName = Console.ReadLine();
            //Capitalizing the User name always
            userName = char.ToUpper(userName[0]) + userName.Substring(1);
            Console.WriteLine("Welcome to Our MadLibs Story Game " + userName);
            Console.WriteLine("We will ask for a series of responses, once you have answered all of them, we'll have a fun story for you.");
            Console.WriteLine("We hope you enjoy!");

            //Ask for animal and store in variable
            Console.WriteLine("Please enter a type of animal and press enter");
            string animalResp = Console.ReadLine();
            //Console.WriteLine(animalResp);

            //Ask for name and store in variable
            Console.WriteLine("Please enter a name and press enter");
            string nameResp = Console.ReadLine();
            //Capitalizing the name of the character's name
            nameResp = char.ToUpper(nameResp[0]) + nameResp.Substring(1);
            //Console.WriteLine(nameResp);

            //Ask for adjective and store in variable
            Console.WriteLine("Please enter an adjective and press enter (this is decribing your animal)");
            string adjResp = Console.ReadLine();
            //Capitalizing the adjective to be used when a title
            string adjRespCap = char.ToUpper(adjResp[0]) + adjResp.Substring(1);
            //Console.WriteLine(adjResp);

            //Ask for food item and store in variable
            Console.WriteLine("Please enter a food item and press enter");
            string foodResp = Console.ReadLine();
            //Capitalizing the adjective to be used when a title
            string foodRespCap = char.ToUpper(foodResp[0]) + foodResp.Substring(1);
            //Console.WriteLine(foodResp);

            //Ask for year, store in variable and convert string to number
            Console.WriteLine("Please enter a year and press enter");
            string yearResp = Console.ReadLine();
            double yearNum = double.Parse(yearResp);
            //Console.WriteLine(yearNum*2);

            //Ask for a cost, store in variable and convert string to number
            Console.WriteLine("Please enter a cost and press enter");
            string costResp = Console.ReadLine();
            double costNum = double.Parse(costResp);
            //Console.WriteLine(costNum*2);

            //Ask for random number, store in variable and convert string to number
            Console.WriteLine("Please enter a random number and press enter");
            string randResp = Console.ReadLine();
            double randNum = double.Parse(randResp);
            //Console.WriteLine(randNum *2);

            //Create new array using the number variables the guest provided
            double[] numArray = new double[] {yearNum, costNum, randNum};
            //Console.WriteLine(numArray[0]);
            //Console.WriteLine(numArray[1]);
            //Console.WriteLine(numArray[2]);

            Console.Write("The year was " + numArray[0] + " A.D. on the planet Exo-homarcee-itis Ven IV, and the world was a very different place. In fact, at that time a gallon of milk was only $" + numArray[1] + ". This is where our fearless hero enters the picture. Meet " + nameResp + " the " + adjRespCap + ". " + nameResp + " was a member of the race of " + animalResp + "s that filled the planet of Exo-homarcee-itis Ven IV. Now " + nameResp + " wasn't always " + adjResp + ", in fact, this was a relatively new development in our story. " + nameResp + " was considered the laughing stock of the scientific community as a failed scientist in the art of " + foodResp + ". One day, not too long ago, while " + nameResp + " was working on the newest attempt at Cadbury Creme Egg filled " + foodResp + ", existence on this planet was forever changed as we now know it. Unbenownst to " + nameResp + ", "+ nameResp +" had mixed the exact ingredients we now know creates a portal through time itself! With this accidental discovery, " + nameResp + " was sucked through the portal " + numArray[2] + " years back in time. Only then did " + nameResp + " meet the Old Masters of the " + foodRespCap + " Chef Clan. It was only in that 27 minutes of exhaustive research and studying with the " + foodRespCap + " Chef Clan, that " + nameResp + " forever was changed, as " + nameResp + " was dubbed " + nameResp + " The " + adjRespCap + ", the highest achievable title for a " + animalResp + ". Those 27 minutes flew by in what seemed like only minutes. When " + nameResp + " had learned everything that could be learned from the " + foodRespCap + " Chef Clan, " + nameResp + " stirred the concoction again, to travel forward again to the year " + yearResp + " A.D. When " + nameResp + " shared everything about the " + foodResp + " recipes with the scientific community, " + nameResp + " finally became a respected member of the scientific community, and since that day has forever been remembered as " + nameResp + " The " + adjRespCap + ". The planet of " + animalResp + "s will always remember that day when " + foodResp + " were finally perfected and became the most amazing food a " + animalResp + " has ever known. Where will " + nameResp + " The " + adjRespCap + " go next?!");

            /*
            Utilized consoles to ensure that the variables were outputting the correct way.
            They were detrimental to the story and have been commented out in case needed for future.
             */

        }
    }
}
