using UnityEngine;

namespace GameCore.Player
{
    public class UnitsRecruitement : MonoBehaviour
    {
        bool notFree = false;
        int rayRange = 1000;
        public Object Ergatis;
        Vector3 position = new Vector3(70, 5, 50); //do wywalenia jak bedzie system stawiania budynkow

        private void Start()
        {
            Vector3 position = transform.position;
            position.z = position.z - 10;
        }

        void Update()
        {
            if (transform.GetChild(0).gameObject.activeSelf)
            {
                if (Input.GetKeyUp(KeyCode.E))
                {
                    Instantiate(Ergatis, position, transform.rotation);
                }
            }
        }
    }
}