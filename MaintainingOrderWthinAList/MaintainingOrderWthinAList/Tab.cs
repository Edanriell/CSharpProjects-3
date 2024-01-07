public class Tab
{
    public Tab(string url) => (Url) = (url);

    public string Url { get; set; }

    public override string ToString() => Url;
}
