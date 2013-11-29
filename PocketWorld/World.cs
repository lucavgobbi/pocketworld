using PocketWorld.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld
{
    public class World
    {
        private List<IThing>[,] _map;
        private List<PlayerPosition> _playerPositions;

        public int Width {get;set;}

        public int Height { get; set; }

        /// <summary>
        /// Add the new playerPosition the the list
        /// </summary>
        /// <param name="playerPosition"></param>
        private void AddPlayerPosition(PlayerPosition playerPosition)
        {
            _playerPositions.Add(playerPosition);
        }
        
        /// <summary>
        /// Updates the playerposition entry with the new position
        /// </summary>
        /// <param name="playerPosition"></param>
        /// <param name="newPosition"></param>
        private void UpdatePlayerPosition(PlayerPosition playerPosition, Position newPosition)
        {
            playerPosition.Position = newPosition;
        }

        /// <summary>
        /// Return the list of IThings in the position, if the position is invalid returns null
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private List<IThing> GetThingsFromPosition(Position position)
        {
            if(position.X > Width || position.Y > Height)
            {
                return null;
            }
            return _map[position.X, position.Y];
        }

        /// <summary>
        /// Add IThing to the world in specific positions
        /// </summary>
        /// <param name="thing"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool AddThingToPosition(IThing thing, Position position)
        {
            var mapPosition = _map[position.X, position.Y];
            //Map lazy instantiation
            if (mapPosition == null)
            {
                mapPosition = _map[position.X, position.Y] = new List<IThing>();
            }

            mapPosition.Add(thing);

            return true;
        }

        /// <summary>
        /// Instantiate the world
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public World(int width, int height)
        {
            Width = width;
            Height = height;
            _map = new List<IThing>[Width, Height];

            _playerPositions = new List<PlayerPosition>();
        }

        /// <summary>
        /// Perform moves inside the map and on control objects
        /// </summary>
        /// <param name="player"></param>
        /// <param name="move"></param>
        /// <returns></returns>
        private bool DoMove(PlayerPosition playerPosition, Move move)
        {
            //validate the move
            var newPosition = new Position(playerPosition.Position.X + move.X, playerPosition.Position.Y + move.Y);
            if (newPosition.X < Width && newPosition.Y < Height)
            {
                var thingsInPosition = GetThingsFromPosition(playerPosition.Position);
                thingsInPosition.Remove(playerPosition.Player);
                AddThingToPosition(playerPosition.Player, newPosition);
                UpdatePlayerPosition(playerPosition, newPosition);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Set the players inside the map to start the match, after that call the Generate for each player.
        /// </summary>
        /// <param name="players"></param>
        public void SetPlayers(IEnumerable<IPlayer> players, GraphicsInterface graphicsInterface = null)
        {
            var random = new Random();

            foreach(var player in players)
            {
                var position = new Position(random.Next(0, Width), random.Next(0, Height));
                while (!AddThingToPosition(player, position)) 
                {
                    position = new Position(random.Next(0, Width), random.Next(0, Height));
                }

                _playerPositions.Add(new PlayerPosition(player, position));
            }

            foreach(var player in players)
            {
                player.Generate();
            }

            if(graphicsInterface != null)
            {
                graphicsInterface.Init(_map);
            }
        }

        /// <summary>
        /// Call all player to run
        /// </summary>
        public void PlayTurn(GraphicsInterface graphicsInterface = null)
        {
            foreach (var playerPosition in _playerPositions)
            {
                var move = playerPosition.Player.DoMove();

                var moved = DoMove(playerPosition, move);

                if(graphicsInterface != null)
                {
                    //graphicsInterface.AfterPlayerTurn(_map)
                }
            }

            if (graphicsInterface != null)
            {
                graphicsInterface.AfterTurn(_map);
            }
        }
    }
}
