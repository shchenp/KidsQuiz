using System.Collections.Generic;
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

        private CardData _target;

        public void Add(CardData cardData)
        {
            _usedCards.Add(cardData);
        }

        public void SetNewTarget(CardData cardData)
        {
            _target = cardData;
        
            _usedTargetsCards.Add(cardData);
        
            TargetChanged.Invoke(cardData);
        }

        public bool IsCardUsed(CardData cardData)
        {
            return _usedCards.Contains(cardData) || _usedTargetsCards.Contains(cardData);
        }

        public bool IsCardATarget(CardData cardData)
        {
            return cardData == _target;
        }

        public void RemoveList()
        {
            _usedCards.Clear();
        }
    }
}