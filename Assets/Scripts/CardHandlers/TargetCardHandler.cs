using ScriptableObjects;
using UnityEngine;

namespace CardHandlers
{
    public class TargetCardHandler : MonoBehaviour
    {
        private CardData _targetCard;

        public void SetTargetCard(CardData cardData)
        {
            _targetCard = cardData;
        }

        public void CheckCard(CardHolder cardHolder)
        {
            if (cardHolder.CardData == _targetCard)
            {
               
            }
            else
            {
                
            }
        }
    }
}