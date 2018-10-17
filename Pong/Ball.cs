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

            InitializeValues();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //Call PongSprite.draw();
            // TODO: Implement ballSprite class?
            spriteBatch.Begin();
            spriteBatch.Draw(sprite, Position, Color.White);
            spriteBatch.End();
        }

        public void Reset()
        {
            //Reset position/velocity
            InitializeValues();
        }

        public void Update()
        {
            //What should this class check for/accomplish each game tick?
            Position = new Vector2(Position.X + Velocity.X, Position.Y + Velocity.Y);

            if (Position.X > 465 || Position.X < -280)
            {
                Velocity = new Vector2(Velocity.X * -1, Velocity.Y);
            }

            if (Position.Y < -97 || Position.Y > 360)
            {
                Velocity = new Vector2(Velocity.X, Velocity.Y * -1);
            }

            
        }

        private void InitializeValues()
        {
            // Position = new Vector2(100, 150);
            Random rnd = new Random();

            int xVel = rnd.Next(3, 6);
            int yVel = rnd.Next(2, 4);

            int flipSignX = rnd.Next(0, 2);
            int flipSignY = rnd.Next(0, 2);

            if (flipSignX == 1)
            {
                xVel *= -1;
            }

            if (flipSignY == 1)
            {
                yVel *= -1;
            }

            Velocity = new Vector2(xVel, yVel);
        }
    }
}
