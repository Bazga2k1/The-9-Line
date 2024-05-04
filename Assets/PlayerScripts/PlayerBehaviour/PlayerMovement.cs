using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 8.0f;  // Brzina kretanja
    public Rigidbody2D playerRB2D;  // Varijabla za referencu na komponentu igrača
    private Vector2 movementInput;  // Vector2 za primanje inputa za kretanje

    void Start()
    {

        playerRB2D = GetComponent<Rigidbody2D>();   // Određuje referencu na određenu komponentu, u ovom slučaju RB2D (pointer? =/= reference?)
    }

    void Update()
    {

        movementInput.x = Input.GetAxisRaw("Horizontal");    // Vodoravne ulazne kontrole    //    Krečeš se sa A & D
        movementInput.y = Input.GetAxisRaw("Vertical");    // Okomite ulazne kontrole    //    Krečeš se sa W & S

        movementInput.Normalize();    // Normalizira brzinu kretanja diagonalno. Kako bi izbjegli aplikaciju dviju sila koristimo Normalize().

        playerRB2D.velocity = movementInput * movementSpeed;    // Pokretanje igrača u smjeru po brzini postavljenoj u varijabli
    }
}