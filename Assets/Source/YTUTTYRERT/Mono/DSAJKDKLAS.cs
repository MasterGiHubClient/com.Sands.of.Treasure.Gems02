﻿using UnityEngine;

namespace Source.UI.Mono
{
    public class DSAJKDKLAS : UIView
    {

        public void PolicyConfirm()
        {
            PlayerPrefs.SetInt("Policy", 1);
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}