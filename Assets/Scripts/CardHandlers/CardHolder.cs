using ScriptableObjects;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CardHandlers
{
    public class CardHolder : MonoBehaviour, IPointerClickHandler
    {
        public CardData CardData { get; private set; }

        [SerializeField] private SpriteRenderer _cardSpriteRenderer;
        
        private ParticleHandler _particleHandler;

        public void Initialize(CardData cardData)
        {
            CardData = cardData;
            
            if (CardData.IsNeedToRotate)
            {
                transform.Rotate(CardData.Rotation);
            }
            
            _cardSpriteRenderer.sprite = cardData.Sprite;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            
        }
    }   
}