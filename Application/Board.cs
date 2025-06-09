using Domain;

namespace Application
{
    public class Board
    {
        private Position _playerLocation;
        private BoardDimensions _boardDimensions;
        private List<Landmine> _landmines;
        private int _playerLives = 3;

        public Board(Position position, BoardDimensions boardDimensions, List<Landmine> landmines)
        {
            _playerLocation = position;
            _boardDimensions = boardDimensions;
            _landmines = landmines;
        }

        public Position GetPlayerPosition()
        {
            return _playerLocation;
        }

        public int GetPlayerLives()
        {
            return _playerLives;
        }

        public void Move(Direction direction)
        {
            if (_playerLives == 0)
            {
                return;
            }

            switch (direction)
            {
                case Direction.Left:
                    if (_playerLocation.Horizontal > 0) _playerLocation = new Position(_playerLocation.Horizontal - 1, _playerLocation.Vertical);
                    return;
                case Direction.Right:
                    if (_boardDimensions.Width - 1 > _playerLocation.Horizontal) _playerLocation = new Position(_playerLocation.Horizontal + 1, _playerLocation.Vertical);
                    return;
                case Direction.Up:
                    if (_boardDimensions.Height - 1 > _playerLocation.Vertical)
                    {
                        _playerLocation = new Position(_playerLocation.Horizontal, _playerLocation.Vertical + 1);
                        CheckForLandmineAndDetonateIfFound();
                    }
                    return;
                case Direction.Down:
                    if (_playerLocation.Vertical > 0)
                    {
                        _playerLocation = new Position(_playerLocation.Horizontal, _playerLocation.Vertical - 1);
                        CheckForLandmineAndDetonateIfFound();
                    };
                    return;
                default:
                    return;
            }
        }

        private Landmine? FindLandMineUnderPlayer()
        {
            return _landmines.FirstOrDefault(l => l.GetPosition() == _playerLocation);
        }

        private void CheckForLandmineAndDetonateIfFound()
        {
            var landmine = FindLandMineUnderPlayer();

            if (landmine != null && !landmine.HasDetonated())
            {
                landmine.Detonate();
                _playerLives--;
            }
        }
    }
}
