using System;
using System.Collections;
using DOTweenAnimations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameHandlers
{
    public class GameRestarter : MonoBehaviour
    {
        [SerializeField] private Slider _loadingSlider;
        [SerializeField] private CanvasGroupFader _loadingsScreenCanvasGroupFader;
        [SerializeField] private UnityEvent _onGameRestarded;

        public void RestartGame()
        {
            _onGameRestarded?.Invoke();
            
            StartCoroutine(LoadSceneAsync());
        }

        private IEnumerator LoadSceneAsync()
        {
            yield return StartCoroutine(PlayEffectRoutine(_loadingsScreenCanvasGroupFader.FadeIn));
            
            var loadingOperation = SceneManager.LoadSceneAsync(GlobalConstants.SCENE_NAME);
            loadingOperation.allowSceneActivation = false;

            while (!loadingOperation.isDone)
            {
                _loadingSlider.value = loadingOperation.progress / 0.9f;
                yield return null;

                if (_loadingSlider.value == 1)
                {
                    yield return StartCoroutine(PlayEffectRoutine(_loadingsScreenCanvasGroupFader.FadeOut));
                    
                    yield return null;
                    
                    loadingOperation.allowSceneActivation = true;
                }
            }
        }

        private IEnumerator PlayEffectRoutine(Action action)
        {
            action?.Invoke();
            
            var duration = _loadingsScreenCanvasGroupFader.FadeDuration;
            var time = 0f;

            while (time < duration)
            {
                time += Time.deltaTime;

                yield return null;
            }
        }
    }
}