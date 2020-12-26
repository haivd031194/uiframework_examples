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
            var uiFramePrefab = Resources.Load<UIFrame>(uiFrameName);
            if (uiFramePrefab)
            {
                uiFrame = Instantiate(uiFramePrefab);
            }
            else
            {
                throw new Exception("DemoPrefabs/UIFrame is not exist");
            }

        }



    }
}