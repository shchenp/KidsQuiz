using UnityEngine;

public class ParticleHandler : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle;

    public void PlayOnPosition(Vector3 position)
    {
        transform.position = position;
        
        _particle.Play();
    }
}
