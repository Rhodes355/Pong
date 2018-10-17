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
        private Game1 game;

        public KeyboardController(Player player, Game1 game)
        {
            this.player = player;
            this.game = game;
        }

        public void Update()
        {
            KeyboardState state = Keyboard.GetState();
            Vector2 pos = player.Position;
            if (state.IsKeyDown(Keys.Up))
            {
                pos.Y -= 5;
            }
                
            if (state.IsKeyDown(Keys.Down))
            {
                pos.Y += 5;
            }

            if (state.IsKeyDown(Keys.Q))
            {
                game.Exit();
            }

            if (state.IsKeyDown(Keys.R))
            {
                game.Reset();
            }
                
            player.Position = pos;
        }
    }
}
