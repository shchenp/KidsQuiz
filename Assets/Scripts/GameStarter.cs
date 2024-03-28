using CellHandlers;
using DOTweenAnimations;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private LevelController _levelController;
    [SerializeField] private CellsAnimatorController _cellsAnimatorController;
    [SerializeField] private CanvasGroupFader _textCanvasGroupFader;

    private void Awake()
    {
        _levelController.Run();
    }

    private void Start()
    {
        _cellsAnimatorController.ShowCells();
        _textCanvasGroupFader.FadeIn();
    }
}