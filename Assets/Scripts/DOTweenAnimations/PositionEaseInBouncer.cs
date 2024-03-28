using DG.Tweening;
using UnityEngine;

namespace DOTweenAnimations
{
    public class PositionEaseInBouncer : MonoBehaviour
    {
	    [SerializeField] private float _duration;

	    private Vector3 _defaultPosition;

	    private void Awake()
	    {
		    _defaultPosition = transform.position;
	    }

	    public void EaseInBounce()
	    {
		    var sequence = DOTween.Sequence();
		    
		    sequence.Append(transform.DOLocalMoveX(0.25f, _duration / 2).SetEase(Ease.InBounce));
		    sequence.Append(transform.DOMove(_defaultPosition, _duration / 2));
	    }
    }
}