using CardHandlers;
using DOTweenAnimations;
using Extensions;
using ScriptableObjects;
using UnityEngine;

namespace CellHandlers
{
    public class Cell : MonoBehaviour
    {
        [SerializeField] private Bouncer _bouncer;
        [SerializeField] private CardHolder _cardHolder;
        [SerializeField] private SpriteRenderer _backgroundSpriteRenderer;
    
        private CardData _cardData;

        public void SetCardData(CardData cardData)
        {
            _cardData = cardData;
        
            Initialize(cardData);
        }

        private void Initialize(CardData cardData)
        {
            if (_cardData.IsNeedToRotate)
            {
                transform.Rotate(_cardData.Rotation);
            }
        
            _backgroundSpriteRenderer.SetRandomColor();

            _cardHolder.Initialize(cardData);
        }

        public void Bounce()
        {
            _bouncer.Bounce();
        }
    }   
}