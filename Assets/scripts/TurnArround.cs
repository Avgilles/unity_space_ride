using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnArround : MonoBehaviour
{
    public float nbr = .5f;
    public Transform target;
    public float speed = 2.0f;

    //public GameObject target;
    // Vector3 monVector = new Vector3(0,nbr,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + new Vector3(0,1,0);
        // transform.rotation = transform.rotation + new Vector3(0,1,0);

        // Quaternion target = Quaternion.Euler(60, 0, 0);
        // transform.rotation = Quaternion.Slerp(transform.rotation, target, 1);
        // transform.eulerAngles = new Vector3(60,0,0);
        // transform.localScale = transform.localScale + new Vector3(0,5,0);

        // transform.LookAt(target);
        //transform.LookAt(new Vector3(0,0,0));
        // transform.Translate(1,0,0);

        //transform.RotateAround(target.transform.position, Vector3.up, 20* Time.deltaTime* speed);
        foreach (Transform child in transform)
        {
            child.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);
        }
    }
}
