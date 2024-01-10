using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinsCollection : MonoBehaviour
{

    private int Coin = 0;
    public TextMeshProUGUI coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coins"))
        {

            Coin++;
            coinText.text = "Coin: " + Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
            if (Coin == 4)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
