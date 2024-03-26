using Extensions;
using ScriptableObjects;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _cardSpriteRenderer;
    [SerializeField] private SpriteRenderer _backgroundSpriteRenderer;
    
    [SerializeField] private CardData _cardData;

    private void Awake()
    {
        _backgroundSpriteRenderer.SetRandomColor();
        
        _cardSpriteRenderer.sprite = _cardData.Sprite;
        
        if (_cardData.IsNeedToRotate)
        {
            transform.Rotate(_cardData.Rotation);
        }
    }
}