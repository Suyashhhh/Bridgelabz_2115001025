
using System;
class TextState
{
    public string Content;
    public TextState Prev;
    public TextState Next;

    public TextState(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextState head;
    private TextState current;
    private int maxStates = 10;
    private int stateCount = 0;

    public void AddState(string content)
    {
        TextState newState = new TextState(content);
        if (current != null)
        {
            current.Next = newState;
            newState.Prev = current;
        }
        else
        {
            head = newState;
        }
        current = newState;
        stateCount++;

        if (stateCount > maxStates)
        {
            head = head.Next;
            head.Prev = null;
            stateCount--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
        {
            Console.WriteLine("current text: " + current.Content);
        }
        else
        {
            Console.WriteLine("no text available");
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        
        editor.AddState("wasssa");
        editor.AddState("wassaapp");
        editor.AddState("wassaapp!");

        editor.DisplayCurrentState();
        editor.Undo();
        editor.DisplayCurrentState();
        editor.Undo();
        editor.DisplayCurrentState();
        editor.Redo();
        editor.DisplayCurrentState();
    }
}

