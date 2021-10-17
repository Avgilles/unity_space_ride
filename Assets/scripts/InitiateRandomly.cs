using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateRandomly : MonoBehaviour
{
    public Transform pos;
    public GameObject[] objectToInitiate;
    public int nbrAsteroide = 20;
    private Vector3 posVector3;
    private int count;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(count);

        for (count=0; count < nbrAsteroide; count++)
        {
            InstantiateObject();
            Debug.Log(count);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 randomPos(int min,int max)
    {
        int randomPx = UnityEngine.Random.Range(min, max);
        int randomPz = UnityEngine.Random.Range(min, max);
        Vector3 result = new Vector3(randomPx, 0, randomPz);
        return result;
    }

    private void InstantiateObject()
    {
        Vector3 Rpos = randomPos(-10, 10);

        int n = Random.Range(0, objectToInitiate.Length);
        GameObject g = Instantiate(objectToInitiate[n], Rpos, objectToInitiate[n].transform.rotation);
    }
}
