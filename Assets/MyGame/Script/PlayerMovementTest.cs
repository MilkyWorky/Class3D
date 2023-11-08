using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTest : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    [SerializeField]
    private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movementDirection = new Vector3 (horizontalInput, 0, verticalInput);
        print($"Vector Magninute before normalize: {movementDirection.magnitude}");
        movementDirection.Normalize();
        print($"Vector Magninute after normalize: {movementDirection.magnitude}");
        transform.Translate (movementDirection*moveSpeed*Time.deltaTime,Space.World);

        if(movementDirection != Vector3.zero )
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation,1* Time.deltaTime);
        }
    }
}
