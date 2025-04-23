using Domain;

namespace Application
{
    public class Board
    {
        private Position _playerLocation;

        public Board(Position position)
        {
            _playerLocation = position;
        }

        public Position GetPlayerPosition()
        {
            return _playerLocation;
        }

        public void Move(Direction direction)
        {
            switch (direction) 
            {
                case Direction.Left:
                    _playerLocation = new Position(_playerLocation.Horizontal - 1, _playerLocation.Vertical);
                    return;
                case Direction.Right:
                    _playerLocation = new Position(_playerLocation.Horizontal + 1, _playerLocation.Vertical);
                    return;
                case Direction.Up:
                    _playerLocation = new Position(_playerLocation.Horizontal, _playerLocation.Vertical + 1);
                    return;
                case Direction.Down:
                    _playerLocation = new Position(_playerLocation.Horizontal, _playerLocation.Vertical - 1);
                    return;
                default:
                    return;
            }
        }
    }
}
