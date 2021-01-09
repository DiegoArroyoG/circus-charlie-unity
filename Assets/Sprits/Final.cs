using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject[] prefabs;

    public void Spawn(int index)
    {
        Instantiate(prefabs[index], Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Final").transform);
    }
}
