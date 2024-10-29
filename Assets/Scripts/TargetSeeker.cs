using UnityEngine;

public class TargetSeeker : MonoBehaviour
{

    [SerializeField] Transform objetoTarget;

    void Start()
    {
        
    }

    void Update()
    {
        transform.LookAt(objetoTarget);
    }
}
