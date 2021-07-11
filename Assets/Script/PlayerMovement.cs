using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    float moveX;
    float moveZ;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime);        
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        
        Vector2 movement = ctx.ReadValue<Vector2>();
        moveX = movement.x;
        moveZ = movement.y;// Y because vector2     
    }


}
