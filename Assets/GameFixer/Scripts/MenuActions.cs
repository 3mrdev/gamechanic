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
        SceneManager.LoadScene(6);
    }

    public void GoLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void ZoomTwo()
    {
        SceneManager.LoadScene(5);
    }

    public void ZoomThree()
    {
        SceneManager.LoadScene(2);
    }

    public void Computer()
    {
        SceneManager.LoadScene(7);
    }
}
