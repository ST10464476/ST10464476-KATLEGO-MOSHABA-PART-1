using System.Media;

public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("assets/greeting.wav");
            player.PlaySync(); // waits until done
        }
        catch
        {
            Console.WriteLine("⚠️ Audio file could not be played.");
        }
    }
}