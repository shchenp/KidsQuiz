using ScriptableObjects;
using UnityEngine;
using UnityEngine.Serialization;

public class GameStarter : MonoBehaviour
{ 
    public CurrentLevelData CurrentLevelData => _currentLevelData;
    
    [SerializeField] private CurrentLevelData _currentLevelData;
}