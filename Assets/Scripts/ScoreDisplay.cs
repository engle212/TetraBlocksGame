using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMPro.TextMeshPro>().text = "Score: 000000";
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshPro>().text = "Score: " + FindObjectOfType<Game>().GetScore();
    }
}
