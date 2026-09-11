using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public class UIRoot : BaseView
    {
        [SerializeField] private UIMenu uiMenu;
        public UIMenu UIMenu => uiMenu;

        [SerializeField] private UIGameView gameView;
        public UIGameView GameView => gameView;

        private GameManager gameManager;

        public void InitThis(GameManager gameManager)
        {
            this.gameManager = gameManager;
        }
    }
}