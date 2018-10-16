using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong
{
    class Ball : IGameObject
    {
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        private Texture2D sprite;

        public Ball(int xLocation, int yLocation, Texture2D sprite)
        {
            Position = new Vector2(xLocation, yLocation);
            this.sprite = sprite;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Call PongSprite.draw();
            // TODO: Implement ballSprite class?
            spriteBatch.Begin();
            spriteBatch.Draw(sprite, new Vector2(450, 240), Color.White);
            spriteBatch.End();
        }

        public void Reset()
        {
            //Reset position/velocity
        }

        public void Update()
        {
            //What should this class check for/accomplish each game tick?
        }
    }
}
