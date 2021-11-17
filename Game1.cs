using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Part_2___scaling
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D rectTexture;
        Texture2D circTexture;
        SpriteFont textFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            rectTexture = Content.Load<Texture2D>("rectangle");
            circTexture = Content.Load<Texture2D>("circle");
            textFont = Content.Load<SpriteFont>("TextFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            
            _spriteBatch.Draw(circTexture, new Rectangle(160, 10, 450, 450), Color.Yellow);
            _spriteBatch.Draw(rectTexture, new Rectangle(245, 300, 275, 40), Color.Black);
            _spriteBatch.Draw(circTexture, new Rectangle(425, 125, 70, 70), Color.Black);
            _spriteBatch.Draw(circTexture, new Rectangle(275, 125, 70, 70), Color.Black);
            _spriteBatch.DrawString(textFont, "That joke sucked.", new Vector2(10, 50), Color.Black);
            
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
