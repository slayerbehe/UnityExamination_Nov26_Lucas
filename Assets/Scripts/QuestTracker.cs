using UnityEngine;

public class QuestTracker : MonoBehaviour
{
    
    public GameObject badGuy1;
    public GameObject badGuy2;
    public bool completed = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (!completed)
        {
            badGuy1.SetActive(true);
        }
        else
        {
            badGuy2.SetActive(true);
        }
    }
}
