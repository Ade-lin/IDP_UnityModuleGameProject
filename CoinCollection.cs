using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int coin = 0;
    public TextMeshProUGUI coinText;

	private void OnTriggerEnter(Collider other)
	{
	    if (other.transform.tag == "Coin")
        {
            coin++;
            coinText.text = "Food: " + coin.ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
    }

}
