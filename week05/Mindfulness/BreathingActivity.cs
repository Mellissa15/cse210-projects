class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.") { }

    public override void Run()
    {
        Start();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            elapsed += 4;

            if (elapsed >= _duration) break;

            Console.Write("Breathe out... ");
            Countdown(6);
            elapsed += 6;
        }

        End();
    }
}
