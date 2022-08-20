namespace State
{
    public class Brush : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush Tool selected...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Horizontal Line created");
        }
    }
}