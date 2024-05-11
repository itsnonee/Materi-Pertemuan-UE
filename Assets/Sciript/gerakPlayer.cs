using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class gerakPlayer : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction;

    public float speed = 5;
    public GameObject canvasGame;

    public Transform pedang;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("wasd");
    }

 
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector2 direction= moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * speed * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        // Pastikan objek yang menyentuh memiliki tag "Coin"
        if (other.CompareTag("Enemy"))
        {
            canvasGame.SetActive(true);
        }
    }
}
