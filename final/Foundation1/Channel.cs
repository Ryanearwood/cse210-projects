public class Channel
{
    public List<Video> Videos { get; set; }

    public void AddVideo(Video video)
    {
        Videos.Add(video);
    }

    public void RemoveVideo(Video video)
    {
        Videos.Remove(video);
    }

    
}