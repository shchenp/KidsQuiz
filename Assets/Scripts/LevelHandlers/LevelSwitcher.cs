using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.Events;

namespace LevelHandlers
{
    public class LevelSwitcher : MonoBehaviour
    {
        [SerializeField] private CurrentLevelData _currentLevel;
        [SerializeField] private List<LevelData> _levels;
        [SerializeField] private UnityEvent _nextLevelSetted;
        [SerializeField] private UnityEvent _gamePassed;

        private int _currentLevelIndex;

        private void Awake()
        {
            _currentLevelIndex = _levels.IndexOf(_currentLevel.CurrentLevel);
        }

        public void SetNextLevel()
        {
            _currentLevelIndex++;

            var nextLevel = _levels[_currentLevelIndex % _levels.Count];
            _currentLevel.SetCurrentLevel(nextLevel);
        
            if (_currentLevelIndex < _levels.Count)
            {
                _nextLevelSetted?.Invoke();
                return;
            }
        
            _gamePassed?.Invoke();
        }
    }
}