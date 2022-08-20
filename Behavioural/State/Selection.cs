namespace State
{
    public class Selection : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection Tool selected...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Selection Rectangle created");
        }
    }
}