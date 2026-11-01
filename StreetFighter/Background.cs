using System;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace StreetFighter;

public class Background
{
    private Texture2D _backgroundTexture;
    public void Load(GraphicsDevice graphicsDevice)
    {
        string path = Path.Combine(AppContext.BaseDirectory, "assets", "backgrounds", "chunli_background.png");
        using var stream = File.OpenRead(path);
        _backgroundTexture = Texture2D.FromStream(graphicsDevice, stream);
    }

    public void Draw(SpriteBatch spriteBatch, Camera camera)
    {
        spriteBatch.Draw(_backgroundTexture, Vector2.Zero, camera.View, Color.White);
    }
}