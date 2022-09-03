using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngleCounter.Extensions
{
    public static class TimeOnlyExtensions
    {
        public static float DegreesBetweenArrows(this TimeOnly time)
        {
            float angleMins = 6f * time.Minute;
            float angleHours = 30f * time.Hour + 0.5f * time.Minute;

            float angleBetween = Math.Abs(angleHours - angleMins);

            if(angleBetween > 180f)
                angleBetween = 360f - angleBetween;

            return angleBetween;
        }
    }
}
