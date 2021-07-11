using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCamera : MonoBehaviour
{
    public GameObject target;
     Vector3 offset;

    void Start()
    {
        GameObject.Find("Main Camera").transform.position = new Vector3(205, 26, -10);
        offset = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        
          Vector3 desiredPosition = target.transform.position + offset;
          transform.position = desiredPosition;
          transform.LookAt(target.transform.position);
    }
}
