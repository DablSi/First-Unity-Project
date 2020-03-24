using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    private int direction = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // If working with the physics use FixedUpdate()
    void FixedUpdate()
    {
        // deltaTime is used for force to be the same throughout different FPS
        rb.AddForce(sidewaysForce * direction * Time.deltaTime, 0, forwardForce * Time.deltaTime);
    }

    // If we are working with user input it's better to use Update() to avoid dela
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            direction = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction = -1;
        }
        else
        {
            direction = 0;
        }
    }
}
