using System.Collections.Generic;
using Extensions;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.Events;

namespace CardHandlers
{
    public class UsedCardsHandler : MonoBehaviour
    {
        public UnityEvent<CardData> TargetChanged;
    
        private readonly List<CardData> _usedTargetsCards = new List<CardData>();
        private readonly List<CardData> _usedCards = new List<CardData>();

        public void Add(CardData cardData)
        {
            _usedCards.Add(cardData);
        }

        public void SetNewTarget()
        {
            var target = _usedCards.GetRandomCardData();
        
            _usedTargetsCards.Add(target);
        
            TargetChanged.Invoke(target);
        }

        public bool IsCardUsed(CardData cardData)
        {
            return _usedCards.Contains(cardData) || _usedTargetsCards.Contains(cardData);
        }

        public void ClearUsedCardsList()
        {
            _usedCards.Clear();
        }
    }
}