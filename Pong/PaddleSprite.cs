using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class PaddleSprite
    {
        // TODO: James implement this fucking class pls

        private Texture2D sprite;

        public PaddleSprite(Texture2D sprite) {
            this.sprite = sprite;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(sprite, new Vector2(400, 240), Color.White);
            spriteBatch.End();
        }
    }
}
