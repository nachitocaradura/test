using UnityEngine;

public class GameOverSystem : MonoBehaviour
{
    [SerializeField] GameObject spaceship;

    void Start()
    {
        
    }

    void Update()
    {
        float PosY = spaceship.transform.position.y;
        if (PosY < -30)
        {
            spaceship.transform.position = Vector3.zero;
            print("depuracion");
        }

    }
}
