using PointAndClickEngine;
using TestGame.Properties;

namespace TestGame.Scenes
{
    public class StampScene : Scene
    {
        public StampScene()
        {
            Sprite.SetResourceManager(Resources.ResourceManager);
        }

        public override void Click(int x, int y)
        {
            var sprite = Sprite.LoadFromResources("testsprite");
            sprite.X = x - 24;
            sprite.Y = y - 24;
            Sprites.Add(sprite);
        }
    }
}