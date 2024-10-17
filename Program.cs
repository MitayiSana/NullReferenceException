namespace NullReferenceExceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s= null;
            try
            {
                if(s == null )
                {
                    throw new NullReferenceException();
                }
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Null Reference Exception");
            }

           
        }
    }
}
