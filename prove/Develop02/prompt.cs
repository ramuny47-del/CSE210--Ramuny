public class Prompt
{
    public string prompt_select()
    {
        List<string> prompt = new List<string> {"What did I do today that actaully moved my life forward?",
        "What drained my energy today that actually moved my life forward?", 
        "What gave me energy or made me feel alive today",
        "what emotion showed up the strongest today, and what triggered it?",
        "What did I avoid today that I know I shouldn't keep avoiding?",
        "What am I grateful for right now, even if today wasn't great?",
        "What did I learn today (about myself, others, or the world?)",
        "where did act in alignment with my values -- where did I not?",
        "what is one small win today that I shouldn't overlook?"};

Random randomGenerator = new Random();
    int number = randomGenerator.Next(0,9);

        string select_prompt = prompt[number];
        return select_prompt;}}