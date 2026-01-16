public class PromptGenerator
{
  public List<string> _prompts;
  
  public string GetRandomPrompt()
  {
    Random random = new Random();
    _prompts = [
      "Who was the most interesting person I interacted with today?",
      "What was the best part of my day?",
      "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?",
      "If I had one thing I could do over today, what would it be?",
      "What is the food that you most enjoyed for today?",
      "Did you have an opportunity to serve somebody today? How was the experience?",
      "Did somebody make you happy today?"
    ];

    int randomIndex = random.Next(0, _prompts.Count);
    return $"{_prompts[randomIndex] } ";
  }
}