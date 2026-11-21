using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _seconds;
    public List<Comment> _comments = new List<Comment>();

    public int CommentCount()
    {
        return _comments.Count;
    }
}