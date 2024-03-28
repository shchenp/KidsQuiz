using ScriptableObjects;
using UnityEngine;

namespace CardHandlers
{
    public class TargetCardHandler : MonoBehaviour
    {
        public CardData TargetCard { get; private set; }
        
        public void SetTargetCard(CardData cardData)
        {
            TargetCard = cardData;
        }
    }
}