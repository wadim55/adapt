using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shashka : MonoBehaviour, IDragHandler, IDropHandler, IBeginDragHandler
{
    [SerializeField] private GameObject grid;   //ссылка на Сетку, чтобы получить доступ к координатам ячеек доски
    private Vector2 _startPosition; // позиция шашки, перед тем как её потянули

    private void Start()
    {
        _startPosition = transform.position;
    }
    
    
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
                if ((Input.mousePosition - grid.GetComponent<Grid>()._cell[i, j].position).magnitude < 30 && grid.GetComponent<Grid>()._cell[i, j].gameObject.GetComponent<Image>().color == Color.black && (_startPosition - (Vector2)grid.GetComponent<Grid>()._cell[i, j].position).magnitude < 150 && _startPosition.y - grid.GetComponent<Grid>()._cell[i, j].position.y < 0)
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
