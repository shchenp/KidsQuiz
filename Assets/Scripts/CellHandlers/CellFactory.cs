using ScriptableObjects;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace CellHandlers
{
    public class CellFactory
    {
        private IObjectResolver _container;
        private CellPrefabs _cellPrefabs;

        public CellFactory(IObjectResolver container, CellPrefabs cellPrefabs)
        {
            _container = container;
            _cellPrefabs = cellPrefabs;
        }

        public Cell Create(Vector3 position)
        {
            return _container.Instantiate(_cellPrefabs.CellPrefab, position, Quaternion.identity);
        }
    }
}