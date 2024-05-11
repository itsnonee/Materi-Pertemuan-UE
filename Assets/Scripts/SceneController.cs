using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Metode untuk mengatur aksi tombol "Play Again"
    public void PlayAgain()
    {
        // Muat ulang scene saat ini (Gameplay) untuk memulai permainan kembali ketika tombol Play Again di klik
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        // Unpause Game
        Time.timeScale = 1.0f;
    }

    // Metode untuk mengatur aksi tombol "Main Menu"
    public void MainMenu()
    {
        // Pindah ke scene "MainMenu" ketika tombol Main Menu di klik
        SceneManager.LoadScene("MainMenu");
        
        // Unpause Game
        Time.timeScale = 1.0f;
    }

    // Metode untuk mengatur aksi tombol "Start"
    public void Play()
    {
        // Pindah ke scene "Gameplay" ketika tombol Play di klik
        SceneManager.LoadScene("Gameplay");
    }

    public void About()
    {
        Debug.Log("Ini button About");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
}
