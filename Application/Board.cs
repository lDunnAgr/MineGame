using Domain;

namespace Application
{
    public class Board
    {
        private Position _playerLocation;
        private BoardDimensions _boardDimensions;

        public Board(Position position, BoardDimensions boardDimensions)
        {
            _playerLocation = position;
            _boardDimensions = boardDimensions;
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
                    if (_playerLocation.Horizontal > 0) _playerLocation = new Position(_playerLocation.Horizontal - 1, _playerLocation.Vertical);
                    return;
                case Direction.Right:
                    if (_boardDimensions.Width - 1 > _playerLocation.Horizontal) _playerLocation = new Position(_playerLocation.Horizontal + 1, _playerLocation.Vertical);
                    return;
                case Direction.Up:
                    if (_boardDimensions.Height - 1 > _playerLocation.Vertical) _playerLocation = new Position(_playerLocation.Horizontal, _playerLocation.Vertical + 1);
                    return;
                case Direction.Down:
                    if (_playerLocation.Vertical > 0) _playerLocation = new Position(_playerLocation.Horizontal, _playerLocation.Vertical - 1);
                    return;
                default:
                    return;
            }
        }
    }
}
