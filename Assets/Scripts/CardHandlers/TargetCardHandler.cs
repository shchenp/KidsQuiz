using ScriptableObjects;
using UnityEngine;

namespace CardHandlers
{
    public class TargetCardHandler : MonoBehaviour
    {
        public CardData TargetCard { get; private set; }

        /// <summary>
        /// переместить сюда партикл и логику его появления
        /// в КардХолдер заинжектить этот класс и проверять данные через ЧекКард
        /// </summary>
        /// <param name="cardData"></param>
        public void SetTargetCard(CardData cardData)
        {
            TargetCard = cardData;
        }
    }
}