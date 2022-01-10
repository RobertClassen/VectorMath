namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;
	using NumericMath.Core;
	using UnityEngine;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Linearly interpolates between both vectors by <c>t</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Lerp.html
		/// </remarks>
		public static Vector2 Lerp(this float t, Vector2 a, Vector2 b, bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return new Vector2(
				t.Lerp(a.x, b.x, isClamped), 
				t.Lerp(a.y, b.y, isClamped));
		}
	}
}