using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Extensions
{
    public static class ListCardDataExtensions
    {
        public static CardData GetRandomCardData(this List<CardData> list)
        {
            var count = list.Count;

            var index = Random.Range(0, count);

            return list[index];
        }
    }
}