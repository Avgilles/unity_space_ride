using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour
{
    private Vector3 axe;
    private float random;
    private float randomX;
    private float randomY;
    private float randomZ;

    // Start is called before the first frame update
    void Start()
    {
        axe = new Vector3(0,0, 0);
        randomX = UnityEngine.Random.Range(-90.0f, 90.0f);
        randomY = UnityEngine.Random.Range(-90.0f, 90.0f);
        randomZ = UnityEngine.Random.Range(-90.0f, 90.0f);
    }

    // Update is called once per frame
    void Update()
    {
        axe = new Vector3(randomX +=0.04f *.5f, randomY += 0.015f * .5f, randomZ += 0.03f * .5f);
        transform.eulerAngles = axe;

    }
}
