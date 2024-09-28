public class PromptGenerator
/*
Supplies random prompts whenever needed 
(ie: when a new entry begins). This class will draw from a list of
prompts created by the author (Kathleen Rivera), but could be edited
to eventually draw prompts from an outside source.
Because I have created this class, if I decide one day to 
draw prompts from an outside source, such as a webpage, I would
only need to alter this class rather than more code from other classes
if I had just made this a method instead of a class. Saves work later.

GetRandomPrompt() : string

_prompts : List<string>
*/
{
    // This is the initial list of prompts
    List<string> _prompts = new List<string> {
        "What am I grateful for today?",
        "Describe your childhood.",
        "What is your biggest regret?",
        "What are you most grateful for today?",
        "How do you prioritize your goals?",
        "What is your favourite book?",
        "Do you have any siblings? Are you close to them?"
    };
    public string GetRandomPrompt()
    {
        // an instance of the random class must be created
        Random random = new Random();

        // use the Next method to get a random index
        // use the Count method to get the count of how many items are in the list
        // this helps the Next method function properly
        int index = random.Next(_prompts.Count); // get the random index
        string randomPrompt = _prompts[index]; // get the prompt at the random index

        return randomPrompt;
    }
}