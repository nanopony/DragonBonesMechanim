﻿using UnityEngine;

namespace DragonBones
{
    /**
     * @language zh_CN
     * Unity 贴图集数据。
     * @version DragonBones 3.0
     */
    public class UnityTextureAtlasData : TextureAtlasData
    {
        /**
         * @private
         */
        internal bool _disposeTexture;
        /**
         * @language zh_CN
         * Unity 贴图。
         * @version DragonBones 3.0
         */
        public Material texture;
        /**
         * @private
         */
        public UnityTextureAtlasData()
        {
        }
        /**
         * @private
         */
        override protected void _onClear()
        {
            base._onClear();

            if (_disposeTexture && texture != null)
            {
#if UNITY_EDITOR
                //Object.DestroyImmediate(texture);
#else
                Object.Destroy(texture);
#endif
            }

            _disposeTexture = false;
            texture = null;
        }
        /**
         * @private
         */
        override public TextureData GenerateTextureData()
        {
            return BaseObject.BorrowObject<UnityTextureData>();
        }
    }
    /**
     * @private
     */
    public class UnityTextureData : TextureData
    {
        public UnityTextureData()
        {
        }
    }
}