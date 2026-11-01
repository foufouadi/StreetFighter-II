using Microsoft.Xna.Framework;

namespace StreetFighter;

public class Camera
{
    public Rectangle View { get; private set; }
    public Camera()
    {
        View = new Rectangle(192, 32, 384, 224);
    }
}