public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
"What was your favorite part of your day today?",
"What is something you learned recently?",
"What is one thing you are grateful for?",
"List an encounter you had with someone today.",
"Did you like today's weather?"
    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}