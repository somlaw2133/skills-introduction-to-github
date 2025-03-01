public class ArrayNumbers
{

    //public int [] numbers;
    public void checkNumbers(int []Number)
    {

        foreach (int i in Number)
        {
            if(i%2==0)
            {
System.Console.WriteLine($"{i} is an even number");
            }
            else 
            {
                System.Console.WriteLine($"{i} is an odd number");
            }

        }


        
    }

}