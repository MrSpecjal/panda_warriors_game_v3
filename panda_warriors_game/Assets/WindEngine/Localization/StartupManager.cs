using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WindEngine.Localization
{
    public class StartupManager : MonoBehaviour
    {
        public int menuLevel;
        private IEnumerator Start()
        {
            while (!LocalizationManager.instance.GetIsReady())
            {
                yield return null;
            }

            SceneManager.LoadScene(sceneBuildIndex: menuLevel);
        }

    }
}