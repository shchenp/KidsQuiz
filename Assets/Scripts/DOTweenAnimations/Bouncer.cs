using DG.Tweening;
using UnityEngine;

namespace DOTweenAnimations
{
    public class Bouncer : MonoBehaviour
    {
        [SerializeField] private float _bounceDuration;

        private float _defaultScale;
        private float _step;

        private void Awake()
        {
            _defaultScale = transform.lossyScale.x;
        
            _step = _bounceDuration / 4f;
        }

        public void Bounce()
        {
            var sequence = DOTween.Sequence();

            sequence.Append(transform.DOScale(0, _step));
            sequence.Append(transform.DOScale(_defaultScale * 1.2f, _step));
            sequence.Append(transform.DOScale(_defaultScale * 0.95f, _step));
            sequence.Append(transform.DOScale(_defaultScale, _step));
        }
    }
}