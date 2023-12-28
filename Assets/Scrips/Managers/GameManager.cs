using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public GameObject crates_study_x2;

    private void Start()
    {
        Application.targetFrameRate = 60;
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        InvokeRepeating("MakcBox",0,3f);
    }
    void MakcBox()
    {
        if (crates_study_x2 != null)
        {
            float ran = Random.Range(0, 10);
            if (ran < 8)
            {
                Instantiate(crates_study_x2);
            }
        }
    }
}
