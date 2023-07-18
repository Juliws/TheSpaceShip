using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public GameObject lose;
    public GameObject pauseBtn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            lose.SetActive(true);
            pauseBtn.SetActive(false);
            Pausa();
        }
    }
    public void Pausa()
    {
        Time.timeScale = 0f;
    }
}
