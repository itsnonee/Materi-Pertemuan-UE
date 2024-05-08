using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    [Header("Text Score")]
    public TextMeshProUGUI scoreText;
    public GameObject canvasGame;

    [Header("Audio Score")]
    public AudioSource audioSource;
    public AudioClip audioCoin;
    public AudioClip audioWin;

    private int coinCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Pastikan objek yang menyentuh memiliki tag "Coin"
        if (other.CompareTag("Coin"))
        {
            // Tambahkan jumlah koin
            coinCount++;

            // Hancurkan objek koin
            Destroy(other.gameObject);

            // Perbarui skor pada UI Canvas
            
            scoreText.text = "Coin: " + coinCount.ToString();
            
            // Kondisi saat menang
            if (coinCount == 5 && canvasGame != null)
            {
                // Aktifkan ui dan suara
                canvasGame.SetActive(true);
                audioSource.PlayOneShot(audioWin);

                // Pause game
                Time.timeScale = 0;
            }

            // Tampilkan jumlah koin di konsol
            Debug.Log("Total coins collected: " + coinCount);

            // Mengaktifkan suara
            audioSource.PlayOneShot(audioCoin);
        }
    }
}

