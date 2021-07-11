using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    
    [SerializeField]
    float speed;
    private void Start()
    {
        Invoke("TimeOut", 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    void TimeOut()
    {
        Destroy(gameObject);
    }
}
