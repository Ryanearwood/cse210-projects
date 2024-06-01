public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public string Title { get => _title; set => _title = value; }
    public string Author { get => _author; set => _author = value; }
    public int Length { get => _length; set => _length = value; }
    public List<Comment> Comments { get => _comments; set => _comments = value; }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}
public class Comment
{
    private string _commenterName;
    private string _text;

    public string CommenterName { get => _commenterName; set => _commenterName = value; }
    public string Text { get => _text; set => _text = value; }
}
