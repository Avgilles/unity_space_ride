using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPLayer : MonoBehaviour
{
    public Transform player;
    public float speed;
    public Transform camera;
    public int distanceCam= 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ciblePos = new Vector3(player.position.x, distanceCam, player.position.z);
        Vector3 CamPos = new Vector3(camera.position.x,camera.position.y,camera.position.z);
        transform.position = Vector3.Lerp(CamPos, ciblePos, Time.deltaTime);

    }
}
