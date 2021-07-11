using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    Transform spawnPoint;

    public void OnFire(InputAction.CallbackContext ctx)
    {
        
        GameObject bulletRef = Instantiate(bullet, spawnPoint);
        bulletRef.transform.parent = null;
        
    }

    
}
