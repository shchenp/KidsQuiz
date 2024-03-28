using CellHandlers;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "CellPrefabs", menuName = "ScriptableObjects/CellPrefabs")]
    public class CellPrefabs : ScriptableObject
    {
        public Cell CellPrefab => _cellPrefab;
   
        [SerializeField] private Cell _cellPrefab;
    }
}