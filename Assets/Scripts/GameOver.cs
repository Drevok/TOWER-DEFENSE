using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    void OnColliderEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Enemy"))
        //{
        Debug.Log("Perdu!");
        Application.Quit();
            
        //}
    }
}
