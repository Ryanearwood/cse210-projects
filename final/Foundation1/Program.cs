class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment { CommenterName = "User1", Text = "Thats great!" };
        Comment comment2 = new Comment { CommenterName = "User2", Text = "What a great video." };
        Comment comment3 = new Comment { CommenterName = "User3", Text = "Nice!" };
        Comment comment4 = new Comment { CommenterName = "User4", Text = "Very cool!" };

        Video video1 = new Video { Title = "Video1", Author = "Author1", Length = 10, Comments = new List<Comment> { comment1, comment2 } };
        Video video2 = new Video { Title = "Video2", Author = "Author2", Length = 15, Comments = new List<Comment> { comment3, comment4 } };

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length}, Number of comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.CommenterName}: {comment.Text}");
            }
        }
    }
}
