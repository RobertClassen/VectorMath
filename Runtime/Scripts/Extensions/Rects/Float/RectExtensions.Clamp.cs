namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using WellDefinedNumerics;
	using WellDefinedNumerics.Core;

	public static partial class RectExtensions
	{
		public static Rect Clamp(this Rect rect, Rect constrainingRect, bool isEnabled = Function.IsEnabledDefault)
		{
			if(!isEnabled)
			{
				return rect;
			}
			rect.xMin = rect.xMin.Clamp(constrainingRect.xMin, constrainingRect.xMax);
			rect.xMax = rect.xMax.Clamp(constrainingRect.xMin, constrainingRect.xMax);
			rect.yMin = rect.yMin.Clamp(constrainingRect.yMin, constrainingRect.yMax);
			rect.yMax = rect.yMax.Clamp(constrainingRect.yMin, constrainingRect.yMax);
			return rect;
		}
	}
}