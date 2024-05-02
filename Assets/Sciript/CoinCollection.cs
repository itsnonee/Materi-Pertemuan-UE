using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    private int coinCount = 0;
    public TextMeshProUGUI scoreText;
    public GameObject canvasGame;

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
            
            if (coinCount == 5 && canvasGame != null)
            {
                canvasGame.SetActive(true);
            }

            // Tampilkan jumlah koin di konsol
            Debug.Log("Total coins collected: " + coinCount);
        }
    }
}

