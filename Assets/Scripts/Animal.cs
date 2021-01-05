using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    //public Tile tile00;
    public List<Tile> tileList = new List<Tile>();

    // Start is called before the first frame update
    void Start()
    {
        //tile00 = GameObject.Find("test_tile").GetComponent<Tile>();
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
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("down");
            tileList[0].HighLight();
            tileList[1].HighLight();
            tileList[3].HighLight();
            tileList[5].HighLight();
        }
    }
}
