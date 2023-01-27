using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cube : MonoBehaviour
{
    public int score;
    [SerializeField] Text scoreText;

    public int point;
    [SerializeField] TextMeshPro pointText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bad Cube")
        {
            GameManager.gameOver = true;
            gameObject.SetActive(false);
        }

        if (collision.transform.tag == "Cube 1")
        {
            Destroy(collision.gameObject);
            score++;
            point--;                                   
        }

        if (collision.transform.tag == "Cube 2")
        {
            Destroy(collision.gameObject);
            point--;
        }        

        if (point <= 0)
        {
            GameManager.gameOver = true;
            gameObject.SetActive(false);
        }
                
        if (collision.transform.tag == "Point 1")
        {
            Destroy(collision.gameObject);
            point+= 1;            
        }        

        if (collision.transform.tag == "Finish")
        {
            Debug.Log("You Win!");
            GameManager.youWin = true;
            gameObject.SetActive(false);
        }
    }
    
    private void Update()
    {
        scoreText.text = score.ToString();
        pointText.text = point.ToString();
    }
}