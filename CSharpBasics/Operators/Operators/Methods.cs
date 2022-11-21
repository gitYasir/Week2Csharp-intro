namespace Operators
{
    public class Methods
    {
        public static void Main( String[] args )
        {
            Console.WriteLine( GetStonesAndPounds( 156 ) );
        }
        public static int GetStones( int totalPounds )
        {
            return totalPounds / 14;
        }
        public static int GetPounds( int totalPounds )
        {
            return totalPounds % 14;
        }

        public static (int stones, int pounds) GetStonesAndPounds( int totalPounds )
        {
            return (GetStones( totalPounds ), GetPounds( totalPounds ));
        }
    }
}
