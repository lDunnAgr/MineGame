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

        public void MovePlayerUp()
        {
            _playerLocation = new Position(_playerLocation.Horizontal, _playerLocation.Vertical+1);
        }

        public void MovePlayerDown()
        {
            _playerLocation = new Position(_playerLocation.Horizontal, _playerLocation.Vertical - 1);
        }

        public void MovePlayerLeft()
        {
            _playerLocation = new Position(_playerLocation.Horizontal - 1, _playerLocation.Vertical);
        }

        public Position GetPlayerPosition()
        {
            return _playerLocation;
        }
    }
}
