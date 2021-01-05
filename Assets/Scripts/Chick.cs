using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : MonoBehaviour
{
    public List<Tile> tileList = new List<Tile>();
    public int posX, posY;
    public bool onBoard;

    public GameControll controller = GameObject.Find("home").GetComponent<GameControll>();

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Tile tempTile = GameObject.Find("tile" + i.ToString() + j.ToString()).GetComponent<Tile>();
                tileList.Add(tempTile);
            }
        }
    }

    public void Init(int x, int y) 
    {
        posX = x;
        posY = y;

        onBoard = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("down");
            
        }
    }
}
