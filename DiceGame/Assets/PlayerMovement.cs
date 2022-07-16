using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var sideMovement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(sideMovement, 0, 0) * Time.deltaTime * MovementSpeed;

        var upMovement = Input.GetAxis("Vertical");
        Vector3 upMovementVector = new Vector3(0, upMovement, 0);
        transform.Translate(upMovementVector * Time.deltaTime * MovementSpeed);
    }

    /*void FixedUpdate()
    {
        moveparams = (horizontalMove, 0f, 0f);
        controller.Move(moveparams);
    }*/
}
