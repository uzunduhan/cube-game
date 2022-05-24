using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
       //Debug.Log("merhaba dunya"); // console ekranına bişeyler yazmamıza izin verir
       //rb.useGravity = false; // yer çekimi özelliğini değiştirir
       //rb.AddForce(0,200,500);   //cismin konumunu değiştirir
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime); 

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
