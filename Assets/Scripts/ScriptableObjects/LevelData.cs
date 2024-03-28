using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Level", menuName = "ScriptableObjects/Level")]
    public class LevelData : ScriptableObject
    {
        public Vector2 MatrixDimension => _matrixDimension;
        
        [SerializeField] private string _name;
        [SerializeField] private Vector2 _matrixDimension;
    }
}