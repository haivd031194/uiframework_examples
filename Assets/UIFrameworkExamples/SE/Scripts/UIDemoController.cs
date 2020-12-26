using System;
using deVoid.UIFramework;
using UnityEngine;

namespace SE.UIFramework.Examples
{
    public class UIDemoController : MonoBehaviour
    {
        private UIFrame uiFrame;

        private void Awake() 
        {
            LoadUiFrame();
        }

        private void Start()
        {
            uiFrame.OpenWindow(ScreenIds.TapToPlayWindow);
        }

        private void LoadUiFrame()
        {
            var uiFrameName = "UIFrame";
            var uiFramePrefab = Resources.Load<GameObject>(uiFrameName);
            if (uiFramePrefab)
            {
                Instantiate(uiFramePrefab);
                uiFrame = UIFrame.Instance;
            }
            else
            {
                throw new Exception("DemoPrefabs/UIFrame is not exist");
            }

        }



    }
}