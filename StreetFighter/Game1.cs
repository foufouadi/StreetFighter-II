using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StreetFighter;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    
    private const int HEIGHT = 224;
    private const int WIDTH = 384;
    private const int SCALE = 4;
    
    private Camera _camera;
    private Background _background;
    private Animation _animation;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        Window.AllowUserResizing = false;
        _graphics.PreferredBackBufferHeight = HEIGHT * SCALE;
        _graphics.PreferredBackBufferWidth = WIDTH * SCALE;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _camera  = new Camera();
        _background = new Background();
        _background.Load(GraphicsDevice);
        _animation = new Animation();
        _animation.Load(GraphicsDevice);

    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        _animation.Update(gameTime);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        _spriteBatch.Begin(samplerState: SamplerState.PointClamp, blendState: BlendState.NonPremultiplied,transformMatrix:Matrix.CreateScale(SCALE));
        _background.Draw(_spriteBatch, _camera);
        _animation.Draw(_spriteBatch, new Vector2(150, 190));
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
