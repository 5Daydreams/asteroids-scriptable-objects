﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assignment._Code.ScriptableSimpleValues.SingleScriptables
{
    [CreateAssetMenu(fileName = "NewSceneTransition", menuName = "CustomScriptables/SceneTransition")]
    public class SceneTransition : ScriptableObject
    {
        [SerializeField] private string _defaultSceneValue;
      
        public void ChangeToScene()
        {
            SceneManager.LoadScene(_defaultSceneValue);
        }

        public void ChangeToScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
