using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float MovementSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump"))
        {

        }
    }

    /*void FixedUpdate()
    {
        moveparams = (horizontalMove, 0f, 0f);
        controller.Move(moveparams);
    }*/
}
