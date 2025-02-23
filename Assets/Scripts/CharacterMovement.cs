using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float velocidad;
    public Vector3 direccion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       direccion = Vector3.zero;
        
    }
}
