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
            LoadUIFrame();
        }

        private void Start()
        {
            uiFrame.OpenWindow(ScreenUtils.IsLandscape ? ScreenIds.TapToPlayWindow : ScreenIds.TapToPlayWindowV);
        }

        private void Update()
        {
            
        }

        private void OnDestroy() 
        {

        }

        private void LoadUIFrame()
        {
            var uiFrameName = ScreenUtils.IsLandscape ? "DemoPrefabs/H_UIFrame" : "DemoPrefabs/V_UIFrame";
            var uiFramePrefab = Resources.Load<GameObject>(uiFrameName);
            if (uiFramePrefab)
            {
                Instantiate<GameObject>(uiFramePrefab);
                uiFrame = UIFrame.Instance;
            }
            else
            {
                throw new Exception("DemoPrefabs/UIFrame is not exist");
            }

        }



    }
}