using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.SkyBox.SkyboxScripts.ScriptableObjects;
using UnityEngine;

#region NAMESPACE

namespace Assets.Scripts.SkyBox.SkyboxScripts.Utils
{
    #region CLASS

    public class SkyBoxUtils
    {
        #region HELPER ROUNTINES

        public Material GetMaterial(Dictionary<string, SkyBoxObject> table, string materialName)
        {
            return table.ContainsKey(materialName) ? table[materialName].mMaterial : null;
        }

        public void DisplaySkyBox(Material material)
        {
            if (material == null) return;
            RenderSettings.skybox = material;
        }

        #endregion

    }

    #endregion
}

#endregion
