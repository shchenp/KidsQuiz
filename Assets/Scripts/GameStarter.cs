using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private Cell _cellPrefab;

    private void Start()
    {
        Instantiate(_cellPrefab, transform);
    }
}
