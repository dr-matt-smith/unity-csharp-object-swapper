public class Book
{
    public string title = "(no title set)";
    
    public override string ToString()
    {
        return "(Book) title = " + this.title;
    }
}