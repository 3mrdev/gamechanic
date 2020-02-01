using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward = 2000f;
    public float sideways = 500f;

    public Joystick joystick;


    void Start()
    {
        if (Application.isMobilePlatform)
        {
            
        } else
        {
            joystick.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forward * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forward * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideways * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways * Time.deltaTime, 0, 0);
        }


        if (joystick.Horizontal >= 0.2f)
        {
            rb.AddForce(joystick.Horizontal * sideways * Time.deltaTime, 0, 0);
        }

        if (joystick.Horizontal <= 0.2f)
        {
            rb.AddForce(joystick.Horizontal * sideways * Time.deltaTime, 0, 0);
        }

        if (joystick.Vertical >= 0.2f)
        {
            rb.AddForce(0, 0, joystick.Vertical * forward * Time.deltaTime);
        }

        if (joystick.Vertical <= 0.2f)
        {
            rb.AddForce(0, 0, joystick.Vertical * forward * Time.deltaTime);
        }

    }
}
