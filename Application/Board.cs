﻿namespace Application
{
    public class Board
    {
        private int _playerLocation;
        public void MovePlayerUp()
        {
            _playerLocation++;
        }

        public void MovePlayerDown()
        {
            _playerLocation--;

        }

        public int GetPlayerPosition()
        {
            return _playerLocation;
        }
    }
}
