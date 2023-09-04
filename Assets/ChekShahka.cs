using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekShahka : MonoBehaviour
{
   [SerializeField] private GameObject[] Shahka;
   [SerializeField] private GameObject[] ShahkaBlack;
   [SerializeField] private Grid _grid;

   private void Start()
   {
      Shahka[0].transform.position = _grid._cell[7, 0].position;
      Shahka[1].transform.position = _grid._cell[7, 2].position;
      Shahka[2].transform.position = _grid._cell[7, 4].position;
      Shahka[3].transform.position = _grid._cell[7, 6].position;
      Shahka[4].transform.position = _grid._cell[6, 1].position;
      Shahka[5].transform.position = _grid._cell[6, 3].position;
      Shahka[6].transform.position = _grid._cell[6, 5].position;
      Shahka[7].transform.position = _grid._cell[6, 7].position;
      Shahka[8].transform.position = _grid._cell[5, 0].position;
      Shahka[9].transform.position = _grid._cell[5, 2].position;
      Shahka[10].transform.position = _grid._cell[5, 4].position;
      Shahka[11].transform.position = _grid._cell[5, 6].position;
      ShahkaBlack[0].transform.position = _grid._cell[0, 1].position;
      ShahkaBlack[1].transform.position = _grid._cell[0, 3].position;
      ShahkaBlack[2].transform.position = _grid._cell[0, 5].position;
      ShahkaBlack[3].transform.position = _grid._cell[0, 7].position;
      ShahkaBlack[4].transform.position = _grid._cell[1, 0].position;
      ShahkaBlack[5].transform.position = _grid._cell[1, 2].position;
      ShahkaBlack[6].transform.position = _grid._cell[1, 4].position;
      ShahkaBlack[7].transform.position = _grid._cell[1, 6].position;
      ShahkaBlack[8].transform.position = _grid._cell[2, 1].position;
      ShahkaBlack[9].transform.position = _grid._cell[2, 3].position;
      ShahkaBlack[10].transform.position = _grid._cell[2, 5].position;
      ShahkaBlack[11].transform.position = _grid._cell[2, 7].position;
   }
}
