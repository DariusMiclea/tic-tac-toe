using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClick : MonoBehaviour {

    static public int i = 0;
    public GameObject x, o, thisPlate;
    public bool checkClicked = false;
    private Vector3 pos;
    public int thisVal = -1;
    static public int[] table = new int[9];
    // Use this for initialization
    void Start () {
        pos = thisPlate.transform.position;
        pos.z = -1;
        for(int j = 0; j < table.Length; j++)
        {
            table[j] = -1;
        }
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnMouseDown()
    {
        if (i%2==0 && !checkClicked)
        {
            Instantiate(x, pos, Quaternion.identity);
            
            checkClicked = true;
            thisVal = 1;
            
            i++;
            
        }
        else if(i%2!=0 && !checkClicked)
        {
            Instantiate(o, pos, Quaternion.identity);
            
            checkClicked = true;
            thisVal = 10;
            i++;
        }
        
        table[int.Parse(this.name)] = thisVal;
        WinCheck(0, 1);
        WinCheck(3, 1);
        WinCheck(6, 1);
        WinCheck(0, 3);
        WinCheck(1, 3);
        WinCheck(2, 3);
        WinCheck(0, 4);
        WinCheck(2, 2);

        if (i > 8)
        {
            i = 0;
            SceneManager.LoadScene("Draw");
        }
    }

    void WinCheck(int start, int iterator)
    {
        int sum = table[start];
        int index = start;
        for (int l = 0; l < 2; l++)
        {
            
            index = index + iterator;
            sum = sum + table[index];
        }
        if (sum == 3)
        {
            i = 0;
            SceneManager.LoadScene("WinX");

        }
        else if (sum == 30)
        {
            i = 0;
            SceneManager.LoadScene("WinO");
        }
    }

    void Draw()
    {
        for(int j = 0; j < 9; j++)
        {
            //if()
        }
    }
}
