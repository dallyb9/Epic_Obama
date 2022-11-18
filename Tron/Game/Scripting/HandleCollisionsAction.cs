using System;
using System.Collections.Generic;
using System.Data;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver == false)
            {
                HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
            }
        }

        /// <summary>
        /// Updates the score nd moves the food if the snake collides with it.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleFoodCollisions(Cast cast)
        {
            Snake playerOne = (Snake)cast.GetFirstActor("playerOne");
            Snake playerTwo = (Snake)cast.GetFirstActor("playerTwo");
            Score score = (Score)cast.GetFirstActor("score");
            //Food food = (Food)cast.GetFirstActor("food");
                //int points = food.GetPoints();
                // GrowTail(segmentsamount)
                playerOne.GrowTail(1);
                playerTwo.GrowTail(1);
                //score.AddPoints(points);
                //food.Reset();
        }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            Snake playerOne = (Snake)cast.GetFirstActor("playerOne");
            Snake playerTwo = (Snake)cast.GetFirstActor("playerTwo");
            Actor head = playerOne.GetHead();
            Actor head2 = playerTwo.GetHead();
            List<Actor> body = playerOne.GetBody();
            List<Actor> body2 = playerTwo.GetBody();

            foreach (Actor segment in body)
            {
                if (segment.GetPosition().Equals(head.GetPosition()) || (segment.GetPosition().Equals(head2.GetPosition())))
                {
                    isGameOver = true;
                }
            }
            ///*
            foreach (Actor segment in body2)
            {
                if (segment.GetPosition().Equals(head.GetPosition()) || (segment.GetPosition().Equals(head2.GetPosition())))
                {  
                    isGameOver = true;
                }
            }
            //*/
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver == true)
            {
                Snake playerOne = (Snake)cast.GetFirstActor("playerOne");
                List<Actor> segments = playerOne.GetSegments();
                //Food food = (Food)cast.GetFirstActor("food");

                Snake playerTwo = (Snake)cast.GetFirstActor("playerTwo");
                List<Actor> segments2 = playerTwo.GetSegments();
                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white
                foreach (Actor segment in segments)
                {
                    segment.SetColor(Constants.WHITE);
                }
                // make player2 segments white
                foreach (Actor segment in segments2)
                {
                    segment.SetColor(Constants.WHITE);
                }

                //food.SetColor(Constants.WHITE);
            }
        }

    }
}