using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class TileMap : MonoBehaviour
{
    public int i;
    public Grid[] tileMap = new Grid[1];
    public void Start()
    {
        Instantiate(tileMap[i]);
    }
}
