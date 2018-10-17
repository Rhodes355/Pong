using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

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

            paddleSprite = Content.Load<Texture2D>("paddle");
            ballSprite = Content.Load<Texture2D>("ball");
            font = Content.Load<SpriteFont>("Score");

            int width = graphics.PreferredBackBufferWidth;
            int height = graphics.PreferredBackBufferHeight;

            paddle = new Paddle(400, 240, paddleSprite);
            player = new Player(300, 250, paddleSprite);
            player2 = new Player(200, 250, paddleSprite);
            ball = new Ball(width/2, height/2, ballSprite);
            

            input = new KeyboardController(player, player2, this);

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
            // TODO: KeyboardController class

            foreach (IGameObject obj in objects)
            {
                obj.Update(); // Updates all needed game objects
            }

            input.Update();


            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            foreach(IGameObject obj in objects)
            {
                obj.Draw(spriteBatch);
            }

            // TODO: Score class?
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Score: " + score, new Vector2(100, 100), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public void Reset()
        {
            foreach(IGameObject obj in objects)
            {
                obj.Reset();
            }
        }
    }
}
