using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace Pong
{
    
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private KeyboardController input;

        private Player player;
        private Player player2;

        private Paddle paddle;
        private Ball ball;

        private Texture2D paddleSprite;
        private Texture2D ballSprite;

        private SpriteFont font;
        private int score = 0;

        //All game objects go in this list
        IList<IGameObject> objects = new List<IGameObject>();
        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            // Add your initialization logic here
            
            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Use this.Content to load your game content here
            // TODO: Better way to load sprites?

            // Load textures
            paddleSprite = Content.Load<Texture2D>("paddle");
            ballSprite = Content.Load<Texture2D>("ball");
            font = Content.Load<SpriteFont>("Score");
            
            // Get bounds of the game window
            // TODO: These don't seem to give the right bounds. Figure out why
            int width = GraphicsDevice.Viewport.Bounds.Width;
            int height = GraphicsDevice.Viewport.Bounds.Height;
            
            // Initialize game objects at their proper positions
            // TODO: Figure out proper positions
            paddle = new Paddle(width/2, height/2, paddleSprite);
            player = new Player(300, 250, paddleSprite);
            player2 = new Player(200, 250, paddleSprite);
            ball = new Ball(width/2, height/2, ballSprite);
            
            // Keyboard input object
            input = new KeyboardController(player, player2, this);

            // Add game objects to list
            objects.Add(player);
            objects.Add(player2);
            objects.Add(paddle);
            objects.Add(ball);
        }

        
        protected override void UnloadContent()
        {
            // Unload any non ContentManager content here
        }

        
        protected override void Update(GameTime gameTime)
        {

            foreach (IGameObject obj in objects)
            {
                obj.Update(); // Update all game objects
            }

            input.Update(); // Updates keyboard input


            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            foreach(IGameObject obj in objects)
            {
                obj.Draw(spriteBatch); // Draw all game objects
            }

            // TODO: Score class
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Score: " + score, new Vector2(100, 100), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void Reset()
        {
            foreach(IGameObject obj in objects)
            {
                obj.Reset(); // Reset all game objects
            }
        }
    }
}
