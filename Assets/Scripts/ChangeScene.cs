using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Ini WAJIB ada untuk pindah scene

public class ChangeScene : MonoBehaviour
{
    // Fungsi ini akan dipanggil oleh tombol "Mulai Tur"
    public void MoveToScene(int sceneID)
    {
        // Pastikan nama "TourGWW_Scene" SAMA PERSIS dengan nama file scene VR-mu
        SceneManager.LoadScene(sceneID); // sceneID adalah nomor urut scene yang ingin dimuat
    }

    // Fungsi ini akan dipanggil oleh tombol "Keluar"
    public void KeluarAplikasi()
    {
        Application.Quit(); // Perintah ini untuk menutup aplikasi (hanya bekerja setelah di-build)
    }
}