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
        private Player player1;
        private Player player2;
        private Game1 game;

        public KeyboardController(Player player1, Game1 game)
        {
            this.player1 = player1;
            this.game = game;
        }

        public KeyboardController(Player player1, Player player2, Game1 game)
        {
            this.player1 = player1;
            this.player2 = player2;
            this.game = game;
        }

        public void Update()
        {
            KeyboardState state = Keyboard.GetState();
            Vector2 pos = player1.Position;
            Vector2 pos2 = player2.Position;

            if (state.IsKeyDown(Keys.Up))
            {
                pos.Y -= 5;
            }

            if (state.IsKeyDown(Keys.W))
            {
                pos2.Y -= 5;
            }

            if (state.IsKeyDown(Keys.Down))
            {
                pos.Y += 5;
            }

            if (state.IsKeyDown(Keys.S))
            {
                pos2.Y += 5;
            }

            if (state.IsKeyDown(Keys.Q))
            {
                game.Exit();
            }

            if (state.IsKeyDown(Keys.R))
            {
                game.Reset();
            }
                
            player1.Position = pos;
            player2.Position = pos2;
        }
    }
}
