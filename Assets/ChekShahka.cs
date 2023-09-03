using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekShahka : MonoBehaviour
{
   [SerializeField] private GameObject[] Shahka;
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
   }
}
