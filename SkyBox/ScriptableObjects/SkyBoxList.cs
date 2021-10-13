using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region NAMESPACE

namespace Assets.Scripts.SkyBox.SkyboxScripts.ScriptableObjects
{
    #region CLASS
    [CreateAssetMenu(fileName = "SkyBoxDatabase", menuName = "SkyBoxDatabase/SkyBoxObjectDatabase")]
    public class SkyBoxList : Template.ScriptableObjectTemplate<SkyBoxObject>
    {
        #region PUBBLIC FIELDS

        public List<SkyBoxObject> mSkyBoxList = new List<SkyBoxObject>();

        #endregion

        #region PRIVATE FLELDS

        public Dictionary<string, SkyBoxObject> MLookupTable { get; } = new Dictionary<string, SkyBoxObject>();

        #endregion

        #region EVENT ROUTINES

        private void OnEnable()
        {
            mSkyBoxList?.ForEach(c => MLookupTable[c.mName] = c);
        }

        #endregion
    }

    #endregion
}

#endregion
