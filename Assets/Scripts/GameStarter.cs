using CellHandlers;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private LevelController _levelController;
    [SerializeField] private CellsController _cellsController;

    private void Awake()
    {
        _levelController.Run();
    }

    private void Start()
    {
        _cellsController.ShowCells();
    }
}