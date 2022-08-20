using System.Collections.Generic;

namespace Memento
{
    public class History
    {
        private List<EditorState> states = new List<EditorState>();

        public void Push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState Pop()
        {
            if(states.Count == 0)
              return null;

            int index = states.Count - 1;
            var lastState = states[index];
            states.RemoveAt(index);
            return lastState;
        }
    }
}