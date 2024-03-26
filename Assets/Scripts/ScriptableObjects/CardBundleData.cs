using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "CardBundleData", menuName = "ScriptableObjects/CardBundleData")]
    public class CardBundleData : ScriptableObject
    {
        public List<CardData> CardBundle => _cardBundle;
    
        [SerializeField] private List<CardData> _cardBundle;
    }
}