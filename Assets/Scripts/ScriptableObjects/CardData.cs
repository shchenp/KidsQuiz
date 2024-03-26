using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "CardData", menuName = "ScriptableObjects/CardData")]
    public class CardData : ScriptableObject
    {
        public string Name => _name;
        public Sprite Sprite => _sprite;
        public bool IsNeedToRotate => _isNeedToRotate;
        public Vector3 Rotation => _rotation;
    
        [SerializeField] private string _name;
        [SerializeField] private Sprite _sprite;
        [SerializeField] private bool _isNeedToRotate;
        [SerializeField] private Vector3 _rotation;
    }
}