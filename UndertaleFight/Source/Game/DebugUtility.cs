using System;
using SFML.Graphics;
using SFML.System;

namespace UndertaleFight.Source;

public static class DebugUtility
{
    public const string CONSOLE_FONT_PATH = "assets\\fonts\\arial.ttf";
    public static Font? consoleFont;
    public static void LoadContent()
    {
        string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CONSOLE_FONT_PATH);
        consoleFont = new Font(fontPath);
    }

    public static void DrawPerformanceData(GameLoop gameLoop, Color color)
    {
        if (consoleFont == null)
        {
            return;
        }

        string totalTimeElapsedStr = gameLoop.GameTime.TotalTimeElapsed.ToString("0.000");
        string deltaTimeStr = gameLoop.GameTime.DeltaTime.ToString("0.00000");

        float fps = 1f / gameLoop.GameTime.DeltaTime;
        string fpsString = fps.ToString("0.00");

        Text elapsedText = new Text("time: " + totalTimeElapsedStr, consoleFont, 14);
        elapsedText.Position = new Vector2f(4f, 8f);
        elapsedText.FillColor = color;

        Text deltaTimeText = new Text("Δtime: " + deltaTimeStr, consoleFont, 14);
        deltaTimeText.Position = new Vector2f(4f, 28f);
        deltaTimeText.FillColor = color;

        Text fpsText = new Text("fps: " + fpsString, consoleFont, 14);
        fpsText.Position = new Vector2f(4f, 48f);
        fpsText.FillColor = color;

        gameLoop.Window.Draw(elapsedText);
        gameLoop.Window.Draw(deltaTimeText);
        gameLoop.Window.Draw(fpsText);
    }
}
