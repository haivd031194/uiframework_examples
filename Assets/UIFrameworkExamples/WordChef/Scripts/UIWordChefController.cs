using System;
using System.Collections.Generic;
using deVoid.Utils;
using UnityEngine;

namespace deVoid.UIFramework.Examples
{
    public class UIWordChefController : MonoBehaviour
    {
        private void Awake() {
            Instantiate(Resources.Load<UIFrame>("UIFrame"));
        }

        private void Start() {
            UIFrame.Instance.OpenWindow(ScreenIds.HomeWindow);
        }
    }
}