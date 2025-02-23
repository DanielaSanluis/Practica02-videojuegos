using Unity.VisualScripting;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad;
    public float movimientoVertical;
    public float movimientoHorizontal;
    public Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal");
        movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(collision.gameObject);
        }
        Debug.Log(collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Enemigo")
        {
            Destroy(other.gameObject);
        }
    }
}
