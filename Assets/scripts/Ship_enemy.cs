using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_enemy : MonoBehaviour
{
    public Transform planete1;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(transform.position.x, -8, transform.position.z);
        transform.position = Vector3.MoveTowards(pos, planete1.position , Time.deltaTime * speed);
    }
}
