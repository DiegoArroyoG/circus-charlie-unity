using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject[] prefabs;

    public void Spawn(int index)
    {
        if(index == 0 || index == 20 || index == 28 || index == 48)//cordinadores
        {
            Instantiate(prefabs[0], new Vector3(-2, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[20], new Vector3(2, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[28], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[48], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 5 || index == 7)
        {
            Instantiate(prefabs[5], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[7], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 2 || index == 6)
        {
            Instantiate(prefabs[2], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[6], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 3 || index == 4)
        {
            Instantiate(prefabs[3], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[4], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 8 || index == 1)
        {
            Instantiate(prefabs[8], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[1], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 9)
        {
            Instantiate(prefabs[9], Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 22 || index == 23)
        {
            Instantiate(prefabs[22], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[23], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 10 || index == 13)
        {
            Instantiate(prefabs[10], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[13], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 14 || index == 16)
        {
            Instantiate(prefabs[14], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[16], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 19 || index == 21)
        {
            Instantiate(prefabs[19], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[21], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 17 || index == 18)
        {
            Instantiate(prefabs[17], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[18], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 11 || index == 15 || index == 12)
        {
            Instantiate(prefabs[11], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[15], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[12], new Vector3(0, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 31 || index == 24)
        {
            Instantiate(prefabs[31], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[24], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 25 || index == 33)
        {
            Instantiate(prefabs[25], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[33], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 30 || index == 27)
        {
            Instantiate(prefabs[30], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[27], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 29 || index == 26 || index == 32)
        {
            Instantiate(prefabs[29], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[26], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[32], new Vector3(0, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 36 || index == 37)
        {
            Instantiate(prefabs[36], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[37], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 39 || index == 42)
        {
            Instantiate(prefabs[38], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[42], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 43 || index == 46)
        {
            Instantiate(prefabs[43], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[46], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 45 || index == 34)
        {
            Instantiate(prefabs[45], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[34], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 35 || index == 40)
        {
            Instantiate(prefabs[35], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[40], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 47 || index == 44)
        {
            Instantiate(prefabs[47], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[44], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
        else if(index == 38 || index == 41)
        {
            Instantiate(prefabs[38], new Vector3(-1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
            Instantiate(prefabs[41], new Vector3(1, 0, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
        }
    }
}
