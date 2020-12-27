using UnityEngine;

namespace deVoid.UIFramework.Examples
{
    public class UIWordChefController : MonoBehaviour
    {
        private void Awake()
        {
            var result = Resources.Load<UIFrame>("UIFrame");
            
            Instantiate(result);
        }

        private void Start() {
            UIFrame.Instance.OpenWindow(ScreenIds.HomeWindow);
        }
    }
}