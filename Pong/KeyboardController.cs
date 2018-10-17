using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class KeyboardController
    {
        private Player player;

        public KeyboardController(Player player)
        {
            this.player = player;
        }

        public void Update()
        {
            KeyboardState state = Keyboard.GetState();
            Vector2 pos = player.Position;
            if (state.IsKeyDown(Keys.Up))
                pos.Y += 10;
            if (state.IsKeyDown(Keys.Down))
                pos.Y -= 10;
            player.Position = pos;
        }
    }
}
