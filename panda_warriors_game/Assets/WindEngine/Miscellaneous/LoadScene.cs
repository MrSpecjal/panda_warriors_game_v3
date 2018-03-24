using UnityEngine;
using UnityEngine.SceneManagement;

namespace WindEngine.Miscellaneous.LevelMenagment
{
    [AddComponentMenu("WindEngine/Miscellaneous/LoadScene")]
    public class LoadScene : MonoBehaviour
    {
        public void LoadLevel(int level)
        {
            SceneManager.LoadScene(level);
        }        
    }
}