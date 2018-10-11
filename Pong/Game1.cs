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
        private Texture2D player;
        private Texture2D ball;
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
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            player = Content.Load<Texture2D>("player");
            ball = Content.Load<Texture2D>("ball");
            font = Content.Load<SpriteFont>("Score");
        }

        
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        
        protected override void Update(GameTime gameTime)
        {
            
            foreach (IGameObject obj in objects)
            {
                obj.Update(); //Updates all needed game objects
            }


            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            foreach(IGameObject obj in objects)
            {
                obj.Draw(spriteBatch);
            }

            // This will be done once we have a paddle class
            spriteBatch.Begin();
            spriteBatch.Draw(player, new Vector2(400, 240), Color.White);
            spriteBatch.Draw(ball, new Vector2(450, 240), Color.White);
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
