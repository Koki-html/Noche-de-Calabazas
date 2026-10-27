using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void OnPointerClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }
}
