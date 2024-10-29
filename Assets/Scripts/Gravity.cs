using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] float GravAcceleration = 9.81f;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * GravAcceleration);
    }
}
