using DG.Tweening;
using Extensions;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cell : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private SpriteRenderer _cellSpriteRenderer;
    [SerializeField] private SpriteRenderer _cardSpriteRenderer;
    [SerializeField] private SpriteRenderer _backgroundSpriteRenderer;
    
    private CardData _cardData;

    private void Awake()
    {
        _backgroundSpriteRenderer.SetRandomColor();
    }

    public void SetCardData(CardData cardData)
    {
        _cardData = cardData;
        
        Initialize();
    }

    private void Initialize()
    {
        _cardSpriteRenderer.sprite = _cardData.Sprite;
        
        if (_cardData.IsNeedToRotate)
        {
            transform.Rotate(_cardData.Rotation);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        var sequence = DOTween.Sequence();
        sequence.Append(_cardSpriteRenderer.DOFade(0, 1));
        sequence.Join(_cellSpriteRenderer.DOFade(0, 1));
        sequence.Join(_backgroundSpriteRenderer.DOFade(0, 1));
    }
}