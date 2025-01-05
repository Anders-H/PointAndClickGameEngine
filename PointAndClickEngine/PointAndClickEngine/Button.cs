namespace PointAndClickEngine
{
    public class Button
    {
        public Sprite Sprite { get; }
        public string Text { get; set; }
        public bool Enabled { get; set; }

        public Button(Sprite sprite, string text)
        {
            Sprite = sprite;
            Text = text;
            Enabled = true;
        }
    }
}