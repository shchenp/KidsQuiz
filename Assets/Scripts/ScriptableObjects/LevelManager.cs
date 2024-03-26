using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "LevelManager", menuName = "ScriptableObjects/LevelManager")]
    public class LevelManager : ScriptableObject
    {
        [SerializeField] private LevelData _currentLevelData;

        public void SetCurrentLevel(LevelData levelData)
        {
            _currentLevelData = levelData;
        }
    }
}