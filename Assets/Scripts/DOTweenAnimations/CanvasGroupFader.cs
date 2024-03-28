using DG.Tweening;
using UnityEngine;

namespace DOTweenAnimations
{
    public class CanvasGroupFader : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;
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
            _canvasGroup.DOFade(value, _fadeDuration);
        }
    }
}