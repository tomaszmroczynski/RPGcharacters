﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchar
{
	public class InvalidItemException : Exception
	{
		public InvalidItemException(string message) : base(message)
		{

		}
	}
}
