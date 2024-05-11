using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction;
    public float speed = 5;
    public GameObject panelLose;
    public AudioSource audioSource;
    public AudioClip audioLose;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("wasd");

        // Mematikan cursor ketika Game dimulai
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }


    void Update()
    {
        // Memanggil metode MovePlayer
        MovePlayer();
    }

    // Motode untuk Menggerakan Player
    void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * speed * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        // Melakukan pengecekan jika objek Player menyentuh objek yang memiliki tag "Enemy", maka jalankan kode di bawah
        if (other.CompareTag("Enemy"))
        {
            // Mengaktifkan panel Lose 
            panelLose.SetActive(true); // Kondisi kalah karena menyentuh Enemy
            
            // Mengaktifkan suara ketika kalah
            audioSource.PlayOneShot(audioLose);
            
            // Pause game
            Time.timeScale = 0;
            
            // Menampilkan kembali cursor
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
