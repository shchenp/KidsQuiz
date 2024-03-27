using ScriptableObjects;
using TMPro;
using UnityEngine;

namespace UI
{
    public class LevelWindow : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _targetName;

        public void OnTargetChanged(CardData cardData)
        {
            _targetName.text = cardData.Name;
        }
    }
}