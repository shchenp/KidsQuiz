using CellHandlers;
using ScriptableObjects;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private CurrentLevelData _levelData;
    [SerializeField] private CellGridMaker _gridMaker;
    
    public void Run()
    {
        _gridMaker.SetNextLevelData(_levelData.CurrentLevel);
        
        _gridMaker.CreateGrid();
    }
}