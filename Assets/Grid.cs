using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    private Transform[,] _cell = new Transform[8,8];
    private int _numberCell;
    private float YPos = 350, XPos = -350;
    private bool key;
   private  void Awake()
    {
        for (var i=0; i<_cell.GetLength(0); i++)
        {
            for (var j = 0; j <_cell.GetLength(1); j++)
            {
                _cell[i,j] = transform.GetChild(_numberCell);
                _numberCell++;
                _cell[i,j].position = new Vector2(transform.position.x +XPos, transform.position.y + YPos);
                XPos += 100;
                if (key)
                {
                    _cell[i, j].gameObject.GetComponent<Image>().color = Color.black;
                }

                key = !key;
            }
            key = !key;
            XPos = -350;
            YPos -= 100;
        }
    }

   
}
