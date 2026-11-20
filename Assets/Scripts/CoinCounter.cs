using UnityEngine;
using TMPro;
public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public GameObject timerText;
    public int coinCollected;
    public bool done = false;

    void Update()
    {
        if (done == true)
        {
            timerText.SetActive(true);
            gameObject.GetComponent<UnityEventAfterTimer>().StartTimer();
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
        }
        else
        {
            done = false;
            coinCollected++;
        }
    }
}
