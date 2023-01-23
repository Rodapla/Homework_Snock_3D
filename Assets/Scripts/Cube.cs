using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    //
    public int score;
    [SerializeField] Text scoreText;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Bad Cube")
        {
            Debug.Log("Game Over");
            GameManager.gameOver = true;
            gameObject.SetActive(false);
        }
        //
        if(collision.transform.tag == "Good Cube")
        {
            Destroy(collision.gameObject);
            score++;
        }

        if (collision.transform.tag == "Finish")
        {
            Debug.Log("You Win!");
            GameManager.youWin = true;
            gameObject.SetActive(false);
        }
    }

    //
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}