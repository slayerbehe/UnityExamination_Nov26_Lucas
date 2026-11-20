using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void SwapToFirstScene()
    {
        SceneManager.LoadScene("FirstLevel");
    }
    
    public void SwapToSecondScene()
    {
        SceneManager.LoadScene("SecondLevel");
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
