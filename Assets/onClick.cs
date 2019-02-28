using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour {

    static public int i = 0, j = 0;
    public GameObject x, o, thisPlate;
    public bool checkClicked = false;
    private Vector3 pos;
    bool gameWon = false;
    static public char[,] table = new char[3,3];
    int xCount = 0, oCount = 0;
    // Use this for initialization
    void Start () {
        pos = thisPlate.transform.position;
        pos.z = -1;
	}
	
	// Update is called once per frame
	void Update () {
        if(table[0,0] == 'x' && table[0,0] == table[0,1] && table[0, 1] == table [0, 2])
        {
            Debug.Log("X WON!!");
        }
    }
    void OnMouseDown()
    {
        if (i%2==0 && !checkClicked)
        {
            Instantiate(x, pos, Quaternion.identity);
            
            checkClicked = true;
            
            table[j, i%3] = 'x';
            Debug.Log(i);
            Debug.Log(table[j, i%3]);
            i++;
            if (i % 3 == 0)
                j++;
        }
        else if(i%2!=0 && !checkClicked)
        {
            Instantiate(o, pos, Quaternion.identity);
            
            checkClicked = true;
            
            table[j, i%3] = 'o';
            Debug.Log(i);
            Debug.Log(table[j,i%3]);
            i++;
            if (i % 3 == 0)
                j++;
        }
    }
}
