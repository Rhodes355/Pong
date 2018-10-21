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
            spriteBatch.Begin();
            spriteBatch.Draw(sprite, Position, Color.White);
            spriteBatch.End();
        }

        public void Reset()
        {
            InitializeValues(); //Reset position/velocity
        }

        public void Update()
        {
            //What should this class check for/accomplish each game tick?
            Position = new Vector2(Position.X + Velocity.X, Position.Y + Velocity.Y);

            // If the ball hits the approx sides of the window it must bounce back
            // TODO: This should update the score since when the ball reaches the left or right side it would score a point
            if (Position.X > 465 || Position.X < -280)
            {
                Velocity = new Vector2(Velocity.X * -1, Velocity.Y);
            }

            // If the ball hits the approx top or bottom of the window it must bounce back
            // TODO: Use a method to get bounds instead of using magic numbers
            if (Position.Y < -97 || Position.Y > 360)
            {
                Velocity = new Vector2(Velocity.X, Velocity.Y * -1);
            }

            
        }

        private void InitializeValues()
        {
            // Approx. center of window = Vector2(100, 150)
            Random rnd = new Random();

            // Initial x and y velocity should be reasonable values
            // i.e do not have the ball score a goal from going so fast
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
