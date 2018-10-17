using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class Player
    {
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }

        public Player(Texture2D paddle)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

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
