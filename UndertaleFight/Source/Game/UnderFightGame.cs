using System;
using SFML.Graphics;
using UndertaleFight.Source.Game;

namespace UndertaleFight.Source;

public class UnderFightGame : GameLoop
{
    private bool SHOW_FPS = true;
    public const string WINDOW_TITLE = "SHIVER";
    public const uint DEFAULT_WINDOW_WIDTH = 1200;
    public const uint DEFAULT_WINDOW_HEIGHT = 800;

    private GameState _state = GameState.Battle; // TODO: change to menu and implement menu

    public UnderFightGame() : base(DEFAULT_WINDOW_WIDTH, DEFAULT_WINDOW_HEIGHT, WINDOW_TITLE, Color.Black)
    {
    }

    public override void Draw(GameTime gameTime)
    {
        if (SHOW_FPS)
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
