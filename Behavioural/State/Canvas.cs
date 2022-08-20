namespace State
{
    public class Canvas
    {
        private Tool currentTool;

        public void SetCurrentTool(Tool tool)
        {
            currentTool = tool;
        }

        public void MouseDown()
        {
            if (currentTool == null)
            {
                System.Console.WriteLine("Please select any tool first: MouseDown Event");
                return;
            }

            currentTool.MouseDown();
        }

        public void MouseUp()
        {
            if (currentTool == null)
            {
                System.Console.WriteLine("Please select any tool first:MouseUp Event");
                return;
            }

            currentTool.MouseUp();
        }
    }
}