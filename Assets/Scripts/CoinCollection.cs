using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject panelWin;

    public AudioSource audioSource;
    public AudioClip audioCoin;
    public AudioClip audioWin;
    private int coinCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Melakukan pengecekan jika objek Player menyentuh objek yang memiliki tag "Coin", maka jalankan kode di bawah
        if (other.CompareTag("Coin"))
        {
            // Tambahkan jumlah coin
            coinCount++;

            // Hancurkan objek coin
            Destroy(other.gameObject);

            // Perbarui skor pada UI Canvas
            scoreText.text = "Coin: " + coinCount.ToString();

            // Ketika coin terkumpul sebanyak 5 dan objek panel Win tidak sama dengan null, maka jalankan kode di bawah
            if (coinCount == 5 && panelWin != null) // kondisi menang
            {
                // Aktifkan Panel Menang dan Suara ketika Menang
                panelWin.SetActive(true);
                audioSource.PlayOneShot(audioWin);

                // Pause game
                Time.timeScale = 0;

                // Menampilkan kembali cursor
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            // Tampilkan jumlah koin di console
            Debug.Log("Total coins collected: " + coinCount);

            // Mengaktifkan suara setiap kali menyentuh coin
            audioSource.PlayOneShot(audioCoin);
        }
    }
}

