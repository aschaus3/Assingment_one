using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delay;  //Allows us to change this variable direclty in unity

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("MiniGame");
    }
}
