using System;

public class BreathingActivity : Activity
{
    private int _in = 4;
    private int _out = 6;

    public BreathingActivity() : base("BREATHING ACTIVITY", "Relax by breathing slowly") { }   //longer description

    public override void Start()
    {
        base.DisplayStartingMessage();
        Breathe();
        base.DisplayEndingMessage();
        base.ReturnToMenu();
    }

    private void Breathe()  
    {
        int repeat = _userDuration / (_in + _out);

        for (int i = 0; i < repeat; i++)
        {
            Console.Write("\nBREATHE IN...  ");   
            Countdown(_in);   //run for 4 seconds

            Console.Write("BREATHE OUT...  ");   
            Countdown(_out);   //run for 6 seconds
        }
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\b{i} \b");
            Thread.Sleep(1000);
        }

        Console.Write("\b \b");
        Console.WriteLine();
    }
}
