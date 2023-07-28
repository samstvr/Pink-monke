using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{

    [SerializeField] private GameObject lookAt;
    private Transform objectToRotate;
    private Vector3 up = new Vector3(0, 0, 1);
    private Vector3 addedRotation = new Vector3(90, 90, 90);

    // Start is called before the first frame update
    void Start()
    {
        objectToRotate = transform;
    }

    // Update is called once per frame
    void Update()
    {
        objectToRotate.LookAt(lookAt.transform.position, Vector3.up);
        objectToRotate.transform.Rotate(addedRotation);
    }
}
