using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region NAMESPACE

namespace Assets.Scripts.SkyBox.SkyboxScripts.ScriptableObjects
{
    #region CLASS
    [CreateAssetMenu(fileName = "SkyBox", menuName = "SkyBox/SkyBoxDate")]
    public class SkyBoxObject : ScriptableObject
    {
        #region PUBBLIC FIELDS

        public Material mMaterial;
        public string mName;


        #endregion
    }

    #endregion
}

#endregion
