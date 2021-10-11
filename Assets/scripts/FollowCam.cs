using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform ObjectA;
    public Transform ObjectB;

    // Start is called before the first frame update
    void Start()
    {
        float dis = Vector3.Distance(ObjectA.position, ObjectB.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
