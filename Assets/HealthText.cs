using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class HealthText : MonoBehaviour
{
    // Start is called before the first frame update
    Text Health;
    public int Healthscore;

    void Awake()
    {
        Health = GetComponent<Text>();
        Healthscore = Player.health;
    }

    // Update is called once per frame
    void Update()
    {
        Healthscore = Player.health;
        Health.text = Healthscore.ToString();
    }
}
