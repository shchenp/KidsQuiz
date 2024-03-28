using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ParticleHandler : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private UnityEvent _particleStopped;

    public void PlayOnPosition(Vector3 position)
    {
        transform.position = position;
        
        _particle.Play();

        StartCoroutine(CheckParticlePlaying());
    }

    private IEnumerator CheckParticlePlaying()
    {
        while (_particle.isPlaying)
        {
            yield return null;
        }
        
        _particleStopped.Invoke();
    }
}