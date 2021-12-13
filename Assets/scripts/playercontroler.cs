using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody playerRigidbody;
    [SerializeField] private float JumpForce = 400f;
    public float gravityModifier = 1;
    private bool isOnTheGround = true;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround)
        {
            playerRigidbody.AddForce(Vector3.up * JumpForce);
            isOnTheGround = false;
        }
    }
    private void OnCollisionEnter(Collision otherCollider)
    {
        isOnTheGround = true;
    }
}
