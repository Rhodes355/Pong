using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{

    class Paddle : IGameObject
    {
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        private Texture2D sprite;

        public Paddle(int xLocation, int yLocation, Texture2D sprite)
        {
            Position = new Vector2(xLocation, yLocation);
            this.sprite = sprite;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // TODO: Sexier way to draw using PaddleSprite?
            spriteBatch.Begin();
            spriteBatch.Draw(sprite, new Vector2(400, 240), Color.White);
            spriteBatch.End();
        }

        public void Reset()
        {
            // Reset position/velocity
        }

        public void Update()
        {
            // What should this class check for each tick?
        }
    }
}
