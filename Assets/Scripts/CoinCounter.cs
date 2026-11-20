using UnityEngine;
using TMPro;
public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    public int coinCollected;

    public bool done = false;

    void Update()
    {
        if (done == true)
        {
            Debug.Log("Bombodilo");
            done = false;
        }
        
        coinText.text = "Coins: " + coinCollected.ToString();
    }
    public void coinCollect()
    {
        if (coinCollected >= 2)
        {
            coinCollected++;
            done = true;
            Destroy(gameObject);
        }
        else
        {
            done = false;
            coinCollected++;
            Destroy(gameObject);
        }
    }
}
