using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace StreetFighter;

public class Animation
{
       private List<Texture2D> _images =[];
       private int index;
       private double temps;
       private int duration=130;

       public void Load(GraphicsDevice graphicsDevice)
       {
              string path = Path.Combine(AppContext.BaseDirectory, "assets", "characters", "chunli", "animations","idle");
              string[] listeChemin = Directory.GetFiles(path, "*.png");
              Array.Sort(listeChemin);
              foreach (string chemin in listeChemin)
              {
                     using var stream = File.OpenRead(chemin);
                     _images.Add(Texture2D.FromStream(graphicsDevice, stream));
              }
       }
       
       public void Draw(SpriteBatch spriteBatch, Vector2 position)
       {
              Texture2D texture = _images[index];
              Vector2 origin = new Vector2(texture.Width / 2f, texture.Height);
              spriteBatch.Draw(texture, position, null, Color.White, 0f, origin, 1f, SpriteEffects.None, 0f);
              
       }

       public void Update(GameTime gameTime)
       {
              temps = temps + gameTime.ElapsedGameTime.TotalMilliseconds;
              if (temps > duration)
              {
                     temps = 0;
                     index ++;
              }

              if (index >= _images.Count)
              {
                     index = 0;
              }
       }
}