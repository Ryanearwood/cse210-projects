public class Channel
{
    private List<Video> _videos;

    public List<Video> Videos { get => _videos; set => _videos = value; }

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public void RemoveVideo(Video video)
    {
        _videos.Remove(video);
    }
}
