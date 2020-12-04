using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelText : MonoBehaviour
{
    // Start is called before the first frame update
    Text Level;
    public int Levelscore;

    void Awake()
    {
        Level = GetComponent<Text>();
        Levelscore = Player.level;
    }

    // Update is called once per frame
    void Update()
    {
        Levelscore = Player.level;
        Level.text = Levelscore.ToString();
    }
}
