namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using NumericMath;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Converts a relative vector to an absolute vector based on the <c>rect</c>, component-wise.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Rect.NormalizedToPoint.html
		/// </remarks>
		public static Vector2 ToAbsoluteXY(this Vector2 normalizedVector, Rect rect)
		{
			return new Vector2(
				normalizedVector.x.Lerp(rect.x, rect.xMax), 
				normalizedVector.y.Lerp(rect.y, rect.yMax));
		}

		/// <summary>
		/// Converts an absolute vector to a normalized vector relative to the <c>rect</c>, component-wise.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Rect.PointToNormalized.html
		/// </remarks>
		public static Vector2 ToRelativeXY(this Vector2 absoluteVector, Rect rect)
		{
			return new Vector2(
				absoluteVector.x.InverseLerp(rect.x, rect.xMax), 
				absoluteVector.y.InverseLerp(rect.y, rect.yMax));
		}

		public static Vector2Int ToVector2Int(this Vector2 vector)
		{
			return new Vector2Int((int)vector.x, (int)vector.y);
		}
	}
}