using UnityEngine;

public class MoveRocket : MonoBehaviour
{

    float speed = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        float getVertical = Input.GetAxis("Vertical");
        speed += getVertical * 0.1f;

        transform.Translate(Vector3.up * Time.deltaTime * speed);

        float getHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, getHorizontal);
        
    }
}
