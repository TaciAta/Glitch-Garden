using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] int lives;
    Text lifeText;

    // Start is called before the first frame update
    void Start()
    {
        lifeText = GetComponent<Text>();
    }

    public void DecreasePlayerLife(int amount)
    {
        lives -= amount;
        if (lives <= 0)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            lifeText.text = lives.ToString();
        }
    }
}
