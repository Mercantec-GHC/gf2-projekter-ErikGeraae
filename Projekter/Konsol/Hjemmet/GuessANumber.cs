namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {

            Random simonHjerne = new Random();
            int simonTal = simonHjerne.Next(1, 1000000);
            Console.WriteLine($"Pssst, Simon tænker måske på tallet: {simonTal}");

        }
    }
}
    