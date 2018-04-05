using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Text crystals;
    public Text scrap;
    public Text antymatter;

    public int crystalsCount;
    public int scrapCount;
    public int antymatterCount;

    void Update ()
    {
        crystals.text = string.Format("Kryształy: {0}", crystalsCount);
        scrap.text = string.Format("Złom: {0}", scrapCount);
        antymatter.text = string.Format("Antymateria: {0}", antymatterCount);
    }

    public void AddCurrency(int id, int value)
    {
        switch (id)
        {
            case 0:
                crystalsCount += value;
                break;
            case 1:
                scrapCount += value;
                break;
            case 2:
                antymatterCount += value;
                break;
        }
    }
}
