using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{

    public void ZoomOne()
    {
        SceneManager.LoadScene(1);
    }

    public void GoLevel1()
    {
        SceneManager.LoadScene(2);
    }

}
