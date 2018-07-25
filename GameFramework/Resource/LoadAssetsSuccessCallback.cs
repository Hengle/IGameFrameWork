﻿//------------------------------------------------------------
// Game Framework v3.x
// Copyright © 2013-2018 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using System.Collections.Generic;

namespace Icarus.GameFramework.Resource
{
    /// <summary>
    /// 加载资源列表成功回调函数。
    /// </summary>
    /// <param name="assetNames">要加载的资源名称列表。</param>
    /// <param name="assets">已加载的资源列表。</param>
    /// <param name="duration">加载持续时间。</param>
    /// <param name="userData">用户自定义数据。</param>
    public delegate void LoadAssetsSuccessCallback(IEnumerable<string> assetNames, IEnumerable<object> assets, float duration, object userData);
}
