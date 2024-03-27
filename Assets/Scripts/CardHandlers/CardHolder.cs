using ScriptableObjects;
using UnityEngine;

namespace CardHandlers
{
    public class CardHolder : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _cardSpriteRenderer;

        public void Initialize(CardData cardData)
        {
            _cardSpriteRenderer.sprite = cardData.Sprite;
        }
    }   
}