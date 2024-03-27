using Extensions;
using ScriptableObjects;
using UnityEngine;

namespace CardHandlers
{
    public class CardBundleHandler : MonoBehaviour
    {
        [SerializeField] private RandomBundleGenerator _bundleGenerator;
        [SerializeField] private UsedCardsHandler _usedCardsHandler;
    
        private CardBundleData _cardBundleData;

        private void Awake()
        {
            GetNewBundle();
        }

        private void GetNewBundle()
        {
            _cardBundleData = _bundleGenerator.GetRandomBundle();
        }

        public CardData GetNewCard()
        {
            var cardData = _cardBundleData.CardBundle.GetRandomCardData();
            var isCardUsed = _usedCardsHandler.IsCardUsed(cardData);

            if (isCardUsed)
            {
                cardData = GetNewCard();

                return cardData;
            }

            _usedCardsHandler.Add(cardData);
        
            return cardData;
        }
    }   
}