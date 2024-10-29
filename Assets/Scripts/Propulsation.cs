using UnityEngine;

public class Propulsation : MonoBehaviour
{
    [SerializeField] float spaceshipSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * spaceshipSpeed);
    }
}
