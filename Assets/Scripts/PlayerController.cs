using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float spaceshipDesplSpeed = 19;
    [SerializeField] float spaceshipRotation = 50;
    void Start()
    {
        
    }


    void Update()
    {

        float desplx = Input.GetAxis("Horizontal");
        Debug.Log(Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.right * desplx * Time.deltaTime * spaceshipDesplSpeed);
        transform.Rotate(Vector3.back * desplx * Time.deltaTime * spaceshipDesplSpeed); /*Esto lo puedes quitar dani*/

        float desply = Input.GetAxis("Vertical");
        Debug.Log(Input.GetAxis("Vertical"));
        transform.Translate(Vector3.up * desply * Time.deltaTime * spaceshipDesplSpeed);
        transform.Rotate(Vector3.left * desply * Time.deltaTime * spaceshipDesplSpeed); /*Esto lo puedes quitar dani*/

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * spaceshipRotation);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * spaceshipRotation);
        }
    }
}
