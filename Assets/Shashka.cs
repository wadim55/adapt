using UnityEngine;
using UnityEngine.EventSystems;

public class Shashka : MonoBehaviour, IDragHandler, IDropHandler, IBeginDragHandler
{
    [SerializeField] private GameObject grid;   //ссылка на Сетку, чтобы получить доступ к координатам ячеек доски
    private Vector2 _startPosition; // позиция шашки, перед тем как её потянули
    
    #region Drag работает когда тянем шашку
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    #endregion 

    #region BeginDrop срабатывает когда начинаем тянуть шашку
    public void OnBeginDrag(PointerEventData eventData)
    {
        _startPosition = transform.position;
    }
    #endregion
    
    #region Drop срабвтывает когда бросаем шашку
    public void OnDrop(PointerEventData eventData)
    {
        for (var i = 0; i < grid.GetComponent<Grid>()._cell.GetLength(0); i++)
        {
            for (var j = 0; j < grid.GetComponent<Grid>()._cell.GetLength(1); j++)
            {
                if ((Input.mousePosition - grid.GetComponent<Grid>()._cell[i, j].position).magnitude < 30)
                {
                    transform.position = grid.GetComponent<Grid>()._cell[i, j].position;
                    return;
                }
                else
                {
                    transform.position = _startPosition;
                } 
            }
        }
    }
    #endregion
    
}
