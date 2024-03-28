using DOTweenAnimations;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.EventSystems;
using VContainer;

namespace CardHandlers
{
    public class CardHolder : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private SpriteRenderer _cardSpriteRenderer;
        [SerializeField] private ScaleBouncer _scaleBouncer;
        [SerializeField] private PositionEaseInBouncer _positionEaseInBouncer;

        private CardData _cardData;
        private TargetCardHandler _targetCard;
        private ParticleHandler _particleHandler;

        [Inject]
        public void Construct(TargetCardHandler targetCardHandler, ParticleHandler particleHandler)
        {
            _targetCard = targetCardHandler;
            _particleHandler = particleHandler;
        }

        public void Initialize(CardData cardData)
        {
            _cardData = cardData;
            
            if (_cardData.IsNeedToRotate)
            {
                transform.Rotate(_cardData.Rotation);
            }
            
            _cardSpriteRenderer.sprite = cardData.Sprite;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (_cardData == _targetCard.TargetCard)
            {
                OnTargetClicked();
            }
            else
            {
                OnWrongClicked();
            }
        }

        private void OnTargetClicked()
        {
            _scaleBouncer.Bounce();
            _particleHandler.PlayOnPosition(transform.position);
        }

        private void OnWrongClicked()
        {
            _positionEaseInBouncer.EaseInBounce();
        }
    }   
}