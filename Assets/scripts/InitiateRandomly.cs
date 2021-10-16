using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateRandomly : MonoBehaviour
{
    public Transform pos;
    public GameObject[] objectToInitiate;


    // Start is called before the first frame update
    void Start()
    {
        InstantiateObject();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InstantiateObject()
    {
        int n = Random.Range(0, objectToInitiate.Length);
        GameObject g = Instantiate(objectToInitiate[n], pos.position, objectToInitiate[n].transform.rotation);
    }
}
