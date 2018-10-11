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
        public void Draw(SpriteBatch spriteBatch)
        {
            //Call PaddleSprite.draw() here
        }

        public void Reset()
        {
            //Reset position/velocity
        }

        public void Update()
        {
            //What should this class check for each tick?
        }
    }
}
