using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPLayer : MonoBehaviour
{
    public Transform player;
    public float speed;
    public int distanceCam= 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ciblePos = player.position;
        transform.position = new Vector3(ciblePos.x, distanceCam, ciblePos.z);

    }
}
