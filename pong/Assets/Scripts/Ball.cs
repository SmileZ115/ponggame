using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 5f;
    void Start()
    {
        float SpeedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float SpeedY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(Speed * SpeedX, Speed * SpeedY, 0f);
    }
    void Update()
    {
        
    }
}
