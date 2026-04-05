using TP_MODUL6_103022400048;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack track = new SayaMusicTrack("Lagu Favorit");

        track.IncreasePlayCount(10);
        track.PrintTrackDetails();
    }
}
