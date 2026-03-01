using System.Security.Cryptography.X509Certificates;

public class Reflecting : Activity

{
    private List<string> _prompts;
    private List<string> _questions;
    public Reflecting() : base("Reflection", "This activity helps you reflect on times in your life when you have shown strength and experience")
    {
    _prompts = new List<string>
{
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something that required courage.",
    "Think of a time when you overcame a difficult challenge.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you achieved something you worked hard for."
};
_questions = new List<string>
{
    "Why was this experience meaningful to you?",
    "What did you learn about yourself from this experience?",
    "How did you feel during and after this experience?",
    "What challenges did you face and how did you overcome them?",
    "How can you apply what you learned to future situations?"
};
    }
public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime) {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        animation(10);
        Console.WriteLine("Pondering Question coming up...!");
        animation(3);
        int i = 0;
        while(i < _questions.Count)
            {
                Console.WriteLine(_questions[i]);
                animation(5);
                i++;
            }
        DisplayEndingMessage();
    }}
}