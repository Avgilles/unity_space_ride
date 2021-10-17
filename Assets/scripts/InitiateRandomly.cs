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

    public Vector2 beetween1;
    public Vector2 beetween2;
    public Vector2 beetween3;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(count);

        for (count=0; count < nbrAsteroide; count++)
        {
            InstantiateObject();
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 randomVector3(Vector2 axe_x, Vector2 axe_z, Vector2 axe_y = default(Vector2))
    {
        float randomPx = UnityEngine.Random.Range(axe_x.x, axe_x.y);
        float randomPy = UnityEngine.Random.Range(axe_y.x, axe_y.y);
        float randomPz = UnityEngine.Random.Range(axe_z.x, axe_z.y);

        Vector3 result = new Vector3(randomPx, randomPy, randomPz);
        return result;
    }

    private void InstantiateObject()
    {
        Vector3 Rpos = randomVector3(beetween1, beetween3);

        int n = Random.Range(0, objectToInitiate.Length);
        GameObject g = Instantiate(objectToInitiate[n], Rpos, objectToInitiate[n].transform.rotation);
    }
}
