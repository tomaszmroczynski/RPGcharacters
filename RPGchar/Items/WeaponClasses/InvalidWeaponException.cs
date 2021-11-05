using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar.Items.WeaponClasses
{
	/// <summary>
	/// A class used whenever weapon is invaid
	/// </summary>
	public class InvalidWeaponException : Exception
	{
		public  InvalidWeaponException(string message) : base(message)
		{
		}
	}
}
