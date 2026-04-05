using TP_MODUL6_103022400048;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track = new SayaMusicTrack("Lagu Uji");

        for (int i = 0; i < 1000; i++)
        {
            track.IncreasePlayCount(1000000);
        }

        track.PrintTrackDetails();
    }
}
