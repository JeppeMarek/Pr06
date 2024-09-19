namespace Pr06;

class Program
{
    static void Main(string[] args)
    {
        /*
        //opgave 4.1A
        int groupMember = 1;
        int groupSize = 6;
        int ageJeppe = 26;
        int ageJonas = 26;
        int ageBo = 51;
        int ageMarcus = 26;
        int ageSimon = 32;
        int ageNoah = 25;
        int averageAge = (ageJeppe + ageJonas + ageMarcus + ageSimon + ageNoah)/6;
        string message = "Group member: {0} is: {1} years old";
        Console.WriteLine(message,groupMember,ageJeppe);
        Console.WriteLine(message,groupMember+1,ageJonas);
        Console.WriteLine(message,groupMember+2,ageBo);
        Console.WriteLine(message,groupMember+3,ageMarcus);
        Console.WriteLine(message,groupMember+4,ageSimon);
        Console.WriteLine(message,groupMember+5,ageNoah);
        
        message = $"The average age is: {averageAge} years old";
        Console.WriteLine(message);
        */ 
       
        // Opgave 4.2A
        // Beder om input til gruppe størrelse og tjekker om det er en int
        Console.WriteLine("Enter size of group:");
        int groupSize = 0;
        try
        {
            groupSize = int.Parse(Console.ReadLine());
        }
        catch (FormatException e)
        {
            Console.WriteLine("Please eneter a number");
        }
       // variabler initialiseres
        int[] groupMember = new int[groupSize];
        int[] ageOfMember = new int[groupSize];
        int totalAge = 0;
        int averageAge = totalAge / groupSize;
        // Spørger om input til hver medlems alder og tjekker om det er int
        for (int i = 0; i < ageOfMember.Length; i++)
        {
            groupMember[i] = i;
            Console.WriteLine("Enter age of group member: {0}", groupMember[i]);
            try
            {
                ageOfMember[i] = int.Parse(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Please enter a whole number");
            }
            Console.WriteLine($"Group member: {groupMember[i]} is {ageOfMember[i]}");
            // Plusser hver gruppes alder sammen og dividerer dem med gruppe størrelse for at få gennemsnitsalderen
            for (int size = i; size < groupSize; size++)
            {
                totalAge += ageOfMember[size];
                averageAge = totalAge / groupSize;
            }
            Console.WriteLine($"Average age: {averageAge}");
            
        }
        // Spørger efter hvilken alder brugeren vil søge efter i gruppen
        {
            Console.WriteLine("Enter age that you want to find in group age");
            int sameAge = int.Parse(Console.ReadLine());
            for (int j = 0; j < ageOfMember.Length; j++)
            {
                if (sameAge == ageOfMember[j])
                {
                    Console.WriteLine("Group member: {0} has the age: ({1}) that you want to find in group age",
                        groupMember[j], ageOfMember[j]);
                    // stopper loopet når første medlem er fundet med alderen
                    break;
                }
                // Når den har kørt hele gruppen igennem og ikke har fundet alderen der ledes efter skriver den til console
                if (j == groupSize - 1)
                {
                    Console.WriteLine("No group member found with that age");
                }
            } 
        }
        
    }

    }