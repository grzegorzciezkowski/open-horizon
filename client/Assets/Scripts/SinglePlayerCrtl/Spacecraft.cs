using UnityEngine;

public class Spacecraft : MonoBehaviour
{
    public float Acceleration = 10;
    public float Deceleration = 10;
    public float MaximumSpeed = 10;
    public float Agility = 100;
    public float Speed;

    private Rigidbody rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Accelerate()
    {
        Speed += Acceleration * Time.deltaTime;
        if (MaximumSpeed < Speed)
        {
            Speed = MaximumSpeed;
        }

        rb.linearVelocity = transform.forward * Speed;
    }

    public void Decelerate()
    {
        Speed -= Deceleration * Time.deltaTime;
        if (Speed < 0)
        {
            Speed = 0;
        }

        rb.linearVelocity = transform.forward * Speed;
    }

    public void TurnRight()
    {
        float deltaVelocityY = Agility * Time.deltaTime;

        rb.transform.eulerAngles += new Vector3(0, deltaVelocityY, 0);
        rb.linearVelocity = transform.forward * Speed;
    }

    public void TurnLeft()
    {
        float deltaVelocityY = -Agility * Time.deltaTime;

        rb.transform.Rotate(new Vector3(0, deltaVelocityY, 0), Space.World);
        rb.linearVelocity = transform.forward * Speed;
    }

    public void PullUp()
    {
        float deltaVelocityX = -Agility * Time.deltaTime;

        rb.transform.Rotate(new Vector3(deltaVelocityX, 0, 0), Space.Self);
        rb.linearVelocity = transform.forward * Speed;
    }

    public void PullDown()
    {
        float deltaVelocityX = Agility * Time.deltaTime;

        rb.transform.Rotate(new Vector3(deltaVelocityX, 0, 0), Space.Self);
        rb.linearVelocity = transform.forward * Speed;
    }
}
