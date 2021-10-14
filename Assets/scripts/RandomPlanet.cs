using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlanet : MonoBehaviour
{
    public int nbrSun = 0;
    public GameObject planettePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        float random = UnityEngine.Random.Range(0.0f, 10.0f);
        Debug.Log("start");
        Debug.Log(random);
    }
    private void spawnPlanet()
    {
        /*int randomP = UnityEngine.Random.Range(-10, 10);
        GameObjet a = Instantiate(planettePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x, screenBounds);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
