using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "LevelManager", menuName = "ScriptableObjects/LevelManager")]
    public class CurrentLevelData : ScriptableObject
    {
        public LevelData CurrentLevel => _currentLevelData;
        
        [SerializeField] private LevelData _currentLevelData;
    }
}