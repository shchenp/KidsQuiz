using ScriptableObjects;
using UnityEngine;

namespace  CardHandlers
{
    public class RandomBundleGenerator : MonoBehaviour
    {
        [SerializeField] private CardBundleData[] _cardBundles;

        public CardBundleData GetRandomBundle()
        {
            var count = _cardBundles.Length;

            var randomBundleIndex = Random.Range(0, count);

            return _cardBundles[randomBundleIndex];
        }
    }   
}