using UnityEngine.SceneManagement;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        var platform = collision.gameObject.GetComponent<Platform>();
        if(platform == null)
        {
            ReloadLevel();
        }
        else
        {
            switch (platform.type)
            {
                case PlatformType.Start:
                    Debug.Log("this thing is friendly");
                    break;
                case PlatformType.End:
                    LoadNextLevel();
                    break;



            }
        }
       
    }
    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

}
