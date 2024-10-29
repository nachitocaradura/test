using UnityEngine;

public class NaveSystem : MonoBehaviour
{

    Vector3 initPos;
    [SerializeField] Vector3 Desplazamiento;
    Vector3 finalPos;

    Vector3 initRot;
    [SerializeField] Vector3 Rotacion;
    Vector3 finalRot;


    public float Velocidad = 1;
    void Start()
    {
    }


    void Update()

    {
        initPos = transform.position;
        finalPos = initPos + Desplazamiento * Time.deltaTime * Velocidad;
        transform.position = finalPos;

        transform.Rotate(Rotacion * Time.deltaTime * Velocidad);

    }
}