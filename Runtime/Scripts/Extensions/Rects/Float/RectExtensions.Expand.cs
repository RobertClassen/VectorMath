namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using NumericMath.Core;
	using UnityEngine;

	public static partial class RectExtensions
	{
		public static Rect Expand(this Rect rect, float margin, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.Expand(margin, margin, margin, margin) : rect;
		}

		public static Rect Expand(this Rect rect, float x, float y, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.Expand(x, x, y, y) : rect;
		}

		public static Rect Expand(this Rect rect, float left, float right, float down, float up, 
			bool isEnabled = Function.IsEnabledDefault)
		{
			if(!isEnabled)
			{
				return rect;
			}
			rect.xMin += left;
			rect.xMax += right;
			rect.yMin += down;
			rect.yMax += up;
			return rect;
		}
	}
}