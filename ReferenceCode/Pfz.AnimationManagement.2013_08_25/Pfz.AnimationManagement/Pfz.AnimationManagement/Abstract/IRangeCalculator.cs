using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pfz.AnimationManagement.Abstract
{
    public interface IRangeCalculator
    {
        Type DataType { get; }

        object Calculate(object initialValue, object finalValue, TimeSpan actualTime, TimeSpan duration);
    }
	public interface IRangeCalculator<T>:
        IRangeCalculator
	{
		T Calculate(T initialValue, T finalValue, TimeSpan actualTime, TimeSpan duration);
	}
}
