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
            //Düþman yok oldu yeni düþman oluþturacaðýz.
            GameManager.Instance.EnemyDestroyed();
        }
    }


}
