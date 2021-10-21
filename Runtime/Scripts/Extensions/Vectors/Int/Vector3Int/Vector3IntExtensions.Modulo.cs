namespace VectorMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using WellDefinedNumerics;

	public static partial class Vector3IntExtensions
	{
		public static Vector3Int Modulo(this Vector3Int dividend, Vector3Int divisor)
		{
			return new Vector3Int(dividend.x.Modulo(divisor.x), dividend.y.Modulo(divisor.y), dividend.z.Modulo(divisor.z));
		}
	}
}