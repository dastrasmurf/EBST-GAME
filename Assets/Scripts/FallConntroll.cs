using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallConntroll : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene(0);

        }
        else
        {
            Destroy(other.gameObject);
            //D��man yok oldu yeni d��man olu�turaca��z.
            GameManager.Instance.EnemyDestroyed();
        }
    }


}
