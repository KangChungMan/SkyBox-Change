using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.SkyBox.SkyboxScripts.ScriptableObjects;
using Assets.Scripts.SkyBox.SkyboxScripts.Utils;
using UnityEngine;


#region NAMESPACE

namespace Assets.Scripts.SkyBox.SkyboxScripts.TestSkyBox
{
    public class SkyBoxManager : MonoBehaviour
    {
        #region PUBLIC FIELDS

        public SkyBoxList mDatabase;

        #endregion

        #region PRIVATE FIELDS

        private Material _mMaterial;
        private SkyBoxUtils _mSkyBoxUtils;

        #endregion

        #region UNITY EVENT CALLS
        private void Awake()
        {
            _mSkyBoxUtils = new SkyBoxUtils();
            DontDestroyOnLoad(target: this);
        }

        #endregion

        #region HELPER ROUNTINES
        public void DisplaySkyBoxByName(string lookupMaterialName)
        {
            _mMaterial = _mSkyBoxUtils.GetMaterial(mDatabase.MLookupTable, lookupMaterialName);
            _mSkyBoxUtils.DisplaySkyBox(_mMaterial);
        }

        #endregion
    }
}

#endregion