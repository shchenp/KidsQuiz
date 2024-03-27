using System.Collections;
using System.Collections.Generic;
using CardHandlers;
using DG.Tweening;
using UnityEngine;

namespace CellHandlers
{
    public class CellsController : MonoBehaviour
    {
        [SerializeField] private CardBundleHandler _cardBundle;
    
        private readonly List<Cell> _cells = new List<Cell>();
    
        public void Add(Cell cell)
        {
            _cells.Add(cell);

            var cardData = _cardBundle.GetNewCard();
        
            cell.SetCardData(cardData);
        }

        public void ResetCellsList()
        {
            foreach (var cell in _cells)
            {
                Destroy(cell);
            }
        }

        public void ShowCells()
        {
            foreach (var cell in _cells)
            {
                cell.transform.DOScale(new Vector3(0, 0, 0), 0);
            }

            StartCoroutine(BounceCells());
        }

        private IEnumerator BounceCells()
        {
            foreach (var cell in _cells)
            {
                cell.Bounce();

                yield return new WaitForSeconds(0.5f);
            }

            yield return null;
        }
    }
}