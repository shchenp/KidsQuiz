using ScriptableObjects;
using UnityEngine;

public class CellGridMaker : MonoBehaviour
{
    [SerializeField] private Cell _prefab;
    //[SerializeField] private float _offset;
    [SerializeField] private LevelData _levelData;
    
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

        _rawsCount = (int)_levelData.MatrixDimension.x;
        _columnsCount = (int)_levelData.MatrixDimension.y;
        
        CreateGrid();
    }

    public void CreateGrid()
    {
        for (var i = 0; i < _rawsCount * _columnsCount; i++)
        {
            Instantiate(_prefab, new Vector3(_startPointX + _cellSizeX * (i % _columnsCount),
                    _startPointY + _cellSizeY * (i / _columnsCount)), Quaternion.identity);
        }
    }
}