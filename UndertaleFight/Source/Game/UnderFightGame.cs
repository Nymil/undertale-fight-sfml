using System;
using SFML.Graphics;

namespace UndertaleFight.Source;

public class UnderFightGame : GameLoop
{
    public const string WINDOW_TITLE = "SHIVER";
    public const uint DEFAULT_WINDOW_WIDTH = 640;
    public const uint DEFAULT_WINDOW_HEIGHT = 480;

    public UnderFightGame() : base(DEFAULT_WINDOW_WIDTH, DEFAULT_WINDOW_HEIGHT, WINDOW_TITLE, Color.Black)
    {
    }

    public override void Draw(GameTime gameTime)
    {
        DebugUtility.DrawPerformanceData(this, Color.White);
    }

    public override void Initialize()
    {

    }

    public override void LoadContent()
    {
        DebugUtility.LoadContent();
    }

    public override void Update(GameTime gameTime)
    {

    }
}
