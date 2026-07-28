using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private  float _moveSpeed = 5f;

    public void Start()
    {
    }

    public void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}