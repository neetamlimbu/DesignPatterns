using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns: Memento");

            var editor = new Editor();
            editor.Content = "a";

            var history = new History();
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);
        }
    }
}
