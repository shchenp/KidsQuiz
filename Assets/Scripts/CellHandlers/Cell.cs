using CardHandlers;
using DOTweenAnimations;
using Extensions;
using ScriptableObjects;
using UnityEngine;

namespace CellHandlers
{
    public class Cell : MonoBehaviour
    {
        [SerializeField] private ScaleBouncer _scaleBouncer;
        [SerializeField] private CardHolder _cardHolder;
        [SerializeField] private SpriteRenderer _backgroundSpriteRenderer;

        public void SetCardData(CardData cardData)
        {
            Initialize(cardData);
        }

        private void Initialize(CardData cardData)
        {
            _backgroundSpriteRenderer.SetRandomColor();

            _cardHolder.Initialize(cardData);
        }

        public void Bounce()
        {
            _scaleBouncer.Bounce();
        }
    }   
}