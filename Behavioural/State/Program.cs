namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Behavioral: State Pattern");

            Canvas canvas = new Canvas();
            canvas.SetCurrentTool(new Selection());
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.SetCurrentTool(new Brush());
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
