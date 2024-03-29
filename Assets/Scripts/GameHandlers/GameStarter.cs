using CellHandlers;
using DOTweenAnimations;
using LevelHandlers;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameHandlers
{
    public class GameStarter : MonoBehaviour
    {
        [SerializeField] private LevelStarter _levelStarter;
        [SerializeField] private CellsAnimatorController _cellsAnimatorController;
        [SerializeField] private CanvasGroupFader _textCanvasGroupFader;

        private void Awake()
        {
            _levelStarter.Run();
        }

        private void Start()
        {
            _cellsAnimatorController.ShowCells();
            _textCanvasGroupFader.FadeIn();
        }
    }   
}