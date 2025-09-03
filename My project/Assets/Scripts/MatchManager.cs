using UnityEngine;

public class MatchManager : MonoBehaviour
{
    public static MatchManager instance;
    private int litCandleCount = 0;
    public int totalCandle = 14;
    public GameObject candleCanvas;
    public GameObject chest;

    public Animator chestAnimator;
    private bool isOpen = false;

    private void Awake()
    {
        instance = this;
    }

    public void AddLitCandle()
    {

        litCandleCount++;
        UIManager.Instance.UpdateScoreUI(litCandleCount,totalCandle);
        if (litCandleCount >= totalCandle)
        {
            OpenChest();
        }
    }

    private void OpenChest()
    {
        if (!isOpen)
        {
            chestAnimator.SetBool("IsOpen", true);
            isOpen = true;
            candleCanvas.SetActive(false);
        }
    }
}
