using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour
{
    // Start is called before the first frame update
    public class StateHandler : MonoBehaviour
    {
        void Awake()
        {

            string keyName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name + gameObject.name;
            if (PlayerPrefs.GetInt(keyName) == 0 && gameObject.name != "Hair2")
                gameObject.SetActive(false);
        }
        public void SetActiveState(bool state)
        {
            
        }
    }
}
