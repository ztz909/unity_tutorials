using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(35.0f, 2.0f, 1.0f);
    private Vector3 rotation_offset = new Vector3(0, -90.0f, 0);
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = rotation_offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
