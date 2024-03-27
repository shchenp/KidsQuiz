using DG.Tweening;
using UnityEngine;

namespace DOTweenAnimations
{
    public class Fader : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _cellSpriteRenderer;
        [SerializeField] private SpriteRenderer _cardSpriteRenderer;
        [SerializeField] private SpriteRenderer _backgroundSpriteRenderer;

        [SerializeField] private float _fadeDuration;

        public void FadeIn()
        {
            Fade(1);
        }

        public void FadeOut()
        {
            Fade(0);
        }

        private void Fade(float value)
        {
            var sequence = DOTween.Sequence();
            sequence.Append(_cardSpriteRenderer.DOFade(value, _fadeDuration));
            sequence.Join(_cellSpriteRenderer.DOFade(value, _fadeDuration));
            sequence.Join(_backgroundSpriteRenderer.DOFade(value, _fadeDuration));
        }
    }
}