using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;
    private float jumpSpeed = 7;
    private bool onGround = true;
    private const int MAX_JUMP = 2;
    private int currentJump = 2;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
        if (Input.GetKeyDown("space") && (onGround || MAX_JUMP > currentJump))
        {
            rigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            onGround = false;
            currentJump++;
        }

       else if (transform.position.y < -6 || transform.position.y > 9.5)
        {
            transform.position += Vector3.down * Time.deltaTime * jumpSpeed;
            onGround = false;
            currentJump++;
        }

    }

     private void OnCollisionEnter(Collision other)
    {
        onGround = true;
        currentJump = 0;

        if (other.gameObject.CompareTag("Cube"))
        {
            Destroy(other.gameObject);
        }

       else if (other.gameObject.CompareTag("Capsule"))
        {
            rigidBody.constraints = RigidbodyConstraints.FreezePositionY;
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
