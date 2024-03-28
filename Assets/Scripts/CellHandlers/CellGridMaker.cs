using ScriptableObjects;
using UnityEngine;
using UnityEngine.Events;

namespace CellHandlers
{
    public class CellGridMaker : MonoBehaviour
    {
        [SerializeField] private Cell _prefab;
        [SerializeField] private CellsController _cellsController;
        [SerializeField] private UnityEvent _gridCreated;
    
        private LevelData _levelData;
    
        private int _columnsCount;
        private int _rawsCount;
    
        private float _cellSizeX;
        private float _cellSizeY;

        private float _startPointX;
        private float _startPointY;

        private void Awake()
        {
            var prefabScale = _prefab.transform.lossyScale;

            _startPointX = transform.position.x;
            _startPointY = transform.position.y;
        
            _cellSizeX = prefabScale.x;
            _cellSizeY = prefabScale.y;
        }

        public void SetNextLevelData(LevelData levelData)
        {
            _levelData = levelData;
        
            SetNewMatrix();
        }

        public void CreateGrid()
        {
            for (var i = 0; i < _rawsCount * _columnsCount; i++)
            {
                var cell = Instantiate(_prefab, new Vector3(_startPointX + _cellSizeX * (i % _columnsCount),
                    _startPointY + _cellSizeY * (i / _columnsCount)), Quaternion.identity);
            
                _cellsController.Add(cell);
            }
            
            _gridCreated.Invoke();
        }

        public void DestroyGrid()
        {
            _cellsController.ResetCellsList();
        }
    
        private void SetNewMatrix()
        {
            _rawsCount = (int)_levelData.MatrixDimension.x;
            _columnsCount = (int)_levelData.MatrixDimension.y;
        }
    }
}