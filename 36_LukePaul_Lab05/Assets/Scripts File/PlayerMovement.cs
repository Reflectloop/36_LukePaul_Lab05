using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public Rigidbody playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(MoveHorizontal, 0, MoveVertical);
        transform.Translate(movement * Time.deltaTime * speed);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Killbrick")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
