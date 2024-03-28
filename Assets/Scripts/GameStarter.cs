using CellHandlers;
using DOTweenAnimations;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private LevelController _levelController;
    [SerializeField] private CellsController _cellsController;
    [SerializeField] private CanvasGroupFader _textCanvasGroupFader;

    private void Awake()
    {
        _levelController.Run();
    }

    private void Start()
    {
        _cellsController.ShowCells();
        _textCanvasGroupFader.FadeIn();
    }
}