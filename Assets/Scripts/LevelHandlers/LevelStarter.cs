using CardHandlers;
using CellHandlers;
using ScriptableObjects;
using UnityEngine;

namespace LevelHandlers
{
    public class LevelStarter : MonoBehaviour
    {
        [SerializeField] private CurrentLevelData _levelData;
        [SerializeField] private CardBundleHandler _cardBundleHandler;
        [SerializeField] private CellGridMaker _gridMaker;
    
        public void Run()
        {
            _cardBundleHandler.GetNewBundle();
        
            _gridMaker.SetNextLevelData(_levelData.CurrentLevel);
            _gridMaker.CreateGrid();
        }
    }   
}