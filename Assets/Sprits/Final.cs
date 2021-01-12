using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject[] prefabs;

    public void Spawn(int index)
    {
        if(index == 0)//cordinadores
        {
            Instantiate(prefabs[0], Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
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
    }
}
