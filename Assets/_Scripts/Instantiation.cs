using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public GameObject myPrefab;  //refrence to prefab
    void Start()
    {

        Instantiate(myPrefab, new Vector3(7, (float).5, (float)2.5), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(7, (float).5, (float)-2.5), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-7, (float).5, (float)2.5), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-7, (float).5, (float)-2.5), Quaternion.identity);
        Instantiate(myPrefab, new Vector3((float)2.5, (float).5, 7), Quaternion.identity);
        Instantiate(myPrefab, new Vector3((float)2.5, (float).5, -7), Quaternion.identity);
        Instantiate(myPrefab, new Vector3((float)-2.5, (float).5, 7), Quaternion.identity);
        Instantiate(myPrefab, new Vector3((float)-2.5, (float).5, -7), Quaternion.identity);
    }

}
