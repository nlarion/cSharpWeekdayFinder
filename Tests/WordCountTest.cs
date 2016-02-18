using Xunit;
using LeapYearNS.Objects;
using System.Collections.Generic;
using System;
using System.Linq;


namespace LeapYearTestNS
{
  public class WeekdayFinderTest
  {
    // [Fact]
    // public void TestGetNumberOfDaysFromMonthAndDay()
    // {
    //   WeekdayFinder weekdayFinder = new WeekdayFinder(7,11,1);
    //   Assert.Equal(192, weekdayFinder.FindNumberFromDate());
    // }

    [Fact]
    public void GetDayOfTheWeekFromNumberOFDays()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(7,11,100);
      weekdayFinder.NumberOfLeapYears();
      weekdayFinder.FindNumberFromDate();
      Assert.Equal("Saturday", weekdayFinder.FindDayOfWeek());
    }

    [Fact]
    public void GetDayOfTheWeekFromNumberOFDays2()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(1,1,1);
      weekdayFinder.NumberOfLeapYears();

      weekdayFinder.FindNumberFromDate();
      Assert.Equal("Saturday", weekdayFinder.FindDayOfWeek());
    }

    [Fact]
    public void GetDayOfTheWeekFromNumberOFDays3()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(7,11,200);
      weekdayFinder.NumberOfLeapYears();

      weekdayFinder.FindNumberFromDate();
      Assert.Equal("Friday", weekdayFinder.FindDayOfWeek());
    }

    // [Fact]
    // public void GetDayOfTheWeekFromNumberOFDays4()
    // {
    //   WeekdayFinder weekdayFinder = new WeekdayFinder(7,11,8);
    //   weekdayFinder.NumberOfLeapYears();
    //
    //   weekdayFinder.FindNumberFromDate();
    //   Assert.Equal("Wednesday", weekdayFinder.FindDayOfWeek());
    // }

    // [Fact]
    // public void CountTheLeapYears()
    // {
    //   WeekdayFinder weekdayFinder = new WeekdayFinder(7,11,1000);
    //   Assert.Equal(242, weekdayFinder.NumberOfLeapYears());
    // }
    //

  }
}
