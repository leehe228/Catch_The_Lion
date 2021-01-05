using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControll : MonoBehaviour
{
    public bool checkStateFlag;

    public List<Tile> tileList = new List<Tile>();

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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHighLight(string animal, int x, int y)
    {
        switch (animal)
        {
            case "chick":
                {

                }
        }
    }
}
