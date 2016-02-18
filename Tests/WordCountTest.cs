using Xunit;
using LeapYearNS.Objects;
using System.Collections.Generic;
using System;
using System.Linq;


namespace LeapYearTestNS
{
  public class WeekdayFinderTest
  {
    [Fact]
    public void TestGetNumberOfDaysFromMonthAndDay()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(7,11);
      Assert.Equal(192, weekdayFinder.FindNumberFromDate());
    }

  }
}
