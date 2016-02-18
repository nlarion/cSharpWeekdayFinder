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
      WeekdayFinder weekdayFinder = new WeekdayFinder(7,11,1);
      Assert.Equal(193, weekdayFinder.FindNumberFromDate());
    }

    [Fact]
    public void GetDayOfTheWeekFromNumberOFDays()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(3,1,2016);
      weekdayFinder.NumberOfLeapYears();
      weekdayFinder.FindNumberFromDate();
      DateTime dateValue = new DateTime(2016, 3, 1);
      Assert.Equal(dateValue.ToString("dddd"), weekdayFinder.FindDayOfWeek());
    }
    [Fact]
    public void GetDayOfTheWeekFromNumberOFDays1()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(2,1,2015);
      weekdayFinder.NumberOfLeapYears();
      weekdayFinder.FindNumberFromDate();
      DateTime dateValue = new DateTime(2015, 2, 1);
      Assert.Equal(dateValue.ToString("dddd"), weekdayFinder.FindDayOfWeek());
    }
    [Fact]
    public void GetDayOfTheWeekFromNumberOFDays2()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(3,1,2014);
      weekdayFinder.NumberOfLeapYears();
      weekdayFinder.FindNumberFromDate();
      DateTime dateValue = new DateTime(2014, 3, 1);
      Assert.Equal(dateValue.ToString("dddd"), weekdayFinder.FindDayOfWeek());
    }
    [Fact]
    public void GetDayOfTheWeekFromNumberOFDays3()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(3,2,2000);
      weekdayFinder.NumberOfLeapYears();
      weekdayFinder.FindNumberFromDate();
      DateTime dateValue = new DateTime(2000, 3, 2);
      Assert.Equal(dateValue.ToString("dddd"), weekdayFinder.FindDayOfWeek());
    }
    [Fact]
    public void GetDayOfTheWeekFromNumberOFDays4()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(2,29,2000);
      weekdayFinder.NumberOfLeapYears();
      weekdayFinder.FindNumberFromDate();
      DateTime dateValue = new DateTime(2000, 2, 29);
      Assert.Equal(dateValue.ToString("dddd"), weekdayFinder.FindDayOfWeek());
    }
    [Fact]
    public void GetDayOfTheWeekFromNumberOFDays5()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(2,28,2000);
      weekdayFinder.NumberOfLeapYears();
      weekdayFinder.FindNumberFromDate();
      DateTime dateValue = new DateTime(2000, 2, 28);
      Assert.Equal(dateValue.ToString("dddd"), weekdayFinder.FindDayOfWeek());
    }
    [Fact]
    public void CountTheLeapYears()
    {
      WeekdayFinder weekdayFinder = new WeekdayFinder(7,11,1000);
      Assert.Equal(242, weekdayFinder.NumberOfLeapYears());
    }


  }
}
