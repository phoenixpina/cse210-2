public class Scripture
{
    private List<Word> words;

    public Reference Reference { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(0, words.Count);
        words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.Hidden);
    }

    public override string ToString() //I had AI help make the ToString methods on all 3 classes
    {
        return $"{Reference}\n{string.Join(" ", words)}";
    }
}