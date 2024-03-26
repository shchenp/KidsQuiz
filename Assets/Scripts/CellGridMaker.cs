using UnityEngine;

public class CellGridMaker : MonoBehaviour
{
    [SerializeField] private Cell _prefab;
    
    private int _columnsCount;
    private int _rawsCount;
    
    private float _cellSizeX;
    private float _cellSizeY;

    private void Awake()
    {
        var prefabScale = _prefab.transform.lossyScale;
        _cellSizeX = prefabScale.x;
        _cellSizeY = prefabScale.y;
    }
}