using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{

    private Vector3 angle = new Vector3(0, 1, 0);
    [SerializeField] [Range(0, 1)] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(angle*speed, Space.World);
    }
}
