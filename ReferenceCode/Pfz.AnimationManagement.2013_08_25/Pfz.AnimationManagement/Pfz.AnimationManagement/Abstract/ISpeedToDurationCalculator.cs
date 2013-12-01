using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pfz.AnimationManagement.Abstract
{
    public interface ISpeedToDurationCalculator
    {
        Type DataType { get; }

        TimeSpan CalculateDuration(object initialValue, object finalValue, double speed);
    }
    public interface ISpeedToDurationCalculator<T>:
        ISpeedToDurationCalculator
    {
        TimeSpan CalculateDuration(T initialValue, T finalValue, double speed);
    }
}
