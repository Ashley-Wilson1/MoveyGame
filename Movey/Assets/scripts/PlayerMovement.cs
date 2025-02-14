using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rb;
    // Start is called before the first frame update
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public Transform pos;
    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")|| Input.GetKey("right"))
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void Update()
    {
        if (pos.position.z.ToString("0").Equals("1700"))
        {
            forwardForce += 500f;
        }
    }
    
}
