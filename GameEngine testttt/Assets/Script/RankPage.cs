using System.Linq;
using UnityEngine;
using TMPro;

public class RankPage : MonoBehaviour
{
    [SerializeField] Transform contentRoot;
    [SerializeField] GameObject rowPrefabs;

    StageResultList allData;

    int currentStage = 1;

    void Awake()
    {
        allData = StageResultSaver.LoadRank();
        RefreshRankList();
    }

    void RefreshRankList()
    {
        foreach (Transform child in contentRoot)
        {
            Destroy(child.gameObject);
        }

        var sortedData = allData.results
            .Where(r => r.stage == currentStage)
            .OrderByDescending(x => x.score)
            .ToList();

        for (int i = 0; i < sortedData.Count; i++)
        {
            GameObject row = Instantiate(rowPrefabs, contentRoot);

            TMP_Text rankText =
                row.GetComponentInChildren<TMP_Text>();

            rankText.text =
                $"{i + 1}. {sortedData[i].playerName} - {sortedData[i].score}";
        }
    }

    public void Stage1Button()
    {
        currentStage = 1;
        RefreshRankList();
    }

    public void Stage2Button()
    {
        currentStage = 2;
        RefreshRankList();
    }

    public void Stage3Button()
    {
        currentStage = 3;
        RefreshRankList();
    }

    public void Stage4Button()
    {
        currentStage = 4;
        RefreshRankList();
    }

    public void Stage5Button()
    {
        currentStage = 5;
        RefreshRankList();
    }
}